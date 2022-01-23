using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //создать прямоугольник
            Rectangle rect = new Rectangle("Прямоугольник", 3, 2);
            Console.WriteLine(rect);
            Console.WriteLine();

            //создать квадрат
            Square sqr = new Square("Квадрат", 10);
            Console.WriteLine(sqr);
            Console.WriteLine();

            //создать треугольник

            Triangle trg = new Triangle("Треугольник", 12, 12, 12);
            Console.WriteLine(trg);
            Console.WriteLine();

            CompoundShape shp = new CompoundShape();
            shp.AddShape(new Triangle("Треугольник", 12, 12, 12));
            Console.WriteLine(shp);
            shp.AddShape(new Rectangle("Прямоугольник", 3, 2));
            Console.WriteLine(shp);
            Console.WriteLine(shp.getSquare());
        }
    }
}
