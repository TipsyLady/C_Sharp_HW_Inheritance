using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class Triangle: Shape
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
            return base.ToString() + $", a = {a}, b = {b}, c = {c}";
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
