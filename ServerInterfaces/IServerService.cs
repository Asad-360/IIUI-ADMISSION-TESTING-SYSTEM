using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerInterfaces
{
    [ServiceContract]
    public interface IServerService
    {

        #region ADMINITRATOR ACCOUNT SERVICES
        [OperationContract]
        bool SendStudentInfo(string name, string fatherName, int cnic, int phone, string email, string gender, string batch, DateTime date, string address, byte[] image , string courseId);

        [OperationContract]
        List<StudentInfo> GetStudentDataList();

        [OperationContract]
        bool UpdateUsingObject(StudentInfo std);

        [OperationContract]
        bool DeleteStudentInfo(int Cnic);

        [OperationContract]
        bool AdminRegistration(AdministratorInfo adminInfo);

        [OperationContract]
        bool AdminLogin(AdministratorInfo adminInfo);
        #endregion

        #region STUDENT ACCOUNT SERVICES
        [OperationContract]
        bool StudentLogin(StudentInfo studentInfo);

        [OperationContract]
        StudentInfo getStudentInfo(int cnic);
        #endregion

        #region  COURSE SERVICES
        [OperationContract]
        bool AddExamPaper(ExamPaper paper);

        [OperationContract]
        bool UpdateExamPaper(ExamPaper paper);

        [OperationContract]
        bool DeleteExamPaper(string ExamId);
        [OperationContract]
        List<ExamPaper> getExamPaperCourse();
        #endregion

        #region PAPER POOL SERVICES
        [OperationContract]
        bool AddExamQuestionPaper(List<ExamQuestion> examQuestions);

        [OperationContract]
        int CheckTotalQuestions(string courseId);

        [OperationContract]
        bool IsPaperEligible(string courseId);

        

        [OperationContract]
        List<ExamPaper> getAllCourses();
        [OperationContract]
        List<Question> getAllQuestions(string courseId);
        #endregion

        #region QUIZ SYSTEM SERVICES
        [OperationContract]
        List<Question> getAllQuestionsForQuiz(long Cnic);

        [OperationContract]
        int getTotalTime(string courseId);

        [OperationContract]
        bool insertResultData(long cnic, int correctAnswer, int incorrectAnswer, double percentage);

        #endregion


    }


    [DataContract]
    public class StudentInfo
    {
        [DataMember]
        public long StudentCnic { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string FatherName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Batch { get; set; }
        [DataMember]
        public Nullable<long> PhoneNo { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string ExamPaperId { get; set; }
        [DataMember]
        public byte[] StudentImage { get; set; }


    }

    [DataContract]
    public class AdministratorInfo
    {
        [DataMember]
        public int Cnic { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
    }


    [DataContract]

    public class ExamPaper
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Nullable<int> TotalQuestions { get; set; }
        [DataMember]
        public Nullable<int> TimeDuration { get; set; }
        [DataMember]
        public Nullable<int> MarksPerQuestion { get; set; }

    }


    [DataContract]

    public class ExamQuestion
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Question1 { get; set; }
        [DataMember]
        public string OptionA { get; set; }
        [DataMember]
        public string OptionB { get; set; }
        [DataMember]
        public string OptionC { get; set; }
        [DataMember]
        public string OptionD { get; set; }
        [DataMember]
        public string CorrectAns { get; set; }
        [DataMember]
        public string PaperId { get; set; }
        
    }

    [DataContract]

    public class Question
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Question1 { get; set; }
        [DataMember]
        public string OptionA { get; set; }
        [DataMember]
        public string OptionB { get; set; }
        [DataMember]
        public string OptionC { get; set; }
        [DataMember]
        public string OptionD { get; set; }
        [DataMember]
        public string CorrectAns { get; set; }
        [DataMember]
        public string PaperId { get; set; }
    }
}
