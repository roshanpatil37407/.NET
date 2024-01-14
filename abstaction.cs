using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    abstract class animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("zzzz");
        }
    }
    class cat:animal
    {
        public override  void animalsound()
       
        {
            Console.WriteLine("maww mavw");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            cat obj = new cat();
            obj.animalsound();
            obj.sleep();
        }

    }
   
    
}
