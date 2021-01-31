using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServerInterfaces;
using System.IO;

namespace AdminSystem
{
    public partial class StudentRegistration : UserControl
    {
        #region VARIABLES
        /// <summary>
        /// Variable for just the Flag Purposes for background thread!
        /// </summary>
        bool IsFileSizeNotOk;
        bool IsCnicNoNotOk;
        bool IsPhoneNoNotOk;
        bool IsUpdateCompleted;
        bool IsDeleteCompleted;


        private string workCompletetionStatus;
        private PreloaderDialog preloader = new PreloaderDialog();
        private string imageLocation = null;
        public static StudentRegistration _UserControl1;

        /// <summary>
        /// WCF SOAP SERVICES VARIABLES
        /// </summary>
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;
        #endregion

        public static StudentRegistration Instance
        {
            get
            {
                if (_UserControl1 == null)
                    _UserControl1 = new StudentRegistration();
                return _UserControl1;
            }
        }
        public StudentRegistration()
        {
            InitializeComponent();
            // searchById.Text = "Enter Id here...";

            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
            backgroundWorkerForTableLoading.RunWorkerAsync();
            preloader.ShowDialog();

        }



        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ovalPictureBox1.Image = new Bitmap(open.FileName);
                imageLocation = open.FileName.ToString();
                // textBox1.Text = open.FileName;
                MessageBox.Show(imageLocation);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();
            preloader.ShowDialog();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //MessageBox.Show("Starting Work");
            //preloader.ShowDialog();
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();



            string username = nameField.Text;
            string fatherName = fatherNameField.Text;
            int cnic;
            int phone;
            bool flag = int.TryParse(cnicField.Text, out cnic);
            if (!flag)
            {
                IsCnicNoNotOk = true;
                return;
            }

            bool flag2 = int.TryParse(phoneNoField.Text, out phone);
            if (!flag2)
            {
                IsPhoneNoNotOk = true;
                return;
            }

            string Email = emailField.Text;
            string gender = "";
            if (maleButton.Checked)
            {
                gender = "M";
            }
            else if (femaleButton.Checked)
            {
                gender = "F";
            }
            string batch = batchBox.SelectedItem.ToString();
            DateTime date = dateBox.Value;
            string address = addressBox.Text;
            string courseId = courseIdBox.Text.Trim();
            /// code for the byte image
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            /// ///////////////////////
            /// 
            if ((img.Length / 1024) > 50)
            {
                IsFileSizeNotOk = true;
                //Display error message.               
                return;
            }


            bool executionState = api.SendStudentInfo(username, fatherName, cnic, phone, Email, gender, batch, date, address, img , courseId);
            if (executionState)
            {
                workCompletetionStatus = "Data added Successfull";
                ClearStudentInformationTable();
            }

            else
            {
                workCompletetionStatus = "Failed To Upload Data";
            }
            //  PopulateInDataGrid();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (workCompletetionStatus != null)
            {
                MessageBox.Show(workCompletetionStatus);
            }

            if (IsFileSizeNotOk)
            {
                MessageBox.Show("Sorry The Image Size Must Be Upto 50 KB");
                IsFileSizeNotOk = false;
            }

            if (IsCnicNoNotOk)
            {
                MessageBox.Show("Wrong CNIC No Please Check information again");
                IsCnicNoNotOk = false;
            }

            if (IsPhoneNoNotOk)
            {
                MessageBox.Show("Wrong Phone No Please Check information again");
                IsPhoneNoNotOk = false;
            }
            PopulateInDataGrid();
        }




        private void PopulateInDataGrid()
        {

            tableGrid.DataSource = api.GetStudentDataList();
        }

        private void backgroundWorkerForTableLoading_DoWork(object sender, DoWorkEventArgs e)
        {

            PopulateInDataGrid();
        }

