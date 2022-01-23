using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class Rectangle: Shape

    {
        private double a, b; //стороны прямоугольника
        public double A { get; set; }
        public double B { get; set; }

        //конструктор
        public Rectangle() : base()
        {
            a = b = 0;
        }

        public Rectangle(string name, double a, double b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $", a = {a}, b = {b}";
        }

        //переопределение абстрактного метода
        public override double perimeter()
        {
            return  (a + b) * 2;
        }
        public override double square()
        {
            return a * b;
        }

     }
}
