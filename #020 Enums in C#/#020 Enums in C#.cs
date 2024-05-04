using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    internal partial class program // #020 Enums in C#
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Month.APR);      // Output   >>> 4
            Console.ReadKey();


            Console.WriteLine(Month.APR.ToString());  // Output   >>> APR
            Console.ReadKey();


            var day = "FEB";
            if (Enum.TryParse(day, out Month month))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.ReadKey();


            var day = "FEB";
            if (Enum.IsDefined(typeof(Month), day))
            {
                Console.WriteLine(Enum.Parse(typeof(Month), day));
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.ReadKey();

            var day = 2;
            if (Enum.IsDefined(typeof(Month), day))
            {
                Console.WriteLine((Month)day);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.ReadKey();

            foreach (var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)}");
            }
            Console.ReadKey();

            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{month.ToString()} = {(int)month}");
            }
            Console.ReadKey();
        }
    }
}
