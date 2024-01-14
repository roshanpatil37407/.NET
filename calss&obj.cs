using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp16
{
    internal class car
    {
        string color = "red";
        static void Main(string[] args)
        {
            car obj = new car();
            car obj1 = new car();
            Console.WriteLine(obj.color);
            Console.WriteLine(obj1.color);

        }
    }
}
