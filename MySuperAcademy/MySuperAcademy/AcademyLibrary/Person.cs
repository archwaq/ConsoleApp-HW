using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary
{
    public abstract class Person
    {
        public static int counter = 0;
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int YearsService { get; set; }

        public abstract void CheckHomework();

        public virtual void SayHello()
        {
            Console.WriteLine("Testing Person base SayHello() method.");
        }

        public virtual void SayBye()
        {
            Console.WriteLine("Testing Person base SayBye() method.");
        }
    }
}
