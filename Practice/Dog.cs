using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Dog : Animal, IHomePet
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

        public void Pet()
        {
            Console.WriteLine("Simogatom a kutyát");
        }
    }
}
