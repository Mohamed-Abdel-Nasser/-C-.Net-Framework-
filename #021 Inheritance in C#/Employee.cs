namespace ConsoleApp1
{
    internal partial class program
    {
        public class Employee
        {
            public const int MinimumLoggedHours = 176;
            public const decimal OverTimeRate = 1.25m;

            public Employee(int id, string name, decimal loggedHours, decimal wage)
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

            public virtual decimal CalculateOverTime()
            {
                var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
                return (additionalHours * Wage * OverTimeRate);
            }

            protected virtual decimal Calculate()
            {
                return CalculateBaseSalary() + CalculateOverTime();
            }

            public override string ToString()
            {
                var type = GetType().ToString().Replace("CAInheritance.", "");
                return $"{type}" +
                       $"\nID {Id}" +
                       $"\nName {Name}" +
                       $"\nLogged Hours {LoggedHours} hrs" +
                       $"\nWage {Wage} $/hr" +
                       $"\nBase Salary: ${Math.Round(CalculateBaseSalary(), 2):NO}" +
                       $"\nOvertime: ${Math.Round(CalculateOverTime(), 2):NO}";
            }

        }
    }
}
