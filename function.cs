using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void method(string name, int age)
        {
            Console.WriteLine(name + "is" + age);
        }
        static void Main(string[] args)
        {

            method("ram",17);
            method("sham",50);
            method("rita",20);
        }
    }
}
