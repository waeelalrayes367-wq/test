using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp787
{
    internal class Stu : Perosn
    {
        int ID_s;
        int year;
        public void ADD( string name, int age , int ID_s , int year)
        {
            base.ADD( name, age);
            this.ID_s = ID_s;
            this.year = year;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"ID Studnt : {ID_s}");
            Console.WriteLine($"year : {year}");
        }
        /// رقم الطالب 
        /// السنة الدراسية
    }
    class tech : Perosn
    {
        int ID_t;
        string Sp;
        public void ADD( string name, int age, int ID_t, string Sp)
        {
            base.ADD( name, age);
            this.ID_t = ID_t;
            this.Sp = Sp;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"ID tech : {ID_t}");
            Console.WriteLine($"Sp : {Sp}");
        }
        /// رقم الأستاذ 
        /// الأختصاص
    }
}
