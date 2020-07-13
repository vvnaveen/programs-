using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0;
            Console.WriteLine("Enter Prime numbers");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();

        }
    }
}
