namespace HierrachicalExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(12, 15);
            Square s = new Square(12);
            r.Area();
            s.Area();
        }
    }
}
