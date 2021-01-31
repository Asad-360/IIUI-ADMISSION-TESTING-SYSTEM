using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.ServiceModel;
using ServerInterfaces;
using MaterialSkin;
using System.IO;

namespace AdminSystem
{
    public partial class Form1 : Form
    {
        private PreloaderDialog preloader = new PreloaderDialog();
        private bool IsSignUpSuccessfull;
        private bool IsPasswordNotConfirmed;
        private bool IsImageNotUploaded;
        private bool IsLoginSuccessfull;
        private string imageLocation;
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;

        public Form1()
        {
            InitializeComponent();
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
            panelSignUp.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {


            ////////////////////////////////
            Loading_On();
            backgroundWorker1.RunWorkerAsync();

        }


        private void Loading_On()
        {
            Cursor.Current = Cursors.WaitCursor;
            //pictureBox1.Visible = true;
            Cursor.Current = Cursors.Arrow;
        }


        private void Loading_Off()
        {
            Cursor.Current = Cursors.Arrow;
            //  pictureBox1.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
        //        api = channelFactory.CreateChannel();
        //        string username = userBox.Text;
        //        string password = passBox.Text;
        //        bool IsLogin = api.AdminLogin(username, password);
        //        if (IsLogin)
        //        {
        //            Loading_Off();
        //            MessageBox.Show("Login Successfull");

        //        }
        //        else
        //        {
        //            Loading_Off();
        //            MessageBox.Show("Login Failed");

        //        }

        //    }
        //    catch (Exception Error)
        //    {

        //        MessageBox.Show(Error.Message);
        //        MetroFramework.MetroMessageBox.Show(this, "Hand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Loading_Off();
        //}

        //private void logButton_Click(object sender, EventArgs e)
        //{
        //    Loading_On();
        //    backgroundWorker1.RunWorkerAsync();
        //}

        private void userBox_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignUp.Visible = false;
            // adminPicture.Image = Image.FromFile(@"\Resources\Student-3-icon (1).png");
            adminPicture.Image = Properties.Resources.Student_3_icon__1_;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSignUp.Visible = true;
        }
        /// <summary>
        /// 
        /// fucntion to locate the image in the folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void imageButton_Click(object sender, EventArgs e)
        //{
        //    // open file dialog   
        //    OpenFileDialog open = new OpenFileDialog();
        //    // image filters  
        //    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        ovalPictureBox1.Image = new Bitmap(open.FileName);
        //        imageLocation = open.FileName.ToString();
        //        // textBox1.Text = open.FileName;
        //        MessageBox.Show(imageLocation);
        //    }
        //}

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
            backgroundWorkerForSignUp.RunWorkerAsync();
            preloader.ShowDialog();
        }

        private void ovalPictureBox2_Click(object sender, EventArgs e)
        {
            if (checkPanelVisible(panelSignUp))
            {
                MessageBox.Show("Yes you can upload image");
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    adminPicture.Image = new Bitmap(open.FileName);
                    imageLocation = open.FileName.ToString();
                    // textBox1.Text = open.FileName;
                    MessageBox.Show(imageLocation);
                }
            }

            else
            {
                MessageBox.Show("No you cant upload image");
            }
        }


        private bool checkPanelVisible(Panel panel)
        {
            bool flag = false;
            if (panel.Visible)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void backgroundWorkerForSignUp_DoWork(object sender, DoWorkEventArgs e)
        {
            AdministratorInfo adminInfo = new AdministratorInfo();
            byte[] img = null;
            if (imageLocation == null || imageLocation =="")
            {
                IsImageNotUploaded = true;
                return;
            }
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPassowordBox.Text;
            int cnic;
            bool flag = int.TryParse(cnicBox.Text, out cnic);
            if ((password != confirmPassword) || (!flag))
            {
                IsPasswordNotConfirmed = true;              
                return;
            }
            adminInfo.UserName = username;
            adminInfo.Password = password;
            adminInfo.Cnic = cnic;
            adminInfo.Image = img;
            //bool executionState = api.SendAdminInfo(username, password, cnic, img);
            IsSignUpSuccessfull = api.AdminRegistration(adminInfo);

        }

        private void backgroundWorkerForSignUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsImageNotUploaded)
            {
                MessageBox.Show("Please Upload The Image");
                IsImageNotUploaded = false;
                return;
            }
            if (IsSignUpSuccessfull)
            {
                MessageBox.Show("Sign Up Successfull");
                ClearSignUpForm();
                IsSignUpSuccessfull = false;
            }
            else
            {
                MessageBox.Show("Sign Up Failed");
               // ClearSignUpForm();
            }
            if (IsPasswordNotConfirmed)
            {
                MessageBox.Show("Wrong Information Please Check information again");
                IsPasswordNotConfirmed = false;
            }
         
        }


        private void ClearSignUpForm()
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
            confirmPassowordBox.Text = "";
            cnicBox.Text = "";
            adminPicture.Image = Properties.Resources.Student_3_icon__1_;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            backgroundWorkerForLogin.RunWorkerAsync();
            preloader.ShowDialog();
        }

        private void backgroundWorkerForLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            AdministratorInfo adminLogin = new AdministratorInfo();
            adminLogin.UserName = userBox.Text;
            adminLogin.Password = passBox.Text;
             IsLoginSuccessfull = api.AdminLogin(adminLogin);
           
        }

        private void backgroundWorkerForLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsLoginSuccessfull)
            {
                MessageBox.Show("Login SuccessFull");
              //  new HomePage().Show();
              //  this.Close();

                this.Hide();
                var form2 = new HomePage();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    } // end of the partial class

} // end of the namespacek
