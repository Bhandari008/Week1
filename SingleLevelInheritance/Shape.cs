using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance
{
    public class Shape
    {
        public decimal length { get; set; }
        public decimal breadth { get; set; }
        public decimal Area()
        {
            return length * breadth;
        }
    }
   
    public class Rectangle:Shape
    {
        public Rectangle(decimal l,decimal b)
        {
            length = l;
            breadth = b;
        }
    }

}
