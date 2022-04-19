namespace AbstractClass_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Square s = new Square(12);
            Console.WriteLine($"Area = {s.Area()}");
        }
    }
}
