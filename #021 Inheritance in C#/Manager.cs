namespace ConsoleApp1
{
    internal partial class program
    {
        public class Manager : Employee
        {
            public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
            {
            }

            private const decimal AllowanceRate = 0.05m;
            protected override decimal Calculate()
            {
                return base.Calculate() + CalculateAllowance();
            }
            private decimal CalculateAllowance()
            {
                return base.Calculate() * AllowanceRate;
            }
            public override string ToString()
            {
                return base.ToString() +
                       $"\nAllowance: ${CalculateAllowance()}" +
                       $"\nNet Salary: ${this.Calculate()}";
            }

        }
    }
}
