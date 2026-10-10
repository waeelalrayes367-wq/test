using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp787
{
    internal class Perosn
    {
        int NN;
        string Name;
        int age;


        static int Count = 1;
        protected void ADD( string name , int age)
        {
            NN  = Count;
            this.Name = name;
            this.age = age;
            Count++;
        }

        protected void Print ()
        {
            Console.WriteLine($"Natrual Number : {NN}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {age}");
        }
        /// رقم وطني 
        /// اسم وعمر 
    }
}
