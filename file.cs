using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        private static bool readtext;

        static void Main(string[] args)
        {
            string writetext = "hello i an roshan ";
            File.WriteAllText("filename.txt", writetext);
            Console.WriteLine(readtext);
        }
    }
}
