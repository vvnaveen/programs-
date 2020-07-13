using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int add, sub, multi, divint, modulus;
            float div_float;
            Console.WriteLine("Enter x and y numbers");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            add = x + y;
            Console.WriteLine($"The sum of {x} and {y} is {add}");

            sub = x - y;
            Console.WriteLine($"The sub of {x} and {y} is {sub}");

            multi = x * y;
            Console.WriteLine($"The multi of {x} and {y} is {multi}");

            divint = x / y;
            Console.WriteLine($"The div of {x} and {y} is {divint}");

            div_float = (float)x / y;
            Console.WriteLine($"The div of {x} and {y} is {div_float}");

            modulus = x % y;
            Console.WriteLine($"The rem of {x} and {y} is {modulus}");
        }
    }
}
