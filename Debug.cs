using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4C1030Debug
{
    /*
        This Program asks you to enter your name and 
        say "Hello."

    */

    class Program
    {
        static void Main(string[] args)
        {
            //get the person's name
            Console.Write("Enter your name:");
            var yourName = Console.ReadLine();

            // say "Hello"
            Console.WriteLine("Hello " + yourName);

            // pause 
            Console.ReadLine();

            var a = 8;
            var b = 0;
            var c = 0;

            a = a + 10;
            b = b + a;

            c = b - 10;

            //debug.assert(b != 0, "b cant' be zero!");
            //var result = a / b;
        }
    }
}
