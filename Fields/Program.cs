namespace Fields
{
     class Program
    {
        static void Main(string[] args)
        {
            // Object Syntax;
            //Initialization
            //<Type> <ObjectName> = new <type>();

            Employee[] emps = new Employee[2];

            Console.Write("Tax : ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee e1= new Employee();

            Console.WriteLine("First employee");

            Console.Write("First Name: ");
            e1.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("Wage : ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hourse: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;
            
            Employee e2= new Employee();

            Console.WriteLine("\nLast employee");

            Console.Write("First Name: ");
            e2.FName = Console.ReadLine();

            Console.Write("second Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("Wage : ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hourse: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[1] = e2;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.PrintSlip());
            }
            
        }
    }
}