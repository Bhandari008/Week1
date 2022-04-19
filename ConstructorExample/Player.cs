using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    public class Player
    {
        public int pid;
        public string pname;
        public static int rating;
        
        // Default Constructor
        public Player()
        {
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized Constructor
        public Player(int id,string name)
        {
            pid = id;
            pname = name;
        }

        // Copy Constructor
        public Player(Player p)
        {
            pid = p.pid;
            pname = p.pname;
        }

        //Static Constructor
        static Player()
        {
            rating = 95;
        }
        //Display Function
        public void display()
        {
            Console.WriteLine($"Player Rating is {rating}");
        }

    }
}
