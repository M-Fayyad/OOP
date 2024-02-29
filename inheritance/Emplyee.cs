namespace inheritance
{
    public class Employee
    {
        private const int MinimumLoggedHours = 176;

        private const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }


        private decimal CalculateBaseSalary()
        {
            return LoggedHours * Wage;
        }

        private decimal CalculateOverTime()
        {
            var additionalHours = (LoggedHours - MinimumLoggedHours) > 0 ? (LoggedHours - MinimumLoggedHours) : 0;
            return additionalHours * OverTimeRate * Wage;
        }

        // Calculate the initial value of the monthly wage
        public virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }

        public override string ToString()
        {
            var type = GetType().ToString().Replace("inheritance.","");
            return $"{type}"+
                   $"\n Id: {Id}" +
                   $"\n Name: {Name}" +
                   $"\n Logged Hours: {LoggedHours} hrs" +
                   $"\n Wage: {Wage}" +
                   $"\n Base Salary: {Math.Round(CalculateBaseSalary(),2)}" +
                   $"\n Overtime: {Math.Round(CalculateOverTime(), 2)}";
        }
    }
}