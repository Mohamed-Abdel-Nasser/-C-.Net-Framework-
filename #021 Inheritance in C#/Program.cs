using static ConsoleApp1.program;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Manager m = new Manager(1000, "Ali A.", 180, 10);

                Maintanence ms = new Maintanence(1001, "Salim M.", 182, 8);

                Sales s = new Sales(1002, "Sally N.", 176, 9, 0.05m, 10000m);

                Developer d = new Developer(1003, "Issam A.", 186, 15, true);

                Employee[] employees = { m, ms, s, d };

                foreach (var employee in employees)
                {
                    Console.WriteLine("\n----------");
                    Console.WriteLine(employee);
                }
                Console.ReadKey();


                //Manager m = new Manager
                //{
                //    Id = 1000,
                //    Name = "Ali A.",
                //    LoggedHours = 180,
                //    Wage = 10,
                //};
                //Maintanence ms = new Maintanence
                //{
                //    Id = 1001,
                //    Name = "Salim M.",
                //    LoggedHours = 182,
                //    Wage = 8,
                //};

                //Sales s = new Sales
                //{
                //    Id = 1002,
                //    Name = "Sally N.",
                //    LoggedHours = 176,
                //    Wage = 9,
                //    Commission = 0.05m,
                //    SalesVolume = 10000m
                //};

                //Developer d = new Developer
                //{
                //    Id = 1003,
                //    Name = "Issam N.",
                //    LoggedHours = 186,
                //    Wage = 15,
                //    TaskCompleted = true,
                //};

                //Employee[] employees = { m, ms, s, d };
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine("\n------------");
                //    Console.WriteLine(employee);
                //}

                //Console.ReadKey();

            }
        }
    }
