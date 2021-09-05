using AcademyLibrary;
using System;

namespace AcademyUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Robert", "Wise", "Art");
            teacher.SayHello();
            Console.WriteLine($"First Name {teacher.FirstName}, Sur Name {teacher.SurName}, Subject {teacher.SubjectName}");
            teacher.CheckHomework();
            teacher.SayBye();
            Console.WriteLine();

            Teacher teacher1 = new Teacher();
            teacher1.FirstName = "Bob";
            teacher1.SurName = "Smith";
            teacher1.SubjectName = "Culture";
            Console.WriteLine($"First Name {teacher1.FirstName}, Sur Name {teacher1.SurName}, Subject {teacher1.SubjectName}");
            teacher1.CheckHomework();
            Console.WriteLine();

            Lecturer lecturer = new Lecturer("Abraham", "Hughes", 10, "Western Carolina University");
            lecturer.SayHello();
            Console.WriteLine($"First Name {lecturer.FirstName}, Sur Name {lecturer.SurName}, Years of Service {lecturer.YearsService}, University {lecturer.UniversityName}");
            lecturer.CheckHomework();
            lecturer.CreateExercise("Download Visual Studio");
            lecturer.CreateExercise("Learn Basics", "45:00");
            lecturer.CreateExercise("Get ready for exams", "One Week", "500");
            Console.WriteLine();

            Professor professor = new Professor("Barnaby","Morris", "Adjunct Instructor");
            professor.PrintRecords();
            professor.CheckHomework();
            professor.FinalExam();
            Console.WriteLine();

            Assistant assistant = new Assistant();
            assistant.PrintRecords();
            assistant.CheckHomework();
            assistant.CheckExam();
            assistant.SmartNotes();
            Console.WriteLine();

            SchoolTeacher schoolTeacher = new SchoolTeacher("Kelemen", "Vanessza", "Biology");
            Console.WriteLine($"First Name {schoolTeacher.FirstName}, Sur Name {schoolTeacher.SurName}, Subject {schoolTeacher.SubjectName}");
            schoolTeacher.daySchedule.Add("8A");
            schoolTeacher.daySchedule.Add("8B");
            schoolTeacher.daySchedule.Add("8C");
            schoolTeacher.GetSchedule();
            schoolTeacher.CheckHomework();
            schoolTeacher.EntertainmentProgramm();
            Console.WriteLine();

            CollegeTeacher collegeTeacher = new CollegeTeacher("Nicolaj", "Henningsen", "Biology");
            Console.WriteLine($"First Name {collegeTeacher.FirstName}, Sur Name {collegeTeacher.SurName}, Subject {collegeTeacher.SubjectName}");
            collegeTeacher.CheckHomework();
            Console.WriteLine();

        }
    }
}
