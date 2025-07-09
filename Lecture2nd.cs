using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAM_23SOECE11606
{
    internal class Lecture2nd
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int result = a++ + b++ + ++b;
            //5 +5 + 7 
            Console.WriteLine(result);
        }
    }
}
