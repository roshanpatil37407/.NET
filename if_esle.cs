using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            if (time < 10)
            {
                Console.WriteLine("good morning");
            }
            else if(time < 20)
            {
                Console.WriteLine("good days");
            }
            else 
            {
                Console.WriteLine("good evening");
            }
        }
    }
}
