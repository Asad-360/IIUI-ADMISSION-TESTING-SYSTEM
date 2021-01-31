using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerInterfaces;
using System.ServiceModel;

namespace AdminSystem
{
    public partial class PaperPool : UserControl
    {
        #region INITIALIZED VARIABLES
        PreloaderDialog preloader = new PreloaderDialog();
        List<ExamQuestion> examQuestionList = new List<ExamQuestion>();
        #endregion

        #region FLAG VARIABLES
        bool IsProgressRangeSet;
        bool IsExamQuestionPaperAdded;
        #endregion

        #region DECLEARED VARIABLES
        /// <summary>
        /// WCF SOAP SERVICES VARIABLES
        /// </summary>
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;
        public static PaperPool _PaperPool;
        #endregion

        #region  CONSTRUCTOR AND SINGLE INSTANCE METHOD     
        public static PaperPool Instance
        {
            get
            {
                if (_PaperPool == null)
                    _PaperPool = new PaperPool();
                return _PaperPool;
            }
        }

        public PaperPool()
        {
            InitializeComponent();
            finishPaperButton.Enabled = false;
            //updateButton.Enabled = false;
           
            saveAndNextButton.Enabled = false;
            cancelPaperButton.Enabled = false;
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
            populateComboBox();
        }

        #endregion

        private void PaperPool_Load(object sender, EventArgs e)
        {

        }
        string correctAns = "";
        int questionCounter = 0;
        int progressBarCounter = 0;
        int questions;
        private void saveAndNextButton_Click(object sender, EventArgs e)
        {

            ExamQuestion question = new ExamQuestion();
            string courseCode = courseCodeField.Text.Trim();
            string questionText = questionField.Text.Trim();
            string optionA = optionAField.Text.Trim();
            string optionB = optionBField.Text.Trim();
            string optionC = optionCField.Text.Trim();
            string optionD = optionDField.Text.Trim();

            if ((courseCode == "") || (questionText == "") || (optionA == "") || (optionB == "") || (optionC == "") || (optionD == ""))
            {
                MessageBox.Show("Please Fill out all the information!");
                return;
            }

            question.PaperId = courseCode;
            question.Question1 = questionText;
            question.OptionA = optionA;
            question.OptionB = optionB;
            question.OptionC = optionC;
            question.OptionD = optionD;

            if (optionAButton.Checked)
            {
                correctAns = "A";
            }
            else if (optionBButton.Checked)
            {
                correctAns = "B";
            }
            else if (optionCButton.Checked)
            {
                correctAns = "C";
            }
            else if (optionDButton.Checked)
            {
                correctAns = "D";
            }
            else
            {
                MessageBox.Show("Please Select any Correct choice of Answer!");
                return;
            }
            question.CorrectAns = correctAns;
            //  questions = api.CheckTotalQuestions(courseCode);

            if (questionCounter != 0)
            {
                examQuestionList.Add(question);
                setProgressBarRange(questions);
                paperProgressBar.Value = ++progressBarCounter;
                questionCounter--;

            }
            else
            {
                finishPaperButton.Enabled = true;
                MessageBox.Show("Question Paper Total Limit is full");
                progressBarCounter = 0;
            }
            clearForm();
        }
        string initialCourseCode;
        /// <summary>
        /// Event to add new Paper 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewPaperButton_Click(object sender, EventArgs e)
        {
            initialCourseCode = courseCodeField.Text.Trim();
            if (initialCourseCode != "")
            {
                if (api.IsPaperEligible(initialCourseCode))
                {
                    questions = api.CheckTotalQuestions(initialCourseCode);
                    questionCounter = questions;
                    addNewPaperButton.Enabled = false;
                    MessageBox.Show("Please Add Question to your Paper Now");
                    courseCodeField.Enabled = false;
                    saveAndNextButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Paper not eligible");
                }
              
            }
            else
            {
                MessageBox.Show("Please Enter the Course Code Number before Making new Paper");
                return;
            }

        }

        /// <summary>
        /// Function to set the progress of the of the progress bar it is done one time
        /// </summary>
        /// <param name="range"></param>
        private void setProgressBarRange(int range)
        {
            if (!IsProgressRangeSet)
            {
                paperProgressBar.Minimum = 0;
                paperProgressBar.Maximum = range;
                IsProgressRangeSet = true;
            }
        }

        private void clearForm()
        {
            // courseCodeField.Text = "";
            questionField.Text = "";
            optionAField.Text = "";
            optionBField.Text = "";
            optionCField.Text = "";
            optionDField.Text = "";
            optionAButton.Checked = false;
            optionBButton.Checked = false;
            optionCButton.Checked = false;
            optionDButton.Checked = false;
        }

         /// <summary>
         /// Function to cancel the existing paper
         /// </summary>
        private void cancelPaper()
        {
            paperProgressBar.Value = 0;
            clearForm();
            finishPaperButton.Enabled = false;
            courseCodeField.Enabled = true;
        }
        private void finishPaperButton_Click(object sender, EventArgs e)
        {
            backgroundWorkerToSavePaper.RunWorkerAsync();
            preloader.ShowDialog();
        }

        private void populateComboBox()
        {
            var epaper = api.getAllCourses();
            foreach (var item in epaper)
            {
                courseComboBox.Items.Add(item.Id);
            }

        }

        private void showPaperButton_Click(object sender, EventArgs e)
        {
            paperDataGrid.DataSource = api.getAllQuestions(courseComboBox.SelectedText.ToString());
            
                       
        }


        private void paperSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            (paperDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("optionA='{0}'", paperSearchBox.Text);
        }

        private void cancelPaperButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel Paper?" , "Cancel Paper" , MessageBoxButtons.YesNo);
            if (result== DialogResult.Yes)
            {
                cancelPaper();
            }
            else
            {
                return;
            }
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerToSavePaper_DoWork(object sender, DoWorkEventArgs e)
        {
            IsExamQuestionPaperAdded = api.AddExamQuestionPaper(examQuestionList);
         
        }

        private void backgroundWorkerToSavePaper_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsExamQuestionPaperAdded)
            {
                MessageBox.Show("Paper Added Successfully");
                addNewPaperButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sorry Operation Failed");
            }
        }
    }
}
