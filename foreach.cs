using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "RR", "THAR", "FORD" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
