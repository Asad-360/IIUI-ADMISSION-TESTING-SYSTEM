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
    public partial class CourseRegistration : UserControl
    {

        #region Initialized Variables
        public static CourseRegistration _CourseRegistration;
        private PreloaderDialog preloader = new PreloaderDialog();
        #endregion

        #region DECLEARED VARIABLES
        /// <summary>
        /// WCF SOAP SERVICES VARIABLES
        /// </summary>
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;

        /// <summary>
        /// Variables for getting data from the table gridview
        /// </summary>
        string examcourseId;
        string examCourseName;
        string examCourseTotalQuestions;
        string examCourseTimeDuration;
        string examCourseMarksPerQuestion;
        #endregion

        #region FLAG VARIABLES
        bool IsMarksConvertible;
        bool IsTotalQuestionsConvertible;
        bool IsExamCourseAdded;
        bool IsExamCourseUpdated;
        bool IsTimeDurationForConvertible;
        bool IsCourseIdValid;
        bool IsTotalMarks;
        bool IsTimeDuraton;
        bool IsTotalQuestion;
        #endregion

        #region CONSTRUCTOR AND SINGLE INSTANCE METHOD

        /// <summary>
        /// Constructor for this Class
        /// </summary>
        public CourseRegistration()
        {
            InitializeComponent();
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
            backgroundWorkerForPageLoad.RunWorkerAsync();
            preloader.ShowDialog();
        }
        /// <summary>
        /// Singleton Pattern for screen change in home page.
        /// </summary>
        public static CourseRegistration Instance
        {
            get
            {
                if (_CourseRegistration == null)
                    _CourseRegistration = new CourseRegistration();
                return _CourseRegistration;
            }
        }

        #endregion

        #region EVENTS
        /// <summary>
        /// Event to add the course to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCourseButton_Click(object sender, EventArgs e)
        {
            backgroundWorkerForAddCourse.RunWorkerAsync();
            preloader.ShowDialog();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Delete Record?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                backgroundWorkerForDeleteCourse.RunWorkerAsync();
                preloader.ShowDialog();
            }
            else
            {
                return;
            }
        }
        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            backgroundWorkerForUpdate.RunWorkerAsync();
            preloader.ShowDialog();
        }

        private void ExamCourseDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ExamCourseDataGrid.CurrentRow.Index != -1)
            {
                examcourseId = ExamCourseDataGrid.CurrentRow.Cells["courseid"].Value.ToString().Trim();
                examCourseName = ExamCourseDataGrid.CurrentRow.Cells["courseName"].Value.ToString().Trim();
                examCourseTotalQuestions = ExamCourseDataGrid.CurrentRow.Cells["totalQuestions"].Value.ToString().Trim();
                examCourseTimeDuration = ExamCourseDataGrid.CurrentRow.Cells["timeDuration"].Value.ToString().Trim();
                examCourseMarksPerQuestion = ExamCourseDataGrid.CurrentRow.Cells["marksPerQuestions"].Value.ToString().Trim();
                populateForm();
                courseCodeField.Enabled = false;
            }
        }
        #endregion

        #region BACKGROUND WORKERS DOWORK

        private void backgroundWorkerForAddCourse_DoWork(object sender, DoWorkEventArgs e)
        {

            ExamPaper paper = new ExamPaper();

            int marks;
            IsMarksConvertible = int.TryParse(marksPerQuestionField.Text.Trim(), out marks);

            int timeDuration;
            IsTimeDurationForConvertible = int.TryParse(timeDurationField.Text.Trim(), out timeDuration);

            int totalQuestions;
            IsTotalQuestionsConvertible = int.TryParse(totalQuestionField.Text.Trim(), out totalQuestions);

            IsCourseIdValid = checkCourseId(courseCodeField.Text.Trim());
            MessageBox.Show(IsCourseIdValid.ToString());
            if ((!IsTotalQuestionsConvertible) || (!IsMarksConvertible) || (!IsTimeDurationForConvertible) || (!IsCourseIdValid))
            {
                return;
            }

            paper.Id = courseCodeField.Text.Trim();
            paper.Name = courseNameField.Text.Trim();
            paper.TimeDuration = timeDuration;
            paper.MarksPerQuestion = marks;
            paper.TotalQuestions = totalQuestions;

            IsExamCourseAdded = api.AddExamPaper(paper);

        }

        private void backgroundWorkerForPageLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            ClearForm();
            PopulateInDataGrid();

        }
        bool IsExamPaperDeleted;
        private void backgroundWorkerForDeleteCourse_DoWork(object sender, DoWorkEventArgs e)
        {
            IsExamPaperDeleted = api.DeleteExamPaper(examcourseId);
        }
        #endregion

        #region BACKGROUND WORKERS WORKCOMPLETED

        private void backgroundWorkerForUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (!IsTotalMarks)
            {
                MessageBox.Show("Please Enter Correct Marks");
            }

            if (!IsTotalQuestion)
            {
                MessageBox.Show("Please Enter Correct total Questions");
            }
            if (!IsTimeDuraton)
            {
                MessageBox.Show("Please Enter Correct Time Duration");
            }

            if (IsExamCourseUpdated)
            {
                MessageBox.Show("Course Updated Successfully");
                ClearForm();
                PopulateInDataGrid();
            }
            else
            {
                MessageBox.Show("Course Update Failed");
            }
            // refresh the trigger for the next attempt
            IsExamCourseUpdated = false;
        }
        private void backgroundWorkerForAddCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (!IsCourseIdValid)
            {
                MessageBox.Show("The Course Id Is Wrong Already Assigned To Course");
            }
            if (!IsTotalQuestionsConvertible)
            {
                MessageBox.Show("Please Enter Correct Total Questions");
            }
            if (!IsMarksConvertible)
            {
                MessageBox.Show("Please Enter Correct Marks");
            }
            if (!IsTimeDurationForConvertible)
            {
                MessageBox.Show("Please Enter Correct Time Duration");
            }
            if (IsExamCourseAdded)
            {
                MessageBox.Show("Course Added Successfully");
            }
            IsExamCourseAdded = false;
            PopulateInDataGrid();
        }


        private void backgroundWorkerForPageLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
        }

        private void backgroundWorkerForDeleteCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preloader.Hide();
            if (IsExamPaperDeleted)
            {
                MessageBox.Show("Exam Paper Deleted Successfully!");
                PopulateInDataGrid();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Exam Paper Delete Failed!");
            }
            IsExamPaperDeleted = false;
        }

        private void backgroundWorkerForUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            ExamPaper ePaper = new ExamPaper();
            ePaper.Id = courseCodeField.Text.Trim();
            ePaper.Name = courseNameField.Text.Trim();

            int totalMarksPerQuestion;
            IsTotalMarks = int.TryParse(marksPerQuestionField.Text.Trim(), out totalMarksPerQuestion);
            ePaper.MarksPerQuestion = totalMarksPerQuestion;

            int totalTimeDuration;
            IsTimeDuraton = int.TryParse(timeDurationField.Text.Trim(), out totalTimeDuration);
            ePaper.TimeDuration = totalTimeDuration;

            int totalQuestions;
            IsTotalQuestion = int.TryParse(totalQuestionField.Text.Trim(), out totalQuestions);
            ePaper.TotalQuestions = totalQuestions;

            if ((!IsTimeDuraton) || (!IsTotalQuestion) || (!IsTotalMarks))
            {
                return;
            }

            IsExamCourseUpdated = api.UpdateExamPaper(ePaper);
        }
        #endregion

        #region CUSTOM METHODS
        private void PopulateInDataGrid()
        {

            ExamCourseDataGrid.DataSource = api.getExamPaperCourse();
        }


        /// <summary>
        /// Function to clear the form of the exampaper
        /// </summary>
        private void ClearForm()
        {
            courseCodeField.Text = "";
            courseNameField.Text = "";
            timeDurationField.Text = "";
            marksPerQuestionField.Text = "";
            totalQuestionField.Text = "";
        }


        /// <summary>
        /// Function to populate the form upon the double click on the datagridview.
        /// </summary>
        private void populateForm()
        {
            courseCodeField.Text = examcourseId;
            courseNameField.Text = examCourseName;
            totalQuestionField.Text = examCourseTotalQuestions;
            timeDurationField.Text = examCourseTimeDuration;
            marksPerQuestionField.Text = examCourseMarksPerQuestion;
        }

        private bool checkCourseId(string courseId)
        {
            bool IsFound = true;
            foreach (var examlist in api.getExamPaperCourse())
            {
                MessageBox.Show(examlist.Id);
                if (examlist.Id == courseId)
                {
                    IsFound = false;
                    break;
                }
            }
            return IsFound;
        }
        #endregion

    }
}
