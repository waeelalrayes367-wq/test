using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp787
{
    internal class UNV
    {
        string Name;
        string TYPE_UNV;
        Hall[] Halls;
        public void ADD(string name , string TY , int Count_hall)
        {
            Name = name;
            TYPE_UNV = TY;
            Halls = new Hall[Count_hall];
            ADD_Hall();
        }
        public void ADD_Hall()
        {
            for (int i = 0; i < Halls.Length; i++)
            {
                if (Halls[i] == null)
                {
                    Halls[i] = new Hall();
                    Console.Write("Enter Name Hall : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter STU count in Hall : ");
                    int count_st = int.Parse(Console.ReadLine());
                    Halls[i].ADD(name, count_st);
                    Console.WriteLine("Do you  want stop ?");
                    if (Console.ReadLine() == "yes")
                    {
                        break;
                    }
                }       
            }
        }
        public void print()
        {
            Console.WriteLine($"Name student   : {Name}");
            Console.WriteLine($"name Hall : {Name}");
            for (int i = 0; i < Halls.Length; i++)
            {
                if (Halls[i] != null)
                {
                    Console.WriteLine("Hall {i + 1} : ");
                    Halls[i].T1.Print();
                    for (int j = 0; j < Halls[i].all_stu.Length; j++)
                    {
                        if (Halls[i].all_stu[j] != null)
                        {
                            Console.WriteLine("Student {j + 1} : ");
                            Halls[i].all_stu[j].Print();
                        }
                    }
                }
            }
        }
        public void print2()
        {
            Console.WriteLine($"Name UNV   : {Name}");
            Console.WriteLine($"Type UNV : {TYPE_UNV}");
            for (int i = 0; i < Halls.Length; i++)
            {
                if (Halls[i] != null)
                {
                    Console.WriteLine($"Hall {i + 1} : ");
                    Halls[i].T1.Print();
                    for (int j = 0; j < Halls[i].all_stu.Length; j++)
                    {
                        if (Halls[i].all_stu[j] != null)
                        {
                            Console.WriteLine($"Student {j + 1} : ");
                         Halls[i].all_stu[j].Print();
                        }
                    }
                }
            }
        }
    }
}
