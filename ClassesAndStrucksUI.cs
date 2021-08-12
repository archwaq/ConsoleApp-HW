using System;
using System.Collections.Generic;
using Vehicles;
using Humans;
using ConverterTemp;
using PrintingHouse;

//  Задача 1:​
//  Създайте клас мотор, който да има следните характеристики :​
//  -модел ​
//  -цвят​
//  -Година на производство​
//  -Максимална скорост​
//  Създайте няколко инстанции на този клас мотор.​​

//  Задача 2: ​
//  Създайте нов клас, който да описва свойствата и характеристиките на обекта Автомобил.​
//  Кръстете си класа "Car" и го добавете в namespace "Vehicles".​
//  Колата нека има като характеристики следните неща:​
//  - model​
//  - brand​
//  - registrationNumber​
//  - color​
//  - years // на колко години е колата​
//  - seatsNumber​
//  - isDiesel (bool)​​

//  Добавете си и един метод в класа, който да изпринтира на конзолата всичките свойства на колата.​

//  След като сте създали класа, пробвайте да го извикате от Main метода, като си създадете инстанция от този клас и му зададете някакви стойности.​

//  пример : ​
//  Car car1 = new Car();​
//  car.Model = "Peugeout";​
//  car.Brand = "206";​
//  и тн...​

//  Задача 3: ​
//  От лекцията създайте 10 инстанции на класа Person.  За всяка инстанция задайте различни стойности на property-тa. ​
//  Тези 10 инстанции ги запазете в един масив. Накрая обходете масива и принтирайте масива и принтирайте името и егн-то на всеки човек.​

//  Задача 4: ​
//  Създайте структура Flower, в която да имате свойствата Name, Color, Height и метод "Цъфти".​

//  Задача 5: ​
//  Напрате клас, който конвертира градуси от Целзий във Ференхайт.​

//  Задача 6: ​
//  Създайте клас Библиотека, като тя да има локация, големина, година на отваряне.

//  Задача 7: ​
//  Създайте клас Книга, която да има : брой страници, година на печат, автор, заглавие.
//  Също да има методи Print -  който по подадена страница, ще принтира на конзолата, коя страница ще бъде разпечатана.​

