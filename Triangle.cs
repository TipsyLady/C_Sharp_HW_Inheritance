using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class Triangle: Shape, IPrintable
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
       
        //конструктор
        public Triangle() : base()
        {
            a = b = c = 0;
        }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $",со сторонами a = {a}, b = {b}, c = {c}";
        }

        //public void Draw()
        //{
        //    double P = (a + b + c) / 2;
        //    double S = Math.Sqrt((P * (P - a) * (P - b) * (P - c)));
        //    double height = ((2 * S / c));

        //    for (int i = 0; i <= height; i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            Console.Write('*');
        //        }
        //        Console.WriteLine();
        //    }

        //}


        //Метод печати в консоли
     
        public void Print()
        {
            Console.WriteLine(this);
        }

        //переопределение абстрактного метода
        public override double perimeter()
        {
           return a + b + c;
        }
        public override double square()
        {
          if (a==b && a==c)
            {
                return Math.Sqrt(3) / 4 * (a * a);
            }
          else if (a==b)
            {
                return (c / 4) * Math.Sqrt(4 * (a * a) - (c * c));
            }
          else
            {
                double per = (a + b + c) / 2;
                return Math.Sqrt(per * (per - a) * (per - b) * (per - c));
            }
        }
    }
}
