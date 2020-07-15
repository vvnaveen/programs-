using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arthmtic_using_inheritance
{

    class calculator
    {
        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    class calculator1:calculator
    {
        public void mul(int a,int b)
        {
            Console.WriteLine(a * b);
        }
        public void mod(int a,int b)
        {
            Console.WriteLine(a % b);
        }

    }
    class calculator2 : calculator1
    {
        public void div(int a,int b)
        {
            Console.WriteLine(a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculator2 cal = new calculator2();
            cal.sum(10, 20);
            cal.sub(60, 20);
            cal.mul(12, 6);
            cal.mod(20, 10);
            cal.div(50, 10);

       
        }
    }
}
