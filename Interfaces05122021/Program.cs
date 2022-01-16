using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces05122021
{
    class Program
    {
        static void Main(string[] args)
        {
            // STAGE 1
            // 1) базовый класс фигура с абстрактными методами
            // получения площади и периметра
            // 2) сделать наследников, которые переопределяют данные методы

            // STAGE 2
            // 1) класс-агрегатор фигур - пул фигур
            // 2) реализовать методы получения общей площади, периметра, имен

            // STAGE 3
            // 1) IPrintable - для печати фигуры на консоли
            // 2) IDrawable - для отрисовки фигуры на консоли

            Figure figure = new Rectangle("ABCD", 5, 6);
            Console.WriteLine(figure);
            Console.WriteLine(figure.P());
           
            figure = new Circle("OA", 3.14);
            Console.WriteLine(figure);
            Console.WriteLine(figure.P());

            Console.ReadLine();
        }
    }
}
