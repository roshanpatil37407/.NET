using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class vehical

    {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("RR", "RR");
        }
    }
    class car : vehical
    {
        public string modelname = "BMW";
    }
    class program
    {
        static void Main(string[] args)
        {
            car obj = new car();
            obj.honk();
            Console.WriteLine(obj.brand + "" + obj.modelname);
        }
    }
}
