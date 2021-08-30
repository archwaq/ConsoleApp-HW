using System;
using System.Collections.Generic;
using VehicleLibrary;

//  Задача
//  Напишете програма, която приема 10 числа. Четните ги сложете в стек (stack), а нечетните в опашка (queue).
//  Изпринтирайте числата от стека и опашката като ги изваждате от тях.​​
//
//  Задачи за домашно:​
//  1 Направете програма, която : ​
//  -Да пълни числата от 1 до 100 в списък.  ​
//  След това обходете списъка и изтриите всички числа, които завършват на 0 (10, 20, 30 и т.н.).​
//  ​
//  2.Напишете си клас Car и му задайте да има следните свойства: Brand, Model, RegisterNumber и SeatsNumber.​
//  Направете си няколко инстанции от коли и ги добавете в списък от Коли. ​
//  Обходете списъка и принтирайте подробна информация за колите.​​
//
//  3. Напишете си клас Bike и му задайте да има следните свойства: Brand, Model и Color.​
//  Създайте някоклко инстанции пак от класа Bike и ги добавете в свързания списък LinkedList.​
//  Обходете го и принтирайте подробна информация за колите.​
//
//  4. Напишете програма , която да пълни в някаква структура числата от 1 до 50.​
//  След това като използвате струткурата отпечатете числата в обратен ред. Коя структура бихте избрали в случая.​
//
//  Ако се сетите за няколко варианта за решение ги напишете всичките.​​
//
//  5. Създайте си структурата опашка и я напълнете с числата от 1 до 10.​
//  След това обходете опашката и изтрийте елементите, докато текущия елемент не стане равен на числото 5.
//  Когато стане 5 принтирайте, че това е което търсите и спрете обхождането.​
//
//  6. Напишете програма, която обръща думите в едно изречение на обратно. Използвайте стек. ​
//  Пример: I am from planet Earth ​
//  Решение: Earth planet from am I ​
//
//  7. Напишете програма, която маха определени думи (по-къси от 3 символа) от изречение Използвайте опашка. ​
//  Пример: My spaceship is ready for travelling to Mars ​
//  Решение: spaceship ready travelling Mars​​​

namespace GenericsUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //DemonstrateStackAndQueue();

            List<int> listOfNumbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                listOfNumbers.Add(i);
            }

            for (int i = 0; i <= listOfNumbers.Count; i++)
            {
                if (i % 10 == 0)
                {
                    listOfNumbers.Remove(i);
                    listOfNumbers.Remove(100);
                }
            }

            Console.WriteLine();

            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            List<Car> listOfCars = new List<Car>();
            listOfCars.Add(new Car { Brand = "Chevrolet", Model = "Camaro", RegisterNumber = "1234", SeastsNumber = 4 });
            listOfCars.Add(new Car { Brand = "Volvo", Model = "S90 Recharge", RegisterNumber = "0550", SeastsNumber = 4 });
            listOfCars.Add(new Car { Brand = "Tesla", Model = "Model 3", RegisterNumber = "9876", SeastsNumber = 4 });
            listOfCars.Add(new Car { Brand = "Bugatti", Model = "Chiron", RegisterNumber = "0660", SeastsNumber = 2 });
            listOfCars.Add(new Car { Brand = "Rolls-Royce", Model = "Ghost", RegisterNumber = "5665", SeastsNumber = 4 });

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{ car.Brand } { car.Model } { car.RegisterNumber } { car.SeastsNumber }");
            }

            Console.WriteLine();

            LinkedList<Bike> listOfBikes = new LinkedList<Bike>();
            listOfBikes.AddFirst(new Bike { Brand = "Specialized", Model = "Turbo Creo SL", Color = "Magenta" });
            listOfBikes.AddLast(new Bike { Brand = "Blix", Model = "Sol Cruiser Bike", Color = "Sky blue" });

            foreach (var bike in listOfBikes)
            {
                Console.WriteLine($"{ bike.Brand } { bike.Model } { bike.Color }");
            }

        }

        private static void DemonstrateStackAndQueue()
        {
            Stack<int> evenValues = new Stack<int>();

            Queue<int> oddValues = new Queue<int>();

            int[] valueArray = new int[10];

            Console.WriteLine("Input 10 integer values");
            for (int i = 0; i < valueArray.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out valueArray[i]))
                {
                    Console.WriteLine("Not an integer");
                }

                Console.WriteLine("Value: " + valueArray[i]);
            }

            Console.WriteLine();

            foreach (var value in valueArray)
            {
                if (value % 2 == 0)
                {
                    evenValues.Push(value);
                }
                else
                {
                    oddValues.Enqueue(value);
                }
            }

            Console.WriteLine("Numbers that goes into Stack");
            foreach (var item in evenValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNumbers that goes into Queue");
            foreach (var item in oddValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Try Peek on top of the Stack: " + evenValues.TryPeek(out int isPopulatedStack));

            //Important keep this line always commented - Extract the commented lines down below only if the Try peek on top of the Stack return True.
            //Console.WriteLine("Peeked on top: " + evenValues.Peek());
            //Console.WriteLine("Removed: " + evenValues.Pop());
            //Console.WriteLine("Count left: " + evenValues.Count);

            Console.WriteLine();
            Console.WriteLine("Try Peek on top of the Queue: " + oddValues.TryPeek(out int isPopulatedQueue));
            //Important keep this line always commented - Extract the commented lines down below only if the Try peek on top of the Queue return True.
            //Console.WriteLine("Dequeue : " + oddValues.Dequeue());
            //Console.WriteLine("Count left: " + oddValues.Count);
            //Console.WriteLine("Dequeue : " + oddValues.Dequeue());
            //Console.WriteLine("Dequeue : " + oddValues.Dequeue());
        }
    }
}
