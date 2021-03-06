using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class Square: Shape, IDrawable
    {
        private double a; //стороны прямоугольника
        public double A { get; set; }
      
        //конструктор
        public Square() : base()
        {
            a = 0;
        }

        public Square(string name, double a) : base(name)
        {
            this.a = a;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $",со стороной a = {a}";
        }

        //Метод отрисовки в консоли
        public void Draw()
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write("*  ");
                Console.WriteLine();
            }
        }

        //public void Print()
        //{
        //    Console.WriteLine(this);
        //}

        //переопределение абстрактного метода
        public override double perimeter()
        {
            return P = a * 4;
        }
        public override double square()
        {
            return S = a * a;
        }
    }
}
