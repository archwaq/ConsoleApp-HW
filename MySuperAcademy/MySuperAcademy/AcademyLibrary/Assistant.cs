using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public class Assistant : Lecturer
    {
        protected bool IsChief = false;

        public Assistant()
        {
            FirstName = "Achille";
            SurName = "Triola";
            IsChief = true;
        }

        public void PrintRecords()
        {
            Console.WriteLine($"First Name {FirstName}, Sur Name {SurName}, isChief {IsChief}");
        }

        public void SmartNotes()
        {
            Console.WriteLine("What is your thoughts today?");
            string printNote = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Looks inspiring.");
            Console.WriteLine(printNote);
        }

        public override void CheckHomework()
        {
            Console.WriteLine("Assistant is checking homework.");
        }

        public virtual void CheckExam()
        {
            bool isCorrectFirstAnswer = givenAnswer.Contains("inheritance");
            Console.WriteLine("Answer 1 contains ('Inheritance'): " + isCorrectFirstAnswer.ToString());

            bool isCorrectSecondAnswer = givenAnswer.Contains("encapsulation");
            Console.WriteLine("Answer 2 contains ('Encapsulation'): " + isCorrectSecondAnswer.ToString());

            bool isCorrectThirdAnswer = givenAnswer.Contains("polymorphism");
            Console.WriteLine("Answer 3 contains ('Polymorphism'): " + isCorrectThirdAnswer.ToString());

            bool isCorrectFourthAnswer = givenAnswer.Contains("abstraction");
            Console.WriteLine("Answer 4 contains ('Abstraction'): " + isCorrectFourthAnswer.ToString());
        }

    }
}
