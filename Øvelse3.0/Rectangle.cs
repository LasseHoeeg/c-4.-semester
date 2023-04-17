using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._0
{
    internal class Rectangle : Shape
    {
        private double length { get; set; }
        private double width { get; set; }

        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            this.length = length;
            this.width = width;
        }
        public override double area()
        {
            return length * width;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + length + ", " + width;
        }

    }
}
