using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task10
{
    public abstract class Shape
    {
        protected Shape(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public virtual string GetName()
        {
            return "Shape: " + Name;
        }
        public abstract double GetArea();
    }
}

