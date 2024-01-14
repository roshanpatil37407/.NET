using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
   
    internal class Program
    {
        static int add(int x, int y)
        {
            return x + y;
        }

        static double sum(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int obj = add(6, 9);
            int obj1 =sum(6.5, 9.2);
            Console.writeline("int:" + obj);
            Console.writeline("double:" + obj1);
        }
    }
}
