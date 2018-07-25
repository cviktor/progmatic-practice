using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var cage = new Cage<string>();
            cage.Add("csillámpóni");

            Console.ReadKey();
        }
    }
}
