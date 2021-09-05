using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class SchoolTeacher : Teacher
    {
        public List<string> daySchedule = new List<string>(5);

        public SchoolTeacher(string firstName, string surName, string subjectName)
        {
            FirstName = firstName;
            SurName = surName;
            SubjectName = subjectName;
        }

        public void GetSchedule()
        {
            DateTime date = new DateTime(2022, 11, 17);
            foreach (var getClass in daySchedule)
            {
                Console.WriteLine($"Schedule for {date.ToLongDateString()} - Class {getClass}");
            }
        }

        public override void CheckHomework() => base.CheckHomework();

        public void EntertainmentProgramm()
        {
            Console.WriteLine("Entertainment Programm.");
        }
    }
}
