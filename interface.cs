using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    interface  animal
    {
        void sleep();
        
    }
    class cat : animal
    {
        public  void sleep()

        {
            Console.WriteLine("maww mavw");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            cat obj = new cat();
           
            obj.sleep();
        }

    }


}
