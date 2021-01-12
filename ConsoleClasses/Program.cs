using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите число z:");
            double z = double.Parse(Console.ReadLine());
            Numbers numbers = new Numbers(x, y, z);
            numbers.SG();
            numbers.Summ();
            numbers.R();

            Console.ReadKey();
        }
    }
}
