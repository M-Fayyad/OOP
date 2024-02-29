namespace inheritance
{
    public class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05m;
        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }
        private decimal CalculateAllowance()
        {
            return base.Calculate() * AllowanceRate;
        }
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\n Allowance: ${Math.Round(CalculateAllowance(), 2)}" +
                   $"\n Net Salary: ${Math.Round(Calculate(), 2)}";
        }
    }
}