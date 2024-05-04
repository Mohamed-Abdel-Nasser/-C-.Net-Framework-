namespace ConsoleApp1
{
    internal partial class program
    {
        public class Maintanence : Employee
        {
            private const decimal Hardship = 100m;

            public Maintanence(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
            {
            }
            protected override decimal Calculate()
            {
                return base.Calculate() + Hardship;
            }
            public override string ToString()
            {
                return base.ToString() +
                $"\nHardship: ${Math.Round(Hardship, 2):NO}" +
                $"\nNet Salary: ${Math.Round(this.Calculate(), 2): NO}";
            }
        }
    }
}
