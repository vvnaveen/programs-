using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange_of_var
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt16(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping : ");
            Console.Write($"First Number :{num1} \nSecond Number :{num2}\n");
        }
    }
}
