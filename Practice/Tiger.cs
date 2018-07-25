using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Tiger : Animal
    {
        public Tiger(int birthYear) : base(birthYear)
        {
        }

        public Tiger(int birthYear, string name) : base(birthYear, name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("A tigris eszik");
            RaiseHasEaten();
        }
    }
}
