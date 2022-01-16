using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces05122021
{
    class FiguresPool
    {
        //ПУЛ фигур- класс, который содержит 
        //Агрегатор
       private List<Figure> figures;
        // конструктор
        public FiguresPool()
        {
            figures = new List<Figure>(); // создаем объект списка через new
        }

        // метод добавления фигуры в пул
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

        // переопределение ToString
        public override string ToString()
        {
            string res = "FIGURES POOL:\n";
            foreach (Figure figure in figures)
                res += figure.ToString() + "\n";
            res += "------------------------\n";
            return res;
        }



    }
}
