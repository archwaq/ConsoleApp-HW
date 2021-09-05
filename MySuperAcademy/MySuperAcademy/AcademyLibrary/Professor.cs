using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class Professor : Lecturer
    {
        public string Rank = "";


        

        public Professor(string firstName, string surName, string rank)
        {
            FirstName = firstName;
            SurName = surName;
            Rank = rank;
        }

        public void PrintRecords()
        {
            Console.WriteLine($"First Name {FirstName}, Sur Name {SurName}, Rank {Rank}");
        }

        public override void CheckHomework()
        {
            Console.WriteLine("Proffesor is checking homework.");
        }

        public virtual void FinalExam()
        {
            Console.WriteLine("Final Exam:");
            Console.WriteLine("What are the Four main principles in the OOP?");

            Console.WriteLine();

            Console.Write("First principle is? - ");
            string inputFirst = Console.ReadLine();
            givenAnswer.Add(inputFirst.ToLower());
            Console.WriteLine();

            Console.Write("Second principle is? - ");
            string inputSecond = Console.ReadLine();
            givenAnswer.Add(inputSecond.ToLower());
            Console.WriteLine();

            Console.Write("Third principle is? - ");
            string inputThird = Console.ReadLine();
            givenAnswer.Add(inputThird.ToLower());
            Console.WriteLine();

            Console.Write("Fourth principle is? - ");
            string inputFourth = Console.ReadLine();
            givenAnswer.Add(inputFourth.ToLower());
            Console.WriteLine();
            Console.WriteLine("Done. Assistant shall contact you soon.");
        }

    }
}
