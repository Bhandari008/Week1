namespace PartialClassExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.id = 1; // From Partial Class 1
            e.name = "John Doe"; // From Partial Class 1
            e.dor = DateTime.Today; // From Partial Class 2
            e.salary = 50000;  // From Partial Class 2
            Console.WriteLine($"Employee id:{e.id}\n Name:{e.name}\n DOR:{e.dor}\n Salary:{e.salary}");
        }
    }
}
