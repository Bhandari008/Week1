using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeywordExample
{
    public class Shape
    {
        public virtual void  Area(int l,int b)
        {
            Console.WriteLine($"Area of Rectangle:{l * b}");
        }
    }
    public class Parallelogram:Shape
    {
        public override void Area(int l,int b)
        {
            Console.WriteLine($"Area of Parallelogram:{(l * b)/2}");
        }
    }
}
