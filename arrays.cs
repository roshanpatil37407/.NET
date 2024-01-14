using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "RR", "THAR", "FORD" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] num = { 4, 8, 2, 91, 9, 1, 0 };
            Array.Sort(num);
            foreach (int  i in num)
            {
                Console.WriteLine(i);
            }


            int[] no = { 4, 8, 2, 91, 9, 1, 0 };
            Console.WriteLine(no.Max());
            Console.WriteLine(no.Min());
            Console.WriteLine(no.Sum());


        }
    }
}
