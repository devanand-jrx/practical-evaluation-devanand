using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task10
{
    public class Triangle : Shape
    {
        private double side;
        private double height;
        public Triangle(string name, double side, double height) : base(name)
        {
            if (side < 0 || height < 0)
                throw new ArgumentException("Side and height cannot be negative.");
            this.side = side;
            this.height = height;
        }
        public override double GetArea()
        {
            double area = (side * height) / 2;
            return area;
        }
    }
}
