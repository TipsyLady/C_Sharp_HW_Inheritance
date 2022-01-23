﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Inheritance
{
    class CompoundShape
    {
        List<Shape> shapes;

        //конструктор
        public CompoundShape()
        {
            shapes = new List<Shape>();
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public double getSquare()
        {
            Console.WriteLine("Площадь всех фигур равна:");
            double sum = 0;
            foreach (Shape shape in shapes)
                sum += shape.square();
            return sum; 
        }

        public override string ToString()
        {
            string res = "Составная фигура: \n";
            foreach (Shape shape in shapes)
                res += shape.ToString() + "\n";
            return res;
        }
    }
}
