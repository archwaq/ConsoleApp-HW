using System;
// 1. Да се създаде масив , който да съдържа 5 различни имена на хора.
//    Обходете масива с цикъл и принтирайте името на всеки човек.
// 2. Да се създаде масив , който да съдържа 5 различни имена на хора. 
//    След това декларирайте втори масив, който да е празен в началото. 
//    Обходете първия масив по такъв начин, че да принтира имената отзад напред и задайте тези имена във втория масив.
// 3. Деклрарирайте масив с 20 елемента и го напълнете с числата от 1 до 20. 
//    След това на 10тия елемент му сменете стойността с 0.
// 4. Декларирайте един масив и го напълнете само с ЧЕТНИТЕ числа от 1 до 100.
// 5. Да се напише програма, която чете два едномерни масива с по 10 произволни елемента 
//    от един и същи тип и проверява дали двата масива имат данни, които са еднакви. Еднаквите данни (ако има такива) да се изпринтират през конзолата.
// 6. Намерете максималното и минималното число от матрица с произволни стойности 
//  	а) по редове
//  	б) по колони
//  	в) за цялата матрица
// 7. Напишете програма, която попълва квадратна матрица: първо вертикално, след това хоризонтално. 
// Потребителя въвежда размерност на матрицата.
// пример:  
// 1	5 	9	13

namespace ArraysUI
{
    class ArraysUI
    {
        static void Main(string[] args)
        {
            string[] arrayNames = new string[5] 
            {
                "Monstarella",
                "Faux",
                "Varquynne",
                "Pilla",
                "Moradin"
            };

            foreach (string name in arrayNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            int forward = 0;

            string[] firstArray = new string[5] 
            {
                "Monstarella",
                "Faux",
                "Varquynne",
                "Pilla",
                "Moradin"
            };

            foreach (string name in firstArray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            string[] secondArray = new string[5];

            foreach (string name in secondArray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            string[] reversedArray = new string[firstArray.Length];

            for (int i = reversedArray.Length - 1; i >= 0; i--)
            {
                secondArray[forward++] = firstArray[i];
            }

            foreach(string name in secondArray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            int[] numbersArray = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if(i == 10)
                {
                    numbersArray[i] = 0;                   
                }

                Console.WriteLine("Element[{0}] = {1}", i, numbersArray[i]);
            }

            Console.WriteLine();

            const int count = 101;

            int[] arr = new int[count];

            for(int i = 1; i < arr.Length; i++)
            {      
                arr[i] = arr[i] + i;

                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }

            Console.WriteLine();

            string[] shipContainer1 = new string[] {"bulbs","chairs","10","@","staplers","Garden Tools","Bikes","Phones","social bots","baby seats"};

            string[] shipContainer2 = new string[] {"flash drives","books","mosaic","toys","Organic tea","sweets","Bikes","Phones","doorbells","@"};

            for(int i = 0; i < shipContainer1.Length; i++)
            {
                for(int n = 0; n < shipContainer2.Length; n++)
                {
                    if(shipContainer1[i] == shipContainer2[n])
                    {
                        Console.WriteLine(shipContainer1[i]);
                    }
                }
            }

            Console.WriteLine();

            const int rows = 4, columns = 4;
            int minValue, maxValue;

            int[,] myArray = new int[rows,columns] 
            {
                //       0  1  2  3
                /*0*/   {1, 2, 3, 4},
                /*1*/   {5, 6, 7, 8},
                /*2*/   {9, 10, 11, 12},
                /*3*/   {13, 14, 15, 16}
            };

            minValue = myArray[0,0];
            maxValue = myArray[0,0];

            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                
                for(int n = 0; n < columns; n++)
                {
                    Console.Write(myArray[i,n] + "\t");
                }
            }
            Console.WriteLine();

            for(int i = 0; i < rows; i++)
            {
                for(int n = 0; n < columns; n++)
                {
                    if(myArray[i,n] > maxValue)
                    {
                        maxValue = myArray[i,n];
                    }

                    if(myArray[i,n] < minValue)
                    {
                        minValue = myArray[i,n];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Maximum element: " + maxValue);
            Console.WriteLine("Minimum  element: " + minValue);
            Console.WriteLine();


            Random rnd = new Random();

            Console.Write("Input matrix size: ");
            int rowsValue = Convert.ToInt32(Console.ReadLine());
            int columnsValue = rowsValue;

            int[,] matrix = new int[rowsValue,columnsValue];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int n = 0; n < matrix.GetLength(1); n++)
                {
                    matrix[i,n] = rnd.Next(1,169);
                }
            }

            for(int i = 0; i < rowsValue; i++)
            {
                Console.WriteLine();
                
                for(int n = 0; n < columnsValue; n++)
                {
                    Console.Write(matrix[i,n] + "\t");
                }
            }
            Console.WriteLine();
           
        }
    }
}
