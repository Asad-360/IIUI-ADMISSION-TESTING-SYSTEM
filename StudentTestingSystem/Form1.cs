using ServerInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTestingSystem
{
    public partial class Form1 : Form
    {
        private StudentInfo studentInfo = new StudentInfo();
        private StudentInfo studentInfoForQuiz = new StudentInfo();
        private bool IsStudentLogin;
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;
        private PreloaderDialog preloader = new PreloaderDialog();
        public Form1()
        {
            InitializeComponent();
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
        }

        private void studentLoginButton_Click(object sender, EventArgs e)
        {
            studentLoginBackgroundWorker.RunWorkerAsync();
            preloader.ShowDialog();
           
        }

        private void studentLoginBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
               
                studentInfo.Name = usernameField.Text.Trim();
                int cnic;
                if (int.TryParse(passwordField.Text.Trim(), out cnic))
                {
                    studentInfo.StudentCnic = cnic;
                }
                else
                {
                    MessageBox.Show("Wrong CNIC");
                    return;
                }


                IsStudentLogin = api.StudentLogin(studentInfo);
                if (IsStudentLogin)
                {
                    studentInfoForQuiz = api.getStudentInfo(cnic);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentLoginBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsStudentLogin)
            {
              //  MessageBox.Show(studentInfoForQuiz.StudentCnic.ToString()+" CNic");
                MessageBox.Show("Login Successfull");

                this.Hide();
                var form2 = new QuizSystem(studentInfoForQuiz);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                //new QuizSystem(studentInfoForQuiz).Show();
              
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
