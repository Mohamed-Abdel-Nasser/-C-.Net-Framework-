using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class program   // #012 OOP - Indexers in C#
    {
        static void Main(string[] args)
        {


            //var ip = new IP(1111, 2222, 3333, 4444);
            //Console.WriteLine($"IP Address Is :{ip.Address}");

            //var ipAddress = new IP("1111.2222.3333.4444");
            //var firstSegment = ipAddress[0];
            //Console.WriteLine($"First Segment Of ipAddress Is :{firstSegment}");

            //Console.ReadKey();





            int[,] inputs = new int[,] {
                {8, 3, 5, 4, 1, 6, 9, 2, 7},
                {2, 9, 6, 8, 5, 7, 4, 3, 1},
                {4, 1, 7, 2, 9, 3, 6, 5, 8},
                {5, 6, 9, 1, 3, 4, 7, 8, 2},
                {1, 2, 3, 6, 7, 8, 5, 4, 9},
                {7, 4, 8, 5, 2, 9, 1, 6, 3},
                {6, 5, 2, 7, 8, 1, 3, 9, 4},
                {9, 8, 1, 3, 4, 5, 2, 7, 6},
                {3, 7, 4, 9, 6, 2, 8, 1, 5} };
                var suduko = new suduko(inputs);
                Console.WriteLine(suduko[5, 5]); // 9 Console.ReadKey();

            

        }
    }
}
