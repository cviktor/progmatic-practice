using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void AnimalEatenEventHandler(string name);

    abstract class Animal
    {
        public event AnimalEatenEventHandler HasEaten;

        public string Name { get; set; }

        private int _birthYear;

        public int BirthYear
        {
            get { return _birthYear; }
            set
            {
                if (value < 1800)
                {
                    throw new InvalidBirthYearException(value);
                }
                _birthYear = value;
            }
        }


        public Animal(int birthYear)
        {
            BirthYear = birthYear;
        }

        public Animal(int birthYear, string name) : this(birthYear)
        {
            Name = name;
        }

        public void Observe()
        {
            Console.WriteLine("{0} állat {1}-ben született", Name, BirthYear);
        }

        public abstract void Eat();

        protected void RaiseHasEaten()
        {
            if (HasEaten != null)
            {
                HasEaten(Name);
            }
        }

    }
}
