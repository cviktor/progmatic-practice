using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Cage<T> where T : Animal
    {
        private List<T> _animals;

        public IEnumerable<T> Animals
        {
            get
            {
                return _animals;
            }
        }

        public Cage()
        {
            _animals = new List<T>();
        }

        public void Add(T animal)
        {
            _animals.Add(animal);
        }

        //Ezt kell befejezni.
        public T Find(Func<Animal, bool> predicate)
        {
            foreach (var animal in _animals)
            {
                if (predicate(animal)) return animal;
            }

            throw new InvalidOperationException("Az állat nem található");
        }
    }
}
