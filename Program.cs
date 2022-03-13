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
           // создать прямоугольник
            Rectangle rect = new Rectangle("Прямоугольник", 7, 10);
            Console.WriteLine(rect);
            Console.WriteLine();
            rect.Draw();

            //создать квадрат
            Square sqr = new Square("Квадрат", 5);
            Console.WriteLine(sqr);
            Console.WriteLine();
            sqr.Draw();

            //создать треугольник

            Triangle trg = new Triangle("Треугольник", 4, 4, 4);
            Console.WriteLine(trg);
            Console.WriteLine();
            trg.Print();

            //Сцена фигур
            CompoundShape shp = new CompoundShape();
            shp.AddShape(new Triangle("Треугольник", 12, 12, 12));
            Console.WriteLine(shp);
            shp.AddShape(new Rectangle("Прямоугольник", 5, 8));
            shp.AddShape(new Square("Квадрат", 4));
            Console.WriteLine(shp);
            Console.WriteLine(shp.getSquare());
            shp.Print();
            Console.WriteLine();
            shp.Draw();
            
        }
    }
}
