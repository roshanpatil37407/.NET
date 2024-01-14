using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class car
    {
        public string model;
        public car(string modelname)
        {
            model = modelname;
        }
        static void Main(string[] args)
        {
            car ford = new car("BMW");
            Console.WriteLine(ford.model);
        }
    }
}
