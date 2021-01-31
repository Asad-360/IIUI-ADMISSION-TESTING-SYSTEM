using ServerInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTestingSystem
{
    public partial class QuizSystem : Form
    {

        private int index = 0;
        private int minutes;
        private int totalSecondsElapsed;
        List<Question> question;
        private ChannelFactory<IServerService> channelFactory;
        private IServerService api;
        private string optionSelected = " ";
        private List<string> optionlist = new List<string>();
        private long studentCnic;
        public QuizSystem(StudentInfo info)

        {
          //  MessageBox.Show(info.StudentCnic.ToString());
            InitializeComponent();
            channelFactory = new ChannelFactory<IServerService>("AdmissionSystemEndPoint");
            api = channelFactory.CreateChannel();
            studentCnic = info.StudentCnic;
            StudentNameLable.Text = info.Name;
            courseLabel.Text = info.ExamPaperId;

            if (info.StudentImage != null)
            {
                studentImageBox.Image = byteArrayToImage(info.StudentImage);
            }
            question = api.getAllQuestionsForQuiz(info.StudentCnic);
            fillOptionList();
            totalQuestionLabel.Text = question.Count.ToString();
            minutes = api.getTotalTime(info.ExamPaperId);
            //  minutes = 1;
         //   MessageBox.Show("Minutes is=" + minutes);

            initializeTime(seconds, minutes = minutes - 1);

            totalSecondsElapsed = ((minutes * 2) * 60) - 1;
            if (totalSecondsElapsed > 0)
            {
                totalSecondsElapsed = ((minutes * 2) * 60) - 1;
            }
            else
            {
                totalSecondsElapsed = 60 - 1;
            }
            testProgressBar.Maximum = totalSecondsElapsed;
            nextQuestion();
            quizClockTimer.Start();



            //    MessageBox.Show("Total Question is=" + question.Count);
            //    MessageBox.Show("Total Time is ="+totalTime);

        }

        /// <summary>
        /// FUNCTION TO CONVERT THE IMAGE TO THE BITMAP IMAGE THAT CAN BE DISPLAYED IN THE PICTURE BOX
        /// </summary>
        /// <param name="blob">IMAGE IN THE BYTE FORM</param>
        /// <returns> BITMAP IMAGE</returns>

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void initializeTime(int minute, int seconds)
        {

            if (minute < 10)
            {
                minuteLabel.Text = "0" + minute.ToString();
            }
            else
            {
                minuteLabel.Text = minute.ToString();
            }
            if (seconds < 10)
            {
                secondsLabel.Text = "0" + seconds.ToString();
            }
            else
            {
                secondsLabel.Text = seconds.ToString();
            }

        }

        private void setProgress()
        {
            if (totalSecondsElapsed >= testProgressBar.Minimum)
            {
                testProgressBar.Value = totalSecondsElapsed;
            }
            else
            {
                return;
            }

        }

        #region EVENT HANDLERS
        private void nextButton_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (index - 1 > -1 && index < question.Count)
            {
                currentQuestionLabel.Text = (index).ToString();

                index--;

                questionBox.Text = question[index].Question1;
                optionABox.Text = question[index].OptionA;
                optionBBox.Text = question[index].OptionB;
                optionCBox.Text = question[index].OptionC;
                optionDBox.Text = question[index].OptionD;

            }
        }
        private int seconds = 60;


        private void quizClockTimer_Tick(object sender, EventArgs e)
        {


            seconds--;
            if (seconds == 0)
            {
                if (minutes > 0)
                {
                    minutes--;
                }

                seconds = 60;
            }

            if (totalSecondsElapsed < 1)
            {
                // MessageBox.Show("In the loop");
                secondsLabel.Text = "00";
                quizClockTimer.Stop();
                calculateResult();
              //  MessageBox.Show("Total Questinos=" + totalQuestions + "\nCorrect Answers=" + correctAnswer + "Incorrect Answers=" + (totalQuestions - correctAnswer));
                finishResultUi();
                sendResultToServer();
                return;

            }
            totalSecondsElapsed = totalSecondsElapsed - 1;
            setProgress();
            initializeTime(minutes, seconds);
        }

        #endregion

        private void saveAndNextButton_Click(object sender, EventArgs e)
        {

            if (radioButtonA.Checked)
            {
                optionSelected = "A";
            }
            else if (radioButtonB.Checked)
            {
                optionSelected = "B";
            }
            else if (radioButtonC.Checked)
            {
                optionSelected = "C";
            }
            else if (radioButtonD.Checked)
            {
                optionSelected = "D";

            }
            else
            {
                MessageBox.Show("Please Select Your Option.");
                return;
            }


            optionlist[index - 1] = optionSelected;
           // MessageBox.Show("Option Selected is=" + index + optionlist[index]);


            nextQuestion();

        }

        private int totalQuestions;
        private int correctAnswer;
        private void calculateResult()
        {
            totalQuestions = question.Count;
        //    MessageBox.Show("Question Size=" + question.Count + "\n Option List Size=" + optionlist.Count);
            for (int i = 0; i < optionlist.Count; i++)
            {
                if (question[i].CorrectAns == optionlist[i])
                {
                    correctAnswer++;
                }

                // MessageBox.Show("Question Answer="+question[i].CorrectAns + "\nOption Answer="+optionlist[i]);
            }
        }

        private void nextQuestion()
        {
            if (index < question.Count)
            {
                currentQuestionLabel.Text = (index + 1).ToString();
                questionBox.Text = question[index].Question1;
                optionABox.Text = question[index].OptionA;
                optionBBox.Text = question[index].OptionB;
                optionCBox.Text = question[index].OptionC;
                optionDBox.Text = question[index].OptionD;
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
                if (index < question.Count - 1)
                {
                    index++;
                }
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Finish Test?", "Finish Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                secondsLabel.Text = "00";
                minuteLabel.Text = "00";
                testProgressBar.Value = 0;
                quizClockTimer.Stop();
                finishResultUi();
                calculateResult();
                sendResultToServer();
            }
            else
            {
                return;
            }

        }

        private void fillOptionList()
        {
            for (int i = 0; i < question.Count; i++)
            {
                optionlist.Add(" ");
            }
        }


        private void finishResultUi()
        {
            saveAndNextButton.Enabled = false;
            previousButton.Enabled = false;
            nextButton.Enabled = false;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonB.Checked = false;
            radioButtonB.Checked = false;
            questionBox.Text = "";
            optionABox.Text = "";
            optionBBox.Text = "";
            optionCBox.Text = "";
            optionDBox.Text = "";
        }
        private void sendResultToServer()
        {
            int incorrectAnswers = totalQuestions - correctAnswer;
            double percentage = (double)(correctAnswer * 100) / totalQuestions;
      //      MessageBox.Show(correctAnswer + " correct- incorrect " + incorrectAnswers);
       //     MessageBox.Show("Percentage is = " + percentage);
            bool IsDataSent = api.insertResultData(studentCnic, correctAnswer, incorrectAnswers, percentage);
            if (IsDataSent)
            {
                MessageBox.Show("Exam Completed Successfully!");
            }
        }
    }



}
