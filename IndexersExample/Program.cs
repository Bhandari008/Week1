namespace IndexersExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Collection col = new Collection();
            col[0] = "John Doe";
            col[9] = "Hari Devkota";
            Console.WriteLine($"{col[0]}\t{col[9]}");
            //col[10] = "Muskan Bhandari"; Error 
        }
    }
}
