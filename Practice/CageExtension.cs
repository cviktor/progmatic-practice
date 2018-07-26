using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    static class CageExtension
    {
        public static void WriteCage<T>(this Cage<T> cage) where T : Animal
        {
            using(var sw = new StreamWriter(@"..\..\..\animals.txt"))
            {
                foreach (var animal in cage.Animals)
                {
                    sw.WriteLine("{0};{1}", animal.Name, animal.BirthYear);
                }
            }
        }
    }
}
