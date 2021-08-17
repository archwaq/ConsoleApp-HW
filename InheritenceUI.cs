using System;
using System.Collections.Generic;
using System.Linq;

//  1.Създайте клас Книга, която да има : брой страници, година на печат, автор, заглавие.
//  Също да има методи Print -  който по подадена страница, ще принтира на конзолата, коя страница ще бъде разпечатана.
//  (МОЖЕ ДА ИЗПОЛЗВАТЕ ЗАДАЧА 4 ОТ ПРЕДИШНАТА ДОМАШНА)​

//  2.Създайте клас Дневник, който да има : брой страници, година на печат, брой ученици, име на преподавателя.
//  Да има метод „Принтирай годишните оценки“, който по подаден масив от оценки, ще принтира средно аритметичната оценка.​

//  Направете клас Employee, който съдържа базовите характеристики за един работник: часове работа на месец и месечна заплата.​

//  Направете клас Policeman, който наследява Employee и добавя поле за ранга на дадения полицай.​

//  Направете клас Doctor, който наследява Employee и добавя полета за броя нощни и броя целодневни дежурства на месец.​

//  Направете нужните get/set методи, както и методи за извеждане на информацията за обектите в конзолата.​

namespace InheritenceUI
{
    using BookUI;
    using JournalUI;
    using PersonUI;
    internal class InheritenceUI
    {
        static void Main(string[] args)
        {
            var textBook = new TextBook(296, "2018", "Kiril Bankov", "Math");
            Console.WriteLine($"Book {textBook.Title} author {textBook.Author} history of print {textBook.HistoryOfPrint} total pages {textBook.Pages}.");
            textBook.PrintPage();

            Console.WriteLine();

            var schoolJournal = new Journal(500, "2022", 18, "D.Gospodinov");
            Console.WriteLine($"Current Page {schoolJournal.Pages} Year {schoolJournal.SchoolYear} Students {schoolJournal.NumberOfStudents} Teacher {schoolJournal.GrandMasterName}");
            schoolJournal.PerformanceAssessmentProcessor();

            Policeman policeman = new Policeman();
            policeman.Rank = "Leutenant";
            policeman.SumAmount = 12000.000M;
            policeman.WorkAmount = 20;

            Policeman policeman1 = new Policeman();
            policeman1.Rank = "Officer";
            policeman1.SumAmount = 6000.000M;
            policeman1.WorkAmount = 25;

            Doctor doctor = new Doctor();
            doctor.DayShifts = 20;
            doctor.NightShifts = 10;
            doctor.SumAmount = 2000.000M;

            Doctor doctor1 = new Doctor();
            doctor1.DayShifts = 30;
            doctor1.NightShifts = 30;
            doctor1.SumAmount = 3000.000M;

            var policeCollection = new List<Policeman>();

            policeCollection.Add(policeman);
            policeCollection.Add(policeman1);

            Console.WriteLine();

            foreach (var policeEmployee in policeCollection)
            {
                Console.WriteLine("$: " + policeEmployee.SumAmount);
            }
        }
    }    
}

namespace BookUI
{
    public class TextBook 
    {
        public int Pages { get; }
        public string HistoryOfPrint { get;}
        public string Author { get; }
        public string Title { get; }

        public TextBook(int pageCount, string releaseDate, string authorName, string bookTitle)
        {
            this.Pages = pageCount;
            this.HistoryOfPrint = releaseDate;
            this.Author = authorName;
            this.Title = bookTitle;
        }

        public void PrintPage()
        {
            Console.Write("Input Page Number: ");

            int inputPage = int.Parse(Console.ReadLine());

            int pagesLength = Pages;

            if ((inputPage == 0) || (inputPage < 0)) 
            {
                Console.WriteLine("Not a valid entry!");                
            }
            else if (inputPage <= pagesLength)
            {
                Console.WriteLine("Print: " + inputPage);
            }
            else
            {
                Console.WriteLine("Input entry higher than expected.");
            }
        }
    }
}

namespace JournalUI
{
    public class Journal 
    {
        public int Pages { get;}
        public string SchoolYear { get;}
        public int NumberOfStudents { get;}
        public string GrandMasterName { get;}
        public Journal(int selectPage, string schoolYear, int numberOfStudents, string teacherName)
        {
            this.Pages = selectPage;
            this.SchoolYear = schoolYear;
            this.NumberOfStudents = numberOfStudents;
            this.GrandMasterName = teacherName;
        }

        public void PerformanceAssessmentProcessor()
        {
            Console.Write("Enter count of evaluations: ");
            var readCountInput = Console.ReadLine();
            int writeCountInput;
            bool inputSuccess = int.TryParse(readCountInput, out writeCountInput);

            if (inputSuccess)
            {
                int getEvaluationsCount = writeCountInput;

                double[] evaluationsArray = new double[getEvaluationsCount];

                for (int i = 0; i < getEvaluationsCount; i++)
                {
                    Console.Write("Performance appraisal - ");

                    var appraisalAsString = Console.ReadLine();

                    double appraisalValid;

                    while (!double.TryParse(appraisalAsString, out appraisalValid))
                    {
                        Console.WriteLine("Appraisal is not a number!");
                        Console.Write("Performance appraisal - ");
                        appraisalAsString = Console.ReadLine();
                    }


                    evaluationsArray[i] = appraisalValid;

                }

                Console.WriteLine();

                double seasonSummaries = evaluationsArray.Sum();

                double performanceResult = seasonSummaries / getEvaluationsCount;

                Console.WriteLine("Performance assessment level - " + performanceResult);

            }
            else
            {
                Console.WriteLine("Count is not a number!");
            }

        }
    }
}

namespace PersonUI
{
    public class Employee 
    {
        public int WorkAmount { get; set; }

        public decimal SumAmount { get; set; }

    }

    public class Policeman : Employee
    {
        public string Rank { get; set; }

        public Policeman()
        {

        }
    }

    public class Doctor : Employee
    {
        public int NightShifts { get; set; }

        public  int DayShifts { get; set; }

        public Doctor()
        {

        }
    }
}