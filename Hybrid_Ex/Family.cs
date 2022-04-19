using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid_Ex
{
    public class GrandFather
    {
        public void displayG()
        {
            Console.WriteLine("I am GrandFather");
        }
    }
    public class Father:GrandFather
    {
        public void displayF()
        {
            Console.WriteLine("I am Father");
        }
    }
    public class Son:Father
    {
        public void displayS()
        {
            Console.WriteLine("I am son");
        }
    }
    public class Daughter : Father
    {
           public void displayD()
        {
            Console.WriteLine("I am Daughter");
        }
    }
    
}
