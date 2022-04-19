using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Ex
{
    //declare "Shape" class as abstract
    abstract class Shape
    {
        abstract public int Area();
    }
    class Square : Shape
    {
        int length { get; set; }
        public Square(int l)
        {
            length = l;
        }
        //overriding abstract method "Area" of class "Shape" 
        public override int Area()
        {
            return length * length;
        }
    }
}
