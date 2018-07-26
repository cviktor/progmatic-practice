using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Cat : Animal, IHomePet
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

        public void Pet()
        {
            Console.WriteLine("A macska megint kaját kunyerál miközbe simogatom");
        }
    }
}
