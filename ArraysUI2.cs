using System;
using System.Linq;

// 1.Напишете програма, която намира най-голямото число от дадени 10 произволни числа (може да си ги зададете в масив).​

// 2.Имате даден този стринг : “Lorem ipsum dolor sit amet, consectetur adipiscing elit”; Сложете всяка дума да бъде отделен елемент на масив.

// 3.Качете си домашното в TFS.​

// 4.Качете си предишните домашни в TFS.

namespace ArraysUI2
{
    class ArraysUI2
    {
        static void Main(string[] args)
        {
            int[] rndNumbers = new int[] { 10, 20, 30, 40, 50, 600, 70, 80, 90, 100 };

            int biggest = rndNumbers.Max();

            Console.WriteLine(biggest);

            string myStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

            string[] myArray = new string[myStr.Length];
            myArray = myStr.Split(' ');

            foreach (var word in myArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
