using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces05122021
{
    class Circle:Figure
    {
        // поле радиуса
        public double R { get; set; }

        // констркуторы
        public Circle()
        {
            R = 0;
        }
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        // переопределенные абстрактные методы
        public override double P()
        {
            return 2 * Math.PI * R;
        }
        public override double S()
        {
            return Math.PI * R * R;
        }

        // переопределение ToString
        public override string ToString()
        {
            return $"circle {Name}: r = {R}";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
