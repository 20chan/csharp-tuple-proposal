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
            Console.WriteLine("Type of a : {0}", a.GetType());
            Console.WriteLine("First value of a : {0}", a.Item1);

            var b = (1);
            Console.WriteLine("Type of b : {0}", b.GetType());


            //var c = (1,); // Parse Error, Should be =>
            var c = new ValueTuple<int>(1);
            Console.WriteLine("Type of c : {0}", c.GetType());
            Console.WriteLine("First value of c : {0}", c.Item1);
        }
    }
}
