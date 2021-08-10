using System;
using System.Linq;

//  Задача 1:​
//  Напишете метод, който да приема като параметри име и възраст на човек и да ги отпечати на конзолата. ​
//  Извикайте дадения метод няколко пъти с различни данни.​

//  Задача 2: ​
//  Напишете метод, който да приема 2 параметъра : единият е едномерен масив от цели числа, а другият параметър е цяло число.​
//  Нека се провери дали едномерният масив съдържа в някой от елементите си стойността, която е зададена във втория параметър;​
//  Ако масива съдържа числото, нека се върне true като резултат, в противен случай да се върне false.​

//  Задача 3: ​
//  Напишете метод, който приема две числа. ​
//  Нека в метода се проверява дали числата са равни. Да се върне булева променлива с резултата дали числата са равни или не.​​

namespace MethodsUI
{
    class MethodsUI
    {
        static void Main(string[] args)
        {
            GetPerson();

            PrivateContains();

            GetValue(1, 10);

        }

        public static void GetPerson()
        {
            Console.Write("Please Input Your Name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine();

            Console.Write("Please Input Your Age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is {0} and you are {1} years old?", name, age);
        }

        public static void PrivateContains()
        {
            const int numberOfElements = 5;
            int[] myArr = new int[numberOfElements];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < numberOfElements; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out myArr[i]))
                {
                    Console.WriteLine("Entered not a value");
                }

                Console.WriteLine("You entered : " + myArr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Enter Integer value:");
            int value = Int32.Parse(Console.ReadLine());

            bool checkResult = myArr.Contains(value);
            Console.WriteLine();

            Console.WriteLine("Result: " + checkResult);
        }

        public static void GetValue(int a, int b)
        {
            a = 5;
            b = 5;

            bool check = a == b;

            Console.WriteLine(check);
        }

    }
}
