using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Calculator
    {
        public int Sum(int a ,int b)
        {
            return a + b;
        }

        public int  Factorial(int a)
        {
            int fact = 1;
            for(int i = 1;i <= a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }

}
