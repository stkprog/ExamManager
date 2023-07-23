using System.Collections;

namespace ExamManager {
    internal static partial class Program {

        public static string[] columnList = new string[3];
        public static string path = System.Environment.CurrentDirectory + "\\Exams.txt";

        public static ArrayList readFromTextFileOnStartup() {
            using (StreamReader reader = new StreamReader(path)) {
                ArrayList examList = new ArrayList();
                string? line;
                bool firstLineRead = false;

                while ((line = reader.ReadLine()) != null) {
                    string[] lineItems = line.Split(";");
                    if (!firstLineRead) {
                        columnList = lineItems;
                        firstLineRead = true;
                    }
                    else {
                        if (!line.Equals(";;")) {
                            examList.Add(new Exam(lineItems[0], lineItems[1], lineItems[2]));
                        }
                    }
                }
                return examList;
            }
        }

        public static void writeToTextFileOnClose(ArrayList examList) {
            File.WriteAllText(path, "");
            using (StreamWriter writer = new StreamWriter(path)) {
                writer.WriteLine(columnList[0] + ";" + columnList[1] + ";" + columnList[2]);
               
                if (examList.Count > 0) {
                    foreach (Exam e in examList) {
                        writer.WriteLine(e.Date + ";" + e.Subject + ";" + e.Grade);
                    }
                }
            }
        }

        ///  The main entry point for the application
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new myWindow());
        }

    }
}