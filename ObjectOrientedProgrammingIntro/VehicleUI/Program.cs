using System;
//using VehicleLibrary;
using VehicleLibraryExtended;

//  Домашно:​
//  1.Създайте интерфейс за Моторно Превозно средство - той трябва задължително да има свойствата име, година на производство, регистрационен номер и двигател. ​
//  Съшо трябва да има методите :​
//  а) "Drive", на който му се подава скоростта като параметър.​
//  б) "GetYears" - трябва да върне на колко години е колата - това става като от текущата година се извади годината на производството на автомобила. ​

//  Създайте клас Кола, която да имплементира интерфейса. Допълнително да има свойство "Брой гуми" и метод "Старт Турбо". ​
//  Създайте клас Мотор, който да имплементира интерфейса.
//  ​​
//  2. Направете нов проект - интерфейса от задача 1) го заменете с абстрактен клас.​
//  Създайте си класовете Кола и Мотор (пак както са описани горе), но този път да наследяват абстрактния клас.​

//  3.Задачата намираща във файла: „ООП ЗАДАЧА“

namespace VehicleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car oldcar0 = new Car();
            oldcar0.Name = "Ford";
            oldcar0.ManufactureYear = 1992;
            oldcar0.PlateNumber = "1234";
            oldcar0.IsDiesel = true;
            oldcar0.TyresNumber = 4;
            Console.WriteLine($"Model {oldcar0.Name} Year {oldcar0.ManufactureYear} Plate {oldcar0.PlateNumber} Is Diesel? {oldcar0.IsDiesel} Tyres {oldcar0.TyresNumber}");
            oldcar0.StartTurbo();
            oldcar0.Drive(46.4);
            oldcar0.GetYears(1992);

            Scouter scouter = new Scouter();
            scouter.StartTurbo();

        }
    }
}
