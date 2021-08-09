using System;

//1.Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.​

//2. Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7. Числото N да се чете от стандартния вход.​

//3. Напишете програма, която намира най-голямото число от дадени 3 произволни числа ​

//4. Намерете сумата на ЧЕТНИТЕ числа в диапазона от 1 до 100 включително​

//5. Напишете програма, която да принтира имената на месеците от годината. ​

//   Потребителят въвежда число и ако то отговаря на месец от годината, се показва името на месеца.​

//   Пример : Въвеждам числото 3 през конзолата и тя ми принтира месеца, отговарящ на числото - в случая "Март месец
namespace LoopsUI2
{
    class LoopsUI2
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.Write("Input value of N: ");
            int usserInput = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= usserInput);

            Console.WriteLine();

            int num2 = 1;
            Console.Write("Input value of N: ");
            int usserInput2 = Convert.ToInt32(Console.ReadLine());

            while (num2 <= usserInput2)
            {
                if((num2 % 3 !=0) && (num2 % 7 != 0))
                {
                    Console.WriteLine(num2);                   
                }
                num2++;
            }

            Console.WriteLine();

            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine("The numbers are a = {0}, b = {1}, c = {2}", a, b, c);

            if ((a > b) && (a > c))
            {
                Console.WriteLine("a = {0} is the biggest number", a);
            }
            else if (b > c)
            {
                Console.WriteLine("b = {0} is the biggest number", b);
            }
            else
            {
                Console.WriteLine("c = {0} is the biggest number", c);
            }

            Console.WriteLine();

            int start = 1;
            int end = 100;
            int sumOfEvens = 0;

            while (start <= end)
            {
                if (start % 2 == 0)
                {
                    sumOfEvens = sumOfEvens + start;                    
                }
                start++;
            }
            Console.WriteLine(sumOfEvens);

            Console.WriteLine();

            Console.WriteLine("Give me an integer between 1 and 12, and I will give you the month");
            int monthInteger = int.Parse(Console.ReadLine());

            switch (monthInteger)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Please input a valid number");
                    break;
            }

        }
    }
}
