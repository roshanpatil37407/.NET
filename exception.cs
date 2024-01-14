using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong");
            }
            finally
            {
                Console.WriteLine("the try catch is finished");
            }
        
        }
    }
}
