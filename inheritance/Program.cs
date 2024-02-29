namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new(1000, "Mohamed A", 180, 10);

            Maintenance ms = new(1001, "Ahmed A", 182, 8);

            Sales s = new(1002, "Mona l", 176, 9, 0.05m, 10000m);

            Developer d = new(1003, "Fayyad A", 186, 15, true);

            Employee[] employees = { m, ms, s, d };

            foreach (var employee in employees)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(employee);
            }
            
        }
    }
}