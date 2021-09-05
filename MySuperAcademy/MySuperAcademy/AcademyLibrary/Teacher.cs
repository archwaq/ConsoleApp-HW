using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class Teacher : Person
    {
        public string SubjectName { get; set; }

        public Teacher()
        {
            counter++;
        }

        public Teacher(string firstName, string surName, string subjectName)
        {
            FirstName = firstName;
            SurName = surName;
            SubjectName = subjectName;
            counter++;
        }

        public override void CheckHomework()
        {
            Console.WriteLine("Teacher is checking homework.");
        }

        public override void SayHello()
        {
            Console.WriteLine("What's poppin folks?");
        }

        public override void SayBye()
        {
            Console.WriteLine("Cya tomorrow.");
        }
    }
}
