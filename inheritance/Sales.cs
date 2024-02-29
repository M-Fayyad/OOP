namespace inheritance
{
    public class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            SalesVolume = salesVolume;
            Commission = commission;
        }

        private decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\n Commission: ${Math.Round(Commission, 2)}" +
                   $"\n Bonus: ${Math.Round(CalculateBonus(), 2)}" +
                   $"\n Net Salary: ${Math.Round(Calculate(), 2)}";
        }
    }
}