using System.Diagnostics;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var emps = new Employee[]
            //{
            //    new Employee {Id = 1, Name="Mohamed F",Gender= "M",TotalSales=65000m},
            //    new Employee {Id = 2, Name="Reem S",Gender= "F",TotalSales=50000m},
            //    new Employee {Id = 3, Name="Suzan B",Gender= "F",TotalSales=65000m},
            //    new Employee {Id = 4, Name="Sara A",Gender= "F",TotalSales=40000m},
            //    new Employee {Id = 5, Name="Salah C",Gender= "M",TotalSales=42000m},
            //    new Employee {Id = 6, Name="Rateb A",Gender= "M",TotalSales=30000m},
            //    new Employee {Id = 7, Name="Abeer C",Gender= "F",TotalSales=16000m},
            //    new Employee {Id = 8, Name="Marwan M",Gender= "M",TotalSales=15000m},
            //};

            //var report = new Report();
            //report.ProcessEmplyee(emps, "Empoyees with $60,000+ sales", e => e.TotalSales >= 60000m);
            //report.ProcessEmplyee(emps, "Empoyees between 30000 and 60000 sales", e => e.TotalSales >= 30000m && e.TotalSales < 60000m);
            //report.ProcessEmplyee(emps, "Empoyees less than 30000 sales", e => e.TotalSales < 30000m);

            ////report.ProcessEmployeewith60000PlusSales(emps);
            ////report.ProcessEmployeeBetween30000And59999(emps);
            ////report.ProcessEmployeeLessThan30000(emps);

            /////////////////////////////////////////////////////////////////////////
            
            var helper = new Rectangehelper();
            //helper.GetArea(10,10);
            //helper.GetPerimeter(10,10);
            HelpDelegate rect;
            rect = helper.GetArea;
            rect += helper.GetPerimeter;
            rect(10,10);
            
        }

    }
    public delegate void HelpDelegate(decimal width, decimal height);
    public class Rectangehelper
    {
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width} X {height} = {result}");
        }
        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter: 2 x ({width} + {height}) = {result}");
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal TotalSales { get; set; }
        public string Gender { get; set; } = string.Empty;
    }

    public class Report
    {
        public delegate bool illegibleSales(Employee e);
        public void ProcessEmplyee(Employee[] employees, string title, illegibleSales isIllegible)
        {
            Console.WriteLine($"{title}");
            Console.WriteLine("********************************");

            foreach (var e in employees)
            {
                if (isIllegible(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        //public void ProcessEmployeewith60000PlusSales(Employee[] employees)
        //{
        //    Console.WriteLine("Empoyees with $60,000+ sales");
        //    Console.WriteLine("********************************");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales >= 60000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}

        //public void ProcessEmployeeBetween30000And59999(Employee[] employees)
        //{
        //    Console.WriteLine("Empoyees with $30,000 and 59,999 sales");
        //    Console.WriteLine("********************************");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales >= 30000m && e.TotalSales < 60000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}

        //public void ProcessEmployeeLessThan30000(Employee[] employees)
        //{
        //    Console.WriteLine("Empoyees Less than $30,000 sales");
        //    Console.WriteLine("********************************");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales < 30000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}
    }
}