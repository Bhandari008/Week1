namespace Hybrid_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Daughter Object
            Daughter d = new Daughter();
            // Daughter object Calling Father Method
            d.displayF();
            d.displayD();
            // Son Object
            Son s = new Son();
            // Son object calling Father method
            s.displayF();
            s.displayS();
            // Father Object
            Father f = new Father();
            // Father object calling Grandfather method
            f.displayG();
        }
    }
}
