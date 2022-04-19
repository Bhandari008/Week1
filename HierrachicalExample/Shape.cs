using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierrachicalExample
{
    public class Shape
    {
        public decimal length { get; set; }
        public decimal breadth { get; set; }

    }
    public class Rectangle:Shape
    {
        public Rectangle(decimal l,decimal b)
        {
            length = l;
            breadth = b;
        }
        public void Area()
        {
            Console.WriteLine($"Area of rectangle:{length * breadth}");
        }
    }
    public class Square:Shape
    {
        public Square(decimal l)
        {
            length = l;
        }
        public void Area()
        {
            Console.WriteLine($"Area of square :{length * length}");
        }
    }
}
