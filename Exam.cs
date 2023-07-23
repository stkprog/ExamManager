namespace ExamManager {
    internal static partial class Program {
    
        public class Exam {
            public string Date;
            public string Subject;
            public string Grade;

            public Exam(string Date, string Subject, string Grade) {
                this.Date = Date;
                this.Subject = Subject;
                this.Grade = Grade;
            }

        }

    }
    
}