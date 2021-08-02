using System;
// За домашно
// Потърсете в MSDN:
// Намерете документацията на Console класа в MSDN
// Разгледайте свойствата и методите на класа
// Кой/и методи може да използваме за писане ? 
// Създайте си няколко нови  конзолни проекти под един solution
// Намерете документацията на DateTime класа в MSDN и отпечатайте на екрана текущата дата.
// Отпечатайте на конзолата следната информация, като стойностите ги въведете през конзолата: 
// Име 
// Години
// Пол
// Цвят на очите

namespace DocumentationIntro
{
    class DocumentationIntro
    {
        static void Main(string[] args)
        {
        
        // System.Console Represents the standard input, output, and error streams for console applications.This class cannot be inherited.
        
        
            Console.Write("Hello ");
            Console.WriteLine("World!");

            DateTime localtime = DateTime.Now;
            Console.WriteLine(localtime);

            Console.Write("Name: ");
            string outputName = Console.ReadLine();
            Console.Write("Years: ");
            string years = Console.ReadLine();
            byte outputYears = byte.Parse(years);
            Console.Write("Gender: ");
            string outputGender = Console.ReadLine();
            Console.Write("Eye Color: ");
            string outputEyeColor = Console.ReadLine();

            Console.WriteLine($"Name:{outputName}  Years:{outputYears}  Gender:{outputGender}  Eye Color:{outputEyeColor}");

        }
    }
}