namespace ClassesAndStrucksUI
{
    class ClassesAndStrucksUI
    {
        static void Main(string[] args)
        {
            // Call the instance from a class Motorcycle.
            Motorcycle piaggio = new Motorcycle();
            piaggio.Model = "Liberty 50";
            piaggio.Color = "Black";
            piaggio.ManufactureDate = 2019;
            piaggio.TopSpeed = 60;

            Console.WriteLine("Model: " + piaggio.Model);
            Console.WriteLine("Color: " + piaggio.Color);
            Console.WriteLine("Manufacture Date: " + piaggio.ManufactureDate);
            Console.WriteLine("Top Speed: " + piaggio.TopSpeed);


            Console.WriteLine();

            // Call second time the instance from a class Motorcycle.
            Motorcycle sanyang = new Motorcycle();
            sanyang.Model = "SYMNH T 125";
            sanyang.Color = "Green";
            sanyang.ManufactureDate = 2021;
            sanyang.TopSpeed = 90;

            Console.WriteLine("Model: " + sanyang.Model);
            Console.WriteLine("Color: " + sanyang.Color);
            Console.WriteLine("Manufacture Date: " + sanyang.ManufactureDate);
            Console.WriteLine("Top Speed: " + sanyang.TopSpeed);


            Console.WriteLine();

            // Call the constructor from a class Motorcycle that has no parameters.
            var aprilia = new Motorcycle();
            Console.WriteLine("Model: " + aprilia.Model);
            Console.WriteLine("Color: " + aprilia.Color);
            Console.WriteLine("Manufacture Date: " + aprilia.ManufactureDate);
            Console.WriteLine("Top Speed: " + aprilia.TopSpeed);


            Console.WriteLine();

            Car car = new Car();
            car.PrintCar();

            Console.WriteLine();


            Car car1 = new Car();
            car1.Model = "Peugeout";
            car1.Brand = "206";
            car1.ValidateDate(2016);
            car1.Plate = 12234;
            car1.IsDiesel = true;
            car1.Seats = 3;
            car1.Color = "Orange";

            Console.WriteLine("Model: " + car1.Model);
            Console.WriteLine("Brand: " + car1.Brand);            
            Console.WriteLine("Plate: " + car1.Plate);
            Console.WriteLine("Color: " + car1.Color);
            Console.WriteLine("Years Old: " + car1.ValidateDate(2016));
            Console.WriteLine("Number of Seats: " + car1.Seats);
            Console.WriteLine("Diesel: " + car1.IsDiesel);


            Console.WriteLine();

            Person staff1 = new Person("Alex", 19, "admin@mmorpg.com");
            Console.WriteLine("Name : {0} \t\t Age : {1} \t\t Email : {2}", staff1.Name, staff1.Age, staff1.Email);

            Person staff2 = new Person("Spencer", 16, "moderator@mmorpg.com");
            Console.WriteLine("Name : {0} \t\t Age : {1} \t\t Email : {2}", staff2.Name, staff2.Age, staff2.Email);

            Person staff3 = new Person("Tom", 25, "uploader@mmorpg.com");
            Console.WriteLine("Name : {0} \t\t Age : {1} \t\t Email : {2}", staff3.Name, staff3.Age, staff3.Email);

            Console.WriteLine();

            Person user0 = new Person();
            user0.Name = "Bruce";
            user0.Age = 17;
            user0.Email = "superuser@mmorpg.com";
            user0.PersonId = "9903217649";
            //Console.WriteLine(user0.PersonId);

            Person user1 = new Person();
            user1.Name = "Nathan";
            user1.Age = 18;
            user1.Email = "newuser@mmorpg.com";
            user1.PersonId = "0306144723";
            //Console.WriteLine(user1.PersonId);

            Person user2 = new Person();
            user2.Name = "Allen";
            user2.Age = 19;
            user2.Email = "newuser@mmorpg.com";
            user2.PersonId = "0208246996";
            //Console.WriteLine(user2.PersonId);

            Person user3 = new Person();
            user3.Name = "Derrick";
            user3.Age = 20;
            user3.Email = "user@mmorpg.com";
            user3.PersonId = "0111171548";
            //Console.WriteLine(user3.PersonId);

            Person user4 = new Person();
            user4.Name = "Audrey";
            user4.Age = 21;
            user4.Email = "user@mmorpg.com";
            user4.PersonId = "9805301060";
            //Console.WriteLine(user4.PersonId);

            Person user5 = new Person();
            user5.Name = "Gracie";
            user5.Age = 22;
            user5.Email = "superuser@mmorpg.com";
            user5.PersonId = "9604102609";
            //Console.WriteLine(user5.PersonId);

            Person user6 = new Person();
            user6.Name = "Tabitha";
            user6.Age = 23;
            user6.Email = "superuser@mmorpg.com";
            user6.PersonId = "9403071873";
            //Console.WriteLine(user6.PersonId);

            Person user7 = new Person();
            user7.Name = "Eileen";
            user7.Age = 24;
            user7.Email = "user@mmorpg.com";
            user7.PersonId = "9701260940";
            //Console.WriteLine(user7.PersonId);

            Person user8 = new Person();
            user8.Name = "Frank";
            user8.Age = 25;
            user8.Email = "superuser@mmorpg.com";
            user8.PersonId = "9209295419";
            //Console.WriteLine(user8.PersonId);

            Person user9 = new Person();
            user9.Name = "Damon";
            user9.Age = 26;
            user9.Email = "superuser@mmorpg.com";
            user9.PersonId = "9206130074";
            //Console.WriteLine(user9.PersonId);

            List<Person> Crew = new List<Person>();
            Crew.Add(user0);
            Crew.Add(user1);
            Crew.Add(user2);
            Crew.Add(user3);
            Crew.Add(user4);
            Crew.Add(user5);
            Crew.Add(user6);
            Crew.Add(user7);
            Crew.Add(user8);
            Crew.Add(user9);

            Person[] selectPerson = Crew.ToArray();

            foreach (var selected in selectPerson)
            {
                Console.WriteLine("Name : {0} \t\t ID : {1}", selected.Name, selected.PersonId);
            }


            Console.WriteLine();

            Flower flower = new Flower("Wallflower", "Yellow", "3 ft. tall");
            Console.WriteLine("Name : {0} Color : {1} Height : {2}", flower.Name, flower.Color, flower.Height);
            Console.Write("Bloom : ");
            flower.Bloom();

            Console.WriteLine();

            ConverterFahrenheit temp = new ConverterFahrenheit();

            Console.Write("Input Celsius Temperature: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double convertedTemp = temp.GetCelsiusTemp(celsius);

            Console.WriteLine("Output Fahrenheit Temperature: " + convertedTemp);

            Console.WriteLine();


            Books book = new Books();
            book.Pages = 516;
            book.YearsOfPrint = "2021";
            book.Author = "Vijayakumar Velu, Robert Baggs";
            book.Title = "Learn Kali Linux";

            do
            {
                Console.Write("Input Entry Page: ");
                int getEntry = int.Parse(Console.ReadLine());

                Console.WriteLine("Printed Page: " + book.PrintPage(getEntry));
            } while (true);

        }
    }

