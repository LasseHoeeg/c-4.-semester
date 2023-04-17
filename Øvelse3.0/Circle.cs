using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._0
{
    internal class Circle : Shape
    {
        private double radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        { 
        this.radius = radius;
        
        }

        public override double area()
        {
            return radius * radius * Math.PI;
        }

        public override string ToString()
        {
            return base.ToString() + ", "+ radius;
        }


    }
}
