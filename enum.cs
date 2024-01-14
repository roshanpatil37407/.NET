using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        enum level
        {
            low,
            high,
            medium
        }

        static void Main(string[] args)
        {
            level obj = level.medium;
            Console.WriteLine(obj);
        }
    }
    
}
