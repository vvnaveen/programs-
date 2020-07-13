using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageof3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int add;
            float avg;
            Console.WriteLine("Enter x,y and z numbers");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            z = Convert.ToInt16(Console.ReadLine());
            add = x + y + z;
            avg = (float)add / 3;
            Console.WriteLine($"The average of {x} , {y} and {z} is {avg}");
        }
    }
}
