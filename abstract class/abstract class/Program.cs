using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{

     abstract class animal
    {
        public abstract void dogsound();
        public abstract void catsoun();

    }

    class animalsound : animal
    {
        public override void dogsound()
        {
            Console.WriteLine("Bow Bow");
        }
        public override void catsoun()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            animalsound sou = new animalsound();
            sou.dogsound();
            sou.catsoun();
        }
    }
}
