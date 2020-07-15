using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Factorial(5);
            Console.WriteLine(result);

        }
    }
}
