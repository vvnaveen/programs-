using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_classes
{
    sealed class addition {
    
    public void add(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
    }

   // class substration:addition { 

   //}

    class Program
    {
        static void Main(string[] args)
        {
            addition added = new addition();
            added.add(10, 20);
        }
    }
}
