using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task10
{
    public class Rectangle : Shape
    {
        private double side1;
        private double side2;

        public Rectangle(string name, double side1, double side2) : base(name)
        {
            if (side1 < 0 || side2 < 0)
                throw new ArgumentException("Sides cannot be negative.");
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double GetArea()
        {
            double area = side1 * side2;
            return area;
        }
    }
}
