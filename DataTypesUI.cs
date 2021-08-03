using System;
using System.Collections.Generic;
// 1) Напишете по една променлива от всеки тип и й задайте стойност. Като коментар до нея напишете дали е стойностен или референтен тип.
// Пример: 
// int a = 5; // value type
// long b = 5L; //value type
// и тн...

// 2) Направете следните задачи, свързани с обработка на стрингове

// Имате дефинирана променлива от тип string и тя е инициализирана с дадена стойност: 

// string myStr = "Hello World";

// Използвайки информацията от тази променлива направете следните задачи:

// 2.1. Задайте думата "Hello" на една променлива от тип стринг и думата "World" на друга променлива от тип стринг 
// КАТО думите не ги пишете ръчно, а използвате правилната стринг операция, с която може да извлечете тази информация от дадения ви стринг по-горе.;
// 2.2. Отпечатайте дали дължината на стринга е равна на 10 символа.
// 2.3. Отпечатайте индекса (поредната стойност в низа) на буквата "W" в дадения стринг.
// 2.4. Отпечатайте стринга с главни букви
// 2.5 .Отпечатайте стринга
// 2.6. Заменете думата "World" с думата "Programming“

// 3) Декларирайте променливи с най-подходящия за тях тип и им задайте стойност, които да описват : 
// - име на човек
// - години 
// - пол - дали е мъж или жена
// - сума в банковата сметка 
// - първата буква от името на човека
// - цвят на очите

// 4) Декларирайте и инициализирайте най-подходящите променливи за следните числа: 
// -180
// 5
// 9834289023490
// 7.7
// 9.802349004
// 1999
// 123456789123456789


namespace DataTypesUI
{
    class DataTypesUI
    {
        static void Main(string[] args)
        {         
            /*
            sbyte a = -127; //value type
            byte b = 220; //value type
            short c = -32500; //value type
            ushort d = 32500; //value type
            int e = 2000000000; //value type
            uint f = 4000000000U; //value type
            long g = 9000000000000000000L; //value type
            ulong h = 11000000000000000000L; //value type
            float i = 1.123456F; //value type
            double j = 1.12345678D; //value type
            decimal k = 123456789123456789123456789M; //value type
            bool l = true; //value type
            char m = '*'; //reference type        
            List<int> inQueue = new List<int>(); //value type
            string o = "hello"; //reference type
            */

            //              012345678910
            string myStr = "Hello World";

            string firstWord = myStr.Substring(0,5);
            Console.WriteLine(firstWord);

            string secondWord = myStr.Substring(6);
            Console.WriteLine(secondWord);

            int strLength = myStr.Length;
            Console.WriteLine(strLength);

            int charW = myStr.IndexOf('W');
            Console.WriteLine(charW);

            string toUpper = myStr.ToUpper();
            Console.WriteLine(toUpper);

            Console.WriteLine(myStr);

            myStr = myStr.Replace("World", "Programming");
            Console.WriteLine(myStr);

            //Console.WriteLine(myStr.Contains("World"));

            string personName = "Morgan";
            byte personAge = 37;
            bool isMale = true;
            decimal personBankAmount = 134789123.456788M;           
            char firstCharOfName = 'M';
            string eyeColor = "Gray";

            Console.WriteLine(personName);
            Console.WriteLine(personAge);
            Console.WriteLine(isMale);
            Console.WriteLine($"{personBankAmount:C}");
            Console.WriteLine(firstCharOfName);
            Console.WriteLine(eyeColor);

            //short a = -180;
            //sbyte b = 5;
            //long c = 983489023490L;
            //float d = 7.7F;
            //double e = 9.802349004D;
            //ushort f = 1999;
            //ulong g = 123456789123456789L;
        }
    }
}
