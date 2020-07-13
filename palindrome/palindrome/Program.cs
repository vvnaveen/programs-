using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, number1 = 0, rem = 0, rev = 0;

            Console.Write("Enter Number ");
            number1 = number = Convert.ToInt16(Console.ReadLine());

            while (number > 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;

            }
            if (rev == number1)
                Console.WriteLine("Given Number is Palindrome");
            else
               
                Console.WriteLine("Given Number is not a Palindrome");
        }
    }
}
