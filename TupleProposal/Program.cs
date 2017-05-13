using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleProposal
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (1, 2);
            Console.WriteLine(a.GetType());

            var b = (1);
            Console.WriteLine(b.GetType());

            //var c = (1,); // Parse Error
        }
    }
}