        private void backgroundWorkerForTableLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
        }
        int StudentCnicID;
        string StudentName;
        string fatherName;
        string dateOfBirth;
        string batch;
        string phoneNo;
        string address;
        string email;
        string gender;
        string courseId;
        private void StudentInformationGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableGrid.CurrentRow.Index != -1)
            {
                StudentCnicID = Convert.ToInt32(tableGrid.CurrentRow.Cells["Cnic"].Value);
                //    string Name = StudentInformationGrid.CurrentRow.Cells["Cnic"].Value.ToString();
                StudentName = tableGrid.CurrentRow.Cells["name"].Value.ToString().Trim();
                nameField.Text = StudentName;

                fatherName = tableGrid.CurrentRow.Cells["fName"].Value.ToString().Trim();
                fatherNameField.Text = fatherName;

                string cnic = tableGrid.CurrentRow.Cells["studentCnic"].Value.ToString().Trim();
                cnicField.Text = cnic;

                dateOfBirth = tableGrid.CurrentRow.Cells["studentDob"].Value.ToString().Trim();
                dateBox.Text = dateOfBirth;

                batch = tableGrid.CurrentRow.Cells["studentBatch"].Value.ToString().Trim();
                batchBox.SelectedItem = batch;

                phoneNo = tableGrid.CurrentRow.Cells["studentPhoneNo"].Value.ToString().Trim();
                phoneNoField.Text = phoneNo;

                address = tableGrid.CurrentRow.Cells["studentAddress"].Value.ToString().Trim();
                addressBox.Text = address;

                email = tableGrid.CurrentRow.Cells["e_mail"].Value.ToString().Trim();
                emailField.Text = email;

                gender = tableGrid.CurrentRow.Cells["studentGender"].Value.ToString().Trim();

                courseId= tableGrid.CurrentRow.Cells["studentExamPaperId"].Value.ToString().Trim();
                courseIdBox.Text = courseId;

                if (gender == "M")
                {
                    maleButton.Checked = true;
                }
                else if (gender == "F")
                {
                    femaleButton.Checked = true;
                }

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BackgroundWorkerForUpdate.RunWorkerAsync();
            preloader.ShowDialog();

        }

        /// <summary>
        /// Button Event To Delete The Student Record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete the Student Record?", "Delete Student Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackgroundWorkerForDelete.RunWorkerAsync();
                preloader.ShowDialog();
               
            }
            else if (dialogResult == DialogResult.No)
            {
                ClearStudentInformationTable();
                return;
            }

        }


        private void ClearStudentInformationTable()
        {
            ovalPictureBox1.Image = Properties.Resources.Student_3_icon__1_;
            nameField.Text = "";
            fatherNameField.Text = "";
            cnicField.Text = "";
            dateBox.Text = "";
            maleButton.Checked = false;
            femaleButton.Checked = false;
            phoneNoField.Text = "";
            batchBox.SelectedIndex = -1;
            emailField.Text = "";
            dateBox.Text = "";
            StudentCnicID = 0;
            addressBox.Text = "";
        }

        private void BackgroundWorkerForUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            string radioButtonCheck;
            StudentInfo info = new StudentInfo();
            info.StudentCnic = Convert.ToInt32(cnicField.Text.Trim());
            info.Name = nameField.Text.Trim();
            info.FatherName = fatherNameField.Text.Trim();
            info.PhoneNo = Convert.ToInt32(phoneNoField.Text.Trim());
            info.Email = emailField.Text.Trim();
            if (maleButton.Checked)
            {
                radioButtonCheck = "M";
            }
            else
            {
                radioButtonCheck = "F";
            }
            info.Gender = radioButtonCheck;
            info.Batch = batchBox.SelectedItem.ToString().Trim();
            info.DateOfBirth = dateBox.Value.Date;
            info.Address = addressBox.Text.Trim();
            IsUpdateCompleted =  api.UpdateUsingObject(info);            
        }

        private void BackgroundWorkerForUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsUpdateCompleted)
            {
                MessageBox.Show("Student Record Updated Successfully");
                ClearStudentInformationTable();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            PopulateInDataGrid();
        }

        private void BackgroundWorkerForDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            
            IsDeleteCompleted = api.DeleteStudentInfo(StudentCnicID);
           
        }

        private void BackgroundWorkerForDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsDeleteCompleted)
            {
                MessageBox.Show("Student Record Deleted Successfully");
                PopulateInDataGrid();
            }
            else
            {
                MessageBox.Show("Failed To Delete Student Record");
            }
            ClearStudentInformationTable();
        }

        private void tableGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableGrid.CurrentRow.Index != -1)
            {
                StudentCnicID = Convert.ToInt32(tableGrid.CurrentRow.Cells["studentCnic"].Value);
                //    string Name = StudentInformationGrid.CurrentRow.Cells["Cnic"].Value.ToString();
                StudentName = tableGrid.CurrentRow.Cells["name"].Value.ToString().Trim();
                nameField.Text = StudentName;

                fatherName = tableGrid.CurrentRow.Cells["fName"].Value.ToString().Trim();
                fatherNameField.Text = fatherName;

                string cnic = tableGrid.CurrentRow.Cells["studentCnic"].Value.ToString().Trim();
                cnicField.Text = cnic;

                dateOfBirth = tableGrid.CurrentRow.Cells["studentDob"].Value.ToString().Trim();
                dateBox.Text = dateOfBirth;

                batch = tableGrid.CurrentRow.Cells["studentBatch"].Value.ToString().Trim();
                batchBox.SelectedItem = batch;

                phoneNo = tableGrid.CurrentRow.Cells["studentPhoneNo"].Value.ToString().Trim();
                phoneNoField.Text = phoneNo;

                address = tableGrid.CurrentRow.Cells["studentAddress"].Value.ToString().Trim();
                addressBox.Text = address;

                email = tableGrid.CurrentRow.Cells["e_mail"].Value.ToString().Trim();
                emailField.Text = email;

                gender = tableGrid.CurrentRow.Cells["studentGender"].Value.ToString().Trim();

              //  courseId = tableGrid.CurrentRow.Cells["studentExamPaperId"].Value.ToString().Trim();
               courseIdBox.Text = "N/A";

                if (gender == "M")
                {
                    maleButton.Checked = true;
                }
                else if (gender == "F")
                {
                    femaleButton.Checked = true;
                }

            }
        }
    }
}
