using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Country
    {
        public void displayC()
        {
            Console.WriteLine("Country");
        }
    }
    public class State:Country
    {
        public void displayS()
        {
            Console.WriteLine("State");
        }
    }
    public class District:State
    {
        public void displayD()
        {
            Console.WriteLine("District");
        }
    }


    
}