    public class Motorcycle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int ManufactureDate { get; set; }
        public double TopSpeed { get; set; }

        // Constructor that takes no arguments:
        public Motorcycle()
        {
            Model = "TUONO V4";
            Color = "Red";
            ManufactureDate = 2020;
            TopSpeed = 170;
        }

    }
}

namespace Vehicles
{
    public class Car
    {
        //  - model​
        //  - brand​
        //  - registrationNumber​
        //  - color​
        //  - years // на колко години е колата​
        //  - seatsNumber​
        //  - isDiesel (bool)​​

        public string Model { get; set; }
        public string Brand { get; set; }
        public int Plate { get; set; }
        public string Color { get; set; }
        public int Years { get; set; }
        public byte Seats { get; set; }
        public bool IsDiesel { get; set; }

        public Car()
        {
            Model = "Model S";
            Brand = "Tesla";
            Plate = 55111;
            Color = "Red";
            Years = 2020;
            Seats = 5;
            IsDiesel = false;
        }

        public int ValidateDate(int Years)
        {
            //  Need to be manualy updated for a valid result.
            int actualYear = 2021;

            if (actualYear > Years)
            {
                int result = actualYear - Years;
                return result;
            }

            return Years;
        }
        
        public void PrintCar()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Plate: " + Plate);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Years Old: " + ValidateDate(Years));
            Console.WriteLine("Number of Seats: " + Seats);
            Console.WriteLine("Diesel: " + IsDiesel);
        }
        
    }
}
//  Дефинирайте клас Person, който да има име, години и e-mail. Капсулирайте полетата на класа. ​
//  Име​
//  Години​
//  Еmail​
//  Дефинирайте функция, която извежда в конзолата данните на човека.​
//  Направете 3 обекта от тип Person и демонстрирайте функциите на класа.​
namespace Humans
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PersonId { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public Person()
        {

        }

    }
}
struct Flower
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Height { get; set; }

    public Flower(string Name, string Color, string Height)
    {
        this.Name = Name;
        this.Color = Color;
        this.Height = Height;
    }

    public void Bloom()
    {
        Console.WriteLine("burst of happiness.");
    }
}

namespace ConverterTemp
{
    public class ConverterFahrenheit
    {
        public double GetCelsiusTemp(double userInput)
        {
            double fahrenheit;

            fahrenheit = (userInput * 9) / 5 + 32;
            userInput = fahrenheit;
            return userInput;
        }
    }
}

namespace Buildings
{
    public class Library
    {
        public string Location { get; set; }
        public string Area { get; set; }
        public int YearOfOpening { get; set; }

        public Library()
        {

        }
    }
}

namespace PrintingHouse
{
    public class Books
    {
        public int Pages { get; set; }
        public string YearsOfPrint { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public Books()
        {

        }

        public int PrintPage(int input)
        {
            int check = 0;
            if(input > Pages)
            {
                Console.WriteLine("Not a valid entry.");
            }
            else if(input < check)
            {
                Console.WriteLine("Can't print an empty parameter.");
            }
            else
            {
                return input;
            }

            return check;
        }

    }

}
