using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Numbers
    {
        private double x;
        private double y;
        private double z;
        public Numbers(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        private double g()
        {
            return Math.Sqrt(x * y * z / 2);
        }
        private double s()
        {
            return (x + y + z);
        }
        private double r()
        {
            return (x + y + z) / 2;
        }

        public void SG()
        {
            Console.WriteLine("1 число:" + x + " 2 число:" + y + " 3 число:" + z + " Среднее Геометрическое:" + g());
        }

        public void Summ()
        {
            Console.WriteLine("Сумма 3-х чисел:" + s());
        }
        public void R()
        {
            Console.WriteLine("Разность 3-х чисел: " + r());
        }
    }
}
