using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp787
{
    internal class Hall
    {
        public tech T1;
        public Stu[] all_stu;
        string Name;

        bool TECH_IS_NOT_ADD = true;
        public void ADD(string Name, int count_stu)
        {
            this.Name = Name;
            all_stu = new Stu[count_stu];
            T1 = new tech();
            Choies_ADD();
        }
        public void Choies_ADD()
        {
            while (true)
            {
                if (TECH_IS_NOT_ADD)
                {
                    Console.WriteLine("1- add Stu \n2-Add tech");
                }
               else
                {
                    Console.WriteLine("1- add Stu \n2-EDIT tech");
                }
                switch (Console.ReadLine())
                {
                    case "1":
                        ADD_STU();
                        break;
                    case "2":
                        ADD_TECH();
                        break;
                    case "3":
                            return;
                }
            }
        }
         void ADD_STU()
        {
            for (int i = 0; i < all_stu.Length; i++)
            {
                if (all_stu[i] == null)
                {
                    all_stu[i] = new Stu();
                    Console.Write("Name :");
                    string Name = Console.ReadLine();
                    Console.Write("Age : ");
                    int Age = int.Parse(Console.ReadLine());
                    Console.Write("ID Stu : ");
                    int ID_s = int.Parse(Console.ReadLine());
                    Console.Write("year : ");
                    int year = int.Parse(Console.ReadLine());
                    all_stu[i].ADD(Name, Age, ID_s, year);
                    Console.WriteLine("Do you  want stop ?");
                    if (Console.ReadLine() == "yes")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("MAX hall");
                    break;
                }
            }
        }
         void ADD_TECH()
        {
            Console.Write("Name :");
            string Name = Console.ReadLine();
            Console.Write("Age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("ID tech : ");
            int ID_T = int.Parse(Console.ReadLine());
            Console.Write("SP : ");
            string SP = Console.ReadLine();
            T1.ADD(Name, Age, ID_T, SP);
            TECH_IS_NOT_ADD = false;
        }
        public void Print()
        {
            Console.WriteLine($"count stu : {all_stu.Length}");
            Console.WriteLine($"Name Hall : {Name}");
            T1.Print();
            for (int i = 0; i < all_stu.Length; i++)
            {
                if (all_stu[i] != null)
                {
                    all_stu[i].Print();
                }
            }
        }
    }
}

