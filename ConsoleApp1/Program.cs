using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("what is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("hello {0}", yourName);
        }
    }
}