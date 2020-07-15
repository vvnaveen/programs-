using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_class
{
    interface interface1
    {
          void dispaly();
    }
    interface interface2
    {
        void todaydate();
    }
    class textint1 : interface1, interface2
    {
        public void dispaly()
        {
            Console.WriteLine("Welcome to traning classes");
        }
        public void todaydate()
        {

            Console.WriteLine("14/07/2020");
         }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            textint1 txt = new textint1();
            txt.dispaly();
            txt.todaydate();
        }
    }
}
