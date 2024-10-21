using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task10
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative.");
            this.radius = radius;
        }

        public override double GetArea()
        {
            double area = radius * radius * Math.PI;
            return area;
        }
    }
}
