namespace MethodOverloading_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Area of rectangle:{Shape.Area(12, 13)}");
            Console.WriteLine($"Area of square :{Shape.Area(12)}");
        }
    }
}
