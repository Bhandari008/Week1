using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassEx
{
    public class Animal
    {
        public string color = "black";
    }
    public class Dog : Animal
    {
        public string color = "white";
        public void displayColor()
        {
            Console.WriteLine($"Base Class Attribute: {base.color}");
            Console.WriteLine($"Child Class Attribute: {color}");
        }
    }
}

