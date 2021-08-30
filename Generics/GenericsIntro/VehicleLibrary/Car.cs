using System;
using System.Collections.Generic;
using System.Text;

//  2.Напишете си клас Car и му задайте да има следните свойства: Brand, Model, RegisterNumber и SeatsNumber.​
//  Направете си няколко инстанции от коли и ги добавете в списък от Коли. ​
//  Обходете списъка и принтирайте подробна информация за колите.

namespace VehicleLibrary
{
    public class Car
    {
        public Car()
        {

        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegisterNumber { get; set; }
        public byte SeastsNumber { get; set; }
    }
}
