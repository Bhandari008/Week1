namespace ConstructorExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Default Constructor
            Player p1 = new Player();
            // Parameterized Constructor
            Player p2 = new Player(1,"Salah");
            // Copy Constructor
            Player p3 = new Player(p2);
            Console.WriteLine($"Parameterized Constructor\n\t{p2.pid} {p2.pname}");
            Console.WriteLine($"Copy Constructor\n\t{p3.pid} {p3.pname}");
            //showing static Constructor
            p3.display();

        }
    }
}
