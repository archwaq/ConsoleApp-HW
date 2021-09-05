using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class CollegeTeacher : Teacher
    {
        protected string WorkPlace = "";        

        public override void CheckHomework() => base.CheckHomework();

        public CollegeTeacher(string firstName, string surName, string subjectName)
        {
            FirstName = firstName;
            SurName = surName;
            SubjectName = subjectName;
        }
    }
}
