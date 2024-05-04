using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class program
    {
        static void Main(string[] args)
        {
            DigitalSize size = new DigitalSize(60000);
            size = size.AddBit(8);

            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.MB);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.TB);



            Console.ReadKey();

        }
    }
}
