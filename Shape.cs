using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    abstract class Shape
    {
        private string name;
        private double p; //периметр
        private double s; //площадь

        public double P { get; set; }
        public double S { get; set; }
        public string Name { get; set; }

        //конструкторы
        public Shape()
        {
            name = "Empty";
            p = s = 0;
        }
        public Shape(string name)
        {
            Name = name;
        }
        public Shape(string name, double p, double s)
        {
            Name = name;
            P = p;
            S = s;
        }

        //методы

        public override string ToString()
        {
            return Name + ": Периметр = " + perimeter().ToString() + ", Площадь = " + square().ToString();
        }

        public abstract double perimeter();
        public abstract double square();
    }
}
    
