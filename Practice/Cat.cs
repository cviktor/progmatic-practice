using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Cat : Animal
    {
        public Cat(int birthYear) : base(birthYear)
        {
        }

        public Cat(int birthYear, string name) : base(birthYear, name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("A macska eszik");
            RaiseHasEaten();

        }
    }
}
