using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Dog : Animal
    {
        public Dog(int birthYear) : base(birthYear)
        {
        }

        public Dog(int birthYear, string name) : base(birthYear, name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("A kutya eszik");
            RaiseHasEaten();

        }
    }
}
