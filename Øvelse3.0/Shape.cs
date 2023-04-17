using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._0
{

    
    internal abstract class Shape
    {
        private double x { get; set; }
        private double y { get; set; } 
        
        public Shape(double x, double y) 
        {
            this.x = x; 
            this.y = y;

        }

        public Shape() : this(1, 1)        
        {
        }
        public abstract double area();

        public virtual string ToString()
        {
            return x + ", " + y;
        }

    }
}
