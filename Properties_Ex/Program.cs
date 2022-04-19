namespace Properties_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t = new Time();
            t.Hours = 2;
            Console.WriteLine($"Time in Minutes is {t.Minutes}");
            Console.WriteLine($"Time in Seconds is {t.Seconds}");
        }
    }
}
