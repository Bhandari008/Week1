using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_Ex
{
    public static class Shape
    {
        // Area of Rectangle
        public static int Area(int l,int b)
        {
            return l * b;
        }
        // Method Overloading by chaning number of Parameters
        public static int Area(int l)
        {
            return l * l;
        }
    }
}
