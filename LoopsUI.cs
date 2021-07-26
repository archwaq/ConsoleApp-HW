using System;
// 1. Напишете програма, която да проверява дали въведното число от потребителя е четно или нечетно. 
//    Ако числото е 0-ла съобщението трябва да бъде,че числото 0-ла не е нито четно, нито нечетно.
// 2. Напишете програма, която показва знака (+ или -) от частното на две реални числа, без да го пресмята.
// 3. Напишете програма, която намира по-голямото от две дадени числа.
// 4. Напишете програма, която намира най-голямото от три дадени числа.
// 5. Напишете програма, която взема дадена цифра (0-9) и я изписва с дума (на англ. език)

// 6. Напишете програма, която приема три цели числа. Изведете на конзолата дали може да бъде бъде образуван триъгълник с дължини на страните  от въведените три числа.

// 7. Напишете програма, която изчислява бонус точки на база резултат от игра. 
// Потребителят трябва да въведе своите точни в интервалa[1;9]. 
// Ако точките са в интервала [1;3], умножете ги по 5. Ако точките са в интервала [4;6], умножете ги по 10. 
// Ако точките са в интервала [7;9], умножете ги по 50. Резултатът изведете на екрана.
namespace LoopsUI
{
    class LoopsUI
    {
        static void Main(string[] args)
        {
            ValueValidation(GetValue());

            //PrintSign();

            //PrintBiggest(10,10,12);

            //NumberConvertor();

            //IsValid(10,10,10);

            //LeaderboardConsole();
            
        }

        public static int GetValue()
        {
            int number;
            Console.Write("Input a integer value: ");
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        private static int ValueValidation(int value)
        {
            if(value == 0)
            {
                Console.WriteLine("The number 0 is not even either odd.");
            }

            else if (value % 2 == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd.");
            }

            return value;
        }

        private static void PrintSign()
        {
            double value1 = -15.45D;
            double value2 = 3.00D;

            char positiveSign = '+';
            char negativeSign = '-';

            bool quotient = (value1 / value2) > 0;

            char? x = quotient ? positiveSign : negativeSign;
            Console.WriteLine(x);
        }

        public static void PrintBiggest(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine($"{a} is the bigger.");
            }

            else if (b > a)
            {
                Console.WriteLine($"{b} is the bigger.");
            }

            else 
            {
                Console.WriteLine($"Number {a} = {b}.");
            }
        }

        public static void PrintBiggest(int a, int b, int c)
        {
            int bigger;

            bigger = (a > b && a > c) ? a: (b > a && b > c) ? b : c;
            Console.WriteLine("{0} is the bigger.", bigger);
        }

        private static void NumberConvertor()
        {
            Console.WriteLine("Press any 0 - 9 key...");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                Console.WriteLine("One");
                break;
                case 2:
                Console.WriteLine("Two");
                break;
                case 3:
                Console.WriteLine("Three");
                break;
                case 4:
                Console.WriteLine("Four");
                break;
                case 5:
                Console.WriteLine("Five");
                break;
                case 6:
                Console.WriteLine("Six");
                break;
                case 7:
                Console.WriteLine("Seven");
                break;
                case 8:
                Console.WriteLine("Eight");
                break;
                case 9:
                Console.WriteLine("Nine");
                break;
                default:
                Console.WriteLine("Zero");
                break;
            }
        } 

        public static int IsValid(int a, int b, int c)
        {
            if( (a + b >= c) && (b + c >= a) && (a + c >= b))
            {
                Console.WriteLine("True");
            }

            else if ((a < 0) || (b < 0) || (c < 0))
            {
                Console.WriteLine("False");
                Console.WriteLine("Negative entry.");
            }

            else 
            {
                Console.WriteLine("False");
                Console.WriteLine("Empty entry.");
            }
           
           return 0;
        }

        private static void LeaderboardConsole()
        {
            Random points = new Random();
            int pointsAmount = points.Next(1,9);

            const int bronzeLeague = 5;
            const int silverLeague = 10;
            const int goldLeague = 50;

            switch (pointsAmount)
            {
                case 1:
                Console.WriteLine($"Score: " + pointsAmount * bronzeLeague);
                break;
                case 2:
                Console.WriteLine($"Score: " + pointsAmount * bronzeLeague);
                break;
                case 3:
                Console.WriteLine($"Score: " + pointsAmount * bronzeLeague);
                break;
                case 4:
                Console.WriteLine($"Score: " + pointsAmount * silverLeague);
                break;
                case 5:
                Console.WriteLine($"Score: " + pointsAmount * silverLeague);
                break;
                case 6:
                Console.WriteLine($"Score: " + pointsAmount * silverLeague);
                break;
                case 7:
                Console.WriteLine($"Score: " + pointsAmount * goldLeague);
                break;
                case 8:
                Console.WriteLine($"Score: " + pointsAmount * goldLeague);
                break;
                case 9:
                Console.WriteLine($"Score: " + pointsAmount * goldLeague);
                break;
                default:
                Console.WriteLine("Good luck! :D");
                break;
            } 
        }
    }
}
