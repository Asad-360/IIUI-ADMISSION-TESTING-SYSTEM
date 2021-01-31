using ServerHosting;
using ServerInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerHosting
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerSession)]
    public class ServerService : IServerService
    {

        /// <summary>
        /// Function To get All the Data From the Database And Put It In the List
        /// </summary>
        /// <returns></returns>
        public List<StudentInfo> GetStudentDataList()
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var students = from std in db.StudentInformations select std;
                foreach (StudentInformation info in students)
                {
                    StudentInfo studentInformation = new StudentInfo();
                    studentInformation.Name = info.Name;
                    studentInformation.FatherName = info.FatherName;
                    studentInformation.StudentCnic = info.StudentCnic;
                    studentInformation.Gender = info.Gender;
                    studentInformation.Email = info.Email;
                    studentInformation.Batch = info.Batch;
                    studentInformation.PhoneNo = info.PhoneNo;
                    studentInformation.DateOfBirth = info.DateOfBirth;
                    studentInformation.Address = info.Address;
                    studentInformation.StudentImage = info.StudentImage;

                    studentList.Add(studentInformation);
                }
            }

            return studentList;
        }
        public bool SendStudentInfo(string name, string fatherName, int cnic, int phone, string email, string gender, string batch, DateTime dob, string address, byte[] image , string courseId)
        {
            bool executeState = false;
            try
            {
                StudentInformation model = new StudentInformation();
                model.Name = name;
                model.FatherName = fatherName;
                model.StudentCnic = cnic;
                model.PhoneNo = phone;
                model.Email = email;
                model.Gender = gender;
                model.Batch = batch;
                model.DateOfBirth = dob.Date;
                model.Address = address;
                model.StudentImage = image;
                model.ExamPaperId = courseId;
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    db.StudentInformations.Add(model);
                    db.SaveChanges();
                    executeState = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return executeState;
        }

        /// <summary>
        /// Service Function For Updating the Student Information
        /// </summary>
        /// <param name="std"></param>
        public bool UpdateUsingObject(StudentInfo std)
        {
            bool IsStudentUpdated;
            try
            {
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    var c = (from student in db.StudentInformations
                             where student.StudentCnic == std.StudentCnic
                             select student).First();

                    c.Name = std.Name;
                    c.FatherName = std.FatherName;
                    c.Email = std.Email;
                    c.PhoneNo = std.PhoneNo;
                    c.Gender = std.Gender;
                    c.Batch = std.Batch;
                    c.DateOfBirth = std.DateOfBirth;
                    c.Address = std.Address;
                    db.SaveChanges();
                    Console.WriteLine("Data Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsStudentUpdated = true;
            }
            return IsStudentUpdated;
        }

        /// <summary>
        /// Function To Delete The Student From The Database
        /// </summary>
        /// <param name="Cnic">This is the cnic no upon which whole of the record will be deleted</param>
        /// <returns></returns>
        public bool DeleteStudentInfo(int Cnic)
        {
            bool IsStudentDeleted;
            try
            {
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    // This will bring the record only belong to that cnic number
                    var StudentRecord = (from Student in db.StudentInformations
                                         where Student.StudentCnic == Cnic
                                         select Student).First();
                    // This will remove the object record
                    db.StudentInformations.Remove(StudentRecord);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsStudentDeleted = true;
            }
            return IsStudentDeleted;
        }

        /// <summary>
        /// Function To Register The New Admin
        /// </summary>
        /// <param name="adminInfo">Admin Object Contain Information</param>
        /// <returns></returns>
        public bool AdminRegistration(AdministratorInfo adminInfo)
        {
            bool IsAdminRegistered = false;
            try
            {

                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    Administrator admin = new Administrator();
                    admin.UserName = adminInfo.UserName;
                    admin.Password = adminInfo.Password;
                    admin.Cnic = adminInfo.Cnic;
                    admin.Image = adminInfo.Image;
                    db.Administrators.Add(admin);
                    db.SaveChanges();
                    IsAdminRegistered = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return IsAdminRegistered;
        }

        /// <summary>
        /// Function for the admin
        /// </summary>
        /// <param name="adminInfo"></param>
        /// <returns></returns>
        public bool AdminLogin(AdministratorInfo adminInfo)
        {
            Console.WriteLine("Into the admin login section");
            bool IsAdminRegistered = false;
            try
            {

                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    // Administrator admin = new Administrator();
                    var filteredResult = from s in db.Administrators
                                         select s;


                    foreach (var item in filteredResult)
                    {
                        if (item.UserName == adminInfo.UserName && item.Password == adminInfo.Password)
                        {
                            IsAdminRegistered = true;
                            break;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return IsAdminRegistered;

        }
        /// <summary>
        /// Function to make the student Login
        /// </summary>
        /// <param name="studentInfo"></param>
        /// <returns></returns>
        public bool StudentLogin(StudentInfo studentInfo)
        {
            return true;
            bool IsStudentRegistered = false;
            try
            {

                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    // Administrator admin = new Administrator();
                    var filteredResult = from s in db.StudentInformations
                                         select s;


                    foreach (var item in filteredResult)
                    {
                        if (item.Name == studentInfo.Name && item.StudentCnic == studentInfo.StudentCnic)
                        {
                            IsStudentRegistered = true;
                            break;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return IsStudentRegistered;
        }
        /// <summary>
        /// function to return the student data based on the given cnic no
        /// </summary>
        /// <param name="cnic"></param>
        /// <returns></returns>
        public StudentInfo getStudentInfo(int cnic)
        {
            StudentInfo studentInfo = new StudentInfo();
            try
            {

                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {

                    var studentInformation = (from s in db.StudentInformations
                                              where s.StudentCnic == cnic
                                              select s).FirstOrDefault();
                    studentInfo.StudentCnic = studentInformation.StudentCnic;
                    studentInfo.Name = studentInformation.Name;
                    studentInfo.StudentImage = studentInformation.StudentImage;
                    studentInfo.ExamPaperId = studentInformation.ExamPaperId;
                    Console.WriteLine(studentInformation.StudentImage);
                    Console.WriteLine(studentInformation.Name);
                    Console.WriteLine(studentInformation.StudentCnic);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return studentInfo;


        }

        public bool AddExamPaper(ServerInterfaces.ExamPaper paper)
        {
            bool IsExamPaperAdded = false;
            try
            {
                Console.WriteLine("In to the Add Exam Paper Section");
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {

                    ExamPaper papers = new ExamPaper();
                    papers.Id = paper.Id;
                    papers.Name = paper.Name;
                    papers.TimeDuration = paper.TimeDuration;
                    papers.TotalQuestions = paper.TotalQuestions;
                    papers.MarksPerQuestion = paper.MarksPerQuestion;
                    db.ExamPapers.Add(papers);
                    db.SaveChanges();
                    IsExamPaperAdded = true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                // Console.WriteLine(ex.Message);
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                Console.WriteLine(raise.Message);
                throw raise;
            }
            Console.WriteLine("End Section");
            return IsExamPaperAdded;

        }

        public bool UpdateExamPaper(ServerInterfaces.ExamPaper paper)
        {
            bool IsExamPaperUpdated;
            try
            {
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    var exam = (from examPaper in db.ExamPapers
                                where examPaper.Id == paper.Id
                                select examPaper).FirstOrDefault();

                    exam.MarksPerQuestion = paper.MarksPerQuestion;
                    exam.Name = paper.Name;
                    exam.TotalQuestions = paper.TotalQuestions;
                    exam.TimeDuration = paper.TimeDuration;

                    db.SaveChanges();
                    Console.WriteLine("Data Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsExamPaperUpdated = true;
            }
            return IsExamPaperUpdated;
        }

        public bool DeleteExamPaper(string ExamId)
        {
            bool IsExamDeleted;
            try
            {
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    // This will bring the record only belong to that cnic number
                    var examRecord = (from examPaper in db.ExamPapers
                                      where examPaper.Id == ExamId
                                      select examPaper).FirstOrDefault();
                    // This will remove the object record
                    db.ExamPapers.Remove(examRecord);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsExamDeleted = true;
            }
            return IsExamDeleted;
        }

        public List<ServerInterfaces.ExamPaper> getExamPaperCourse()
        {
            List<ServerInterfaces.ExamPaper> examPaperList = new List<ServerInterfaces.ExamPaper>();
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var examPaper = from papers in db.ExamPapers select papers;
                foreach (ExamPaper paper in examPaper)
                {
                    ServerInterfaces.ExamPaper examPaperObj = new ServerInterfaces.ExamPaper();
                    examPaperObj.Id = paper.Id;
                    examPaperObj.Name = paper.Name;
                    examPaperObj.TotalQuestions = paper.TotalQuestions;
                    examPaperObj.TimeDuration = paper.TimeDuration;
                    examPaperObj.MarksPerQuestion = paper.MarksPerQuestion;


                    examPaperList.Add(examPaperObj);
                }
            }

            return examPaperList;
        }

        /// <summary>
        /// ADD THE EXAMQUESTIONPAPER FROM COURSE MODULE
        /// </summary>
        /// <param name="examQuestions"></param>
        /// <returns></returns>
        public bool AddExamQuestionPaper(List<ExamQuestion> examQuestions)
        {

            bool IsExamQuestionAdded = false;
            try
            {
                Console.WriteLine("In to the Add Question Paper Section");
                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    foreach (var eQ in examQuestions)
                    {
                        Question examQuestion = new Question();
                        List<Question> questionList = new List<Question>();
                        examQuestion.Question1 = eQ.Question1;
                        examQuestion.PaperId = eQ.PaperId;
                        examQuestion.CorrectAns = eQ.CorrectAns;
                        examQuestion.OptionA = eQ.OptionA;
                        examQuestion.OptionB = eQ.OptionB;
                        examQuestion.OptionC = eQ.OptionC;
                        examQuestion.OptionD = eQ.OptionD;
                        db.Questions.Add(examQuestion);
                    }

                    db.SaveChanges();
                    IsExamQuestionAdded = true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                // Console.WriteLine(ex.Message);
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                Console.WriteLine(raise.Message);
                throw raise;
            }
            Console.WriteLine("End Section");
            return IsExamQuestionAdded;

        }
        /// <summary>
        /// CHECK THE TOTAL COURSE QUESTION FROM THE COURSE MODULE
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public int CheckTotalQuestions(string courseId)
        {
            var totalQuestions = 0;
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                totalQuestions = Convert.ToInt32((from paper in db.ExamPapers where paper.Id == courseId select paper.TotalQuestions).FirstOrDefault());
                // int questions = totalQuestions;
            }
            Console.WriteLine("Total Questions is equal to:" + totalQuestions);
            return totalQuestions;
        }

        /// <summary>
        /// Function to get all the courses id from the data base used in paper pool module 
        /// </summary>
        /// <returns></returns>
        public List<ServerInterfaces.ExamPaper> getAllCourses()
        {
            List<ServerInterfaces.ExamPaper> paperList = new List<ServerInterfaces.ExamPaper>();
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var examPaper = from paper in db.ExamPapers select paper;
                foreach (ExamPaper info in examPaper)
                {
                    ServerInterfaces.ExamPaper epaper = new ServerInterfaces.ExamPaper();
                    epaper.Id = info.Id;
                    paperList.Add(epaper);

                }
            }

            return paperList;
        }

        /// <summary>
        /// Function to get the List of All the questions used in paper pool module
        /// </summary>
        /// <returns></returns>
        public List<ServerInterfaces.Question> getAllQuestions(string paperId)
        {
            List<ServerInterfaces.Question> questionList = new List<ServerInterfaces.Question>();
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var ques = (from questions in db.Questions where questions.PaperId == paperId select questions);

                foreach (Question q in ques)
                {
                    ServerInterfaces.Question questions = new ServerInterfaces.Question();
                    questions.Id = q.Id;
                    questions.OptionA = q.OptionA;
                    questions.OptionB = q.OptionB;
                    questions.OptionC = q.OptionC;
                    questions.OptionD = q.OptionD;
                    questions.PaperId = q.PaperId;
                    questions.Question1 = q.Question1;
                    questions.CorrectAns = q.CorrectAns;

                    questionList.Add(questions);
                }
            }

            return questionList;
        }
        /// <summary>
        /// Function to check wether the course is having questions or not
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public bool IsPaperEligible(string courseId)
        {
            bool IsEligible = false;
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var rowCount = (from questions in db.Questions where questions.PaperId == courseId select questions).Count();
                var totalQuestions = (from examPaper in db.ExamPapers where examPaper.Id == courseId select examPaper.TotalQuestions).FirstOrDefault();
                Console.WriteLine("Row=" + rowCount + " " + "TotalQuest=" + totalQuestions);
                var ques = (from questions in db.Questions where questions.PaperId == courseId select questions);
                foreach (var item in ques)
                {
                    if (item.PaperId == courseId && ((int)rowCount != (int)totalQuestions))
                    {

                        IsEligible = true;
                    }
                }


            }
            return IsEligible;
        }

        /// <summary>
        /// Function to get Question that will be used in the quiz module
        /// </summary>
        /// <param name="Cnic">User cnic number</param>
        /// <returns></returns>
        public List<ServerInterfaces.Question> getAllQuestionsForQuiz(long Cnic)
        {
            List<ServerInterfaces.Question> questionList = new List<ServerInterfaces.Question>();
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                var result = from question in db.Questions
                             join student in db.StudentInformations on question.PaperId equals student.ExamPaperId
                             join paper in db.ExamPapers on question.PaperId equals paper.Id
                             where student.StudentCnic==Cnic
                             select question;             

                    foreach (Question q in result)
                {
                    ServerInterfaces.Question questions = new ServerInterfaces.Question();
                    questions.Id = q.Id;
                    questions.OptionA = q.OptionA;
                    questions.OptionB = q.OptionB;
                    questions.OptionC = q.OptionC;
                    questions.OptionD = q.OptionD;
                    questions.PaperId = q.PaperId;
                    questions.Question1 = q.Question1;
                    questions.CorrectAns = q.CorrectAns;

                    questionList.Add(questions);
                }
            }

            return questionList;

        }

        /// <summary>
        /// Function to get TotalTime based on the course Id used in the Quiz moudule
        /// </summary>
        /// <param name="courseId">course id of the student</param>
        /// <returns></returns>
        public int getTotalTime(string courseId)
        {
            var totalTime = 0;
            using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
            {
                totalTime = Convert.ToInt32((from paper in db.ExamPapers where paper.Id == courseId select paper.TimeDuration).FirstOrDefault());
                // int questions = totalQuestions;
            }
            Console.WriteLine("Total Questions is equal to:" + totalTime);
            return totalTime;
        }

        public bool insertResultData(long cnic, int correctAnswer, int incorrectAnswer, double percentage)
        {
            bool IsResultDataInserted = false;
            try
            {

                using (AdmissionTestingSystemEntities db = new AdmissionTestingSystemEntities())
                {
                    Result result = new Result();
                    result.CnicNo = cnic;
                    result.CorrectAnswers = correctAnswer;
                    result.IncorrectAnswers = incorrectAnswer;
                    result.Percentage = percentage;
                    result.StudentInformation = null;
                    db.Results.Add(result);
                    db.SaveChanges();
                    IsResultDataInserted = true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                // Console.WriteLine(ex.Message);
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                Console.WriteLine(raise.Message);
                throw raise;
            }
            return IsResultDataInserted;
        }
    }
    }

