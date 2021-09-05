using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class Lecturer : Person
    {
        public static List<string> givenAnswer = new List<string>(4);

        public const int MaxLecturesPerWeek = 10;
        public string UniversityName { get; set; }

        public override void CheckHomework()
        {
            Console.WriteLine("Lecturer is checking homework.");
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello colleagues.");
        }

        public Lecturer()
        {
            counter++;
        }

        public Lecturer(string firstName, string surName, int yearsService, string universityName)
        {
            if (yearsService < 0)
            {
                Console.WriteLine("Years of Service can't store negative value.");
            }


            else
            {
                FirstName = firstName;
                SurName = surName;
                YearsService = yearsService;
                UniversityName = universityName;
            }
            counter++;
        }

        public void CreateExercise(string purpose)
        {
            Console.Write("Please describe the purpose and press enter - ");

            string purposeDescriptionInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Description: {purposeDescriptionInput}");
            Console.WriteLine();
        }

        public void CreateExercise(string purpose, string time)
        {
            Console.Write("Please describe the purpose and press enter - ");

            string purposeDescriptionInput = Console.ReadLine();

            Console.Write("Please input time and press enter - ");

            string timeDescriptionInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Description: {purposeDescriptionInput} \t Time: {timeDescriptionInput}");
            Console.WriteLine();
        }

        public void CreateExercise(string purpose, string time, string groupSize)
        {
            Console.Write("Please describe the purpose and press enter - ");

            string purposeDescriptionInput = Console.ReadLine();

            Console.Write("Please input time and press enter - ");

            string timeDescriptionInput = Console.ReadLine();

            Console.Write("Please input count of group and press enter - ");

            string countMembersInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Description: {purposeDescriptionInput} \t Time: {timeDescriptionInput} \t Members: {countMembersInput}");
        }
    }
}
