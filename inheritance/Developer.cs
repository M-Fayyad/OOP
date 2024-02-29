namespace inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.3m;
        protected bool TaskCompleted { get; set; }

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            TaskCompleted = taskCompleted;
        }
        private decimal CalculateBonus()
        {
            if (TaskCompleted)
            {
                return base.Calculate() * Commission;
            }
            return 0;
        }
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\n Task Completed: ${(TaskCompleted ? "Yes" : "No")}" +
                   $"\n Bonus: ${Math.Round(CalculateBonus(), 2)}" +
                   $"\n Net Salary: ${Math.Round(Calculate(), 2)}";
        }
    }
}