using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces05122021
{
    class Rectangle:Figure
    {
        // поля-автосвойства стороны прямоугольника
        public double A { get; set; }
        public double B { get; set; }

        // конструкторы
        public Rectangle()
        {
            A = B = 0;
        }

        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }

        // переопределение абстрактных методов
        public override double P()
        {
            return (A + B) * 2;
        }
        public override double S()
        {
            return A * B;
        }

        // имплементация интерфейса IPrintable
        public void Print()
        {
            Console.WriteLine(this);
        }

        // имплементация интерфейса IDrawable
        public void Draw()
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        // переопределение ToString
        public override string ToString()
        {
            return $"rect {Name}: a = {A}, b = {B}";
        }
    }
}
