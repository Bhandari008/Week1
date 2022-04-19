using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex
{
    // Interface 1 "Animal"
    public interface Animal
    {
        public void displayA() { }
    }
    // Interface 2 "Domestic"
    public interface Domestic
    {
        public void displayD() { }
    }

    // class "Dog" from interface1 and interface2
    public class Dog:Animal,Domestic
    {
        public void displayA()
        {
            Console.WriteLine("Animal Interface Method");
        }
        public void displayD()
        {
            Console.WriteLine("Domestic Interface Method");
        }
    }
}
