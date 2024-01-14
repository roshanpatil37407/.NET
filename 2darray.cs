using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 4, 7 }, { 2, 5, 3 } };
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }


            int[,] b = { { 1, 4, 7 }, { 2, 5, 3 } };
            b[0, 0] = 5;
            Console.WriteLine(b[0, 0]);
        }
    }
}
