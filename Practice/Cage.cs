using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Cage<T>
    {
        private List<T> _animals;

        public Cage()
        {
            _animals = new List<T>();
        }

        public void Add(T animal)
        {
            _animals.Add(animal);
        }

        //Ezt kell befejezni.
        //public T Find()
        //{

        //}
    }
}
