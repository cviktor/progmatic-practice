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
            var cirmi = new Cat(2016, "Cirmi");
            var animals = new List<Animal>
            {
                new Tiger(2010, "Shere Khan"),
                new Dog(2015, "Kevin"),
                cirmi,
            };

            foreach (var animal in animals)
            {
                animal.Observe();
                animal.Eat();
            }

            var pets = new List<IHomePet>
            {
                new Dog(2015, "Bodri"),
                new Cat(2016, "Foltos"),
                new Cat(2016, "Cirmi"),
            };

            foreach (var pet in pets)
            {
                pet.Pet();
            }

            cirmi.HasEaten += Cirmi_HasEaten;
            cirmi.Eat();


            //var cage = new Cage<string>();
            //cage.Add("csillámpóni");

            var cage1 = new Cage<Tiger>();
            cage1.Add(new Tiger(1999, "Igor"));
            cage1.Add(new Tiger(1998, "Bélus"));
            cage1.Add(new Tiger(2000, "Cirmi"));
            var igor = cage1.Find(t => t.Name == "Igor");
            Console.WriteLine("Megvan " + igor.Name);

            var cage2 = new Cage<Dog>();
            cage2.Add(new Dog(1999, "Bodri"));
            cage2.Add(new Dog(2010, "Jani"));
            cage2.Add(new Dog(2016, "Vili"));
            var dog = cage2.Find(d => d.BirthYear == 2016);
            Console.WriteLine("Megvan a kutya aki " + dog.BirthYear + "-ban született");

            cage1.WriteCage();

            Console.ReadKey();
        }

        private static void Cirmi_HasEaten(string name)
        {
            Console.WriteLine(name + " éppen jóllakott");
        }
    }
}
