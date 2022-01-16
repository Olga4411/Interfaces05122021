using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces05122021
{
   abstract class Figure
    {
        // поле имя фигуры
        public string Name { get; set; } // реализовали автосвойство

        // конструкторы
        public Figure() { Name = "undefined"; }
        public Figure(string name) { Name = name; }

        // абстрактные методы
        public abstract double P();
        public abstract double S();
    }
}
