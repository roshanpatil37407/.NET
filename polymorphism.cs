using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class animal
    {
        public void animalsound()
        {
            Console.WriteLine("the animals make sounds");
        }
    }
    class dog:animal 
    {
        public void animalsound()
        {
            Console.WriteLine("bow bow");
        }
    }
    class cat :animal
    {
        public void animalsound()
        {
            Console.WriteLine("maww maww");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            animal obj = new animal();
            animal obj1 = new dog();
            animal obj2= new cat();

            obj.animalsound();
            obj1.animalsound();
            obj2.animalsound();

        }
    }
}
