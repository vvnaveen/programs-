using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{

    class naveen
    {
        public virtual void squ(int a)
        {
            Console.WriteLine(a * a * a);
        }
    }
    class venkatnaveen : naveen
    {
        public override void squ(int a)
        
        {
            Console.WriteLine(a * a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            naveen vv = new naveen();
            vv.squ(6);
            venkatnaveen val = new venkatnaveen();
            val.squ(6);
                 
        }
    }
}
