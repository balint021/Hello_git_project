using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_git_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Kérem adja meg hány elemet akar bekerni: ");
            int darab = int.Parse(Console.ReadLine());
            for (int i = 0; i < darab; i++)
            {
                Console.WriteLine((i+1) + ". szám: ");
                int a = int.Parse(Console.ReadLine());
                list.Add(a);
            }
            Console.WriteLine("A legnagyobb a " + list.Max());
            Console.ReadLine();
        }
    }
}
