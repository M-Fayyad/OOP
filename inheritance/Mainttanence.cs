namespace inheritance
{
    public class Maintenance : Employee
    {
        private const decimal Hardship = 100m;

        public Maintenance(int id, string name, decimal loggedHours, decimal wage): base(id, name, loggedHours,wage)
        {
        }
        public override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }


        public override string ToString()
        {
            return base.ToString() +
                   $"\n Hardship: ${Math.Round(Hardship, 2)}" +
                   $"\n Net Salary: ${Math.Round(Calculate(), 2)}";
        }
    }
}