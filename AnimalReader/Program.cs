using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalReader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"..\..\..\animals.txt"))
            {
                Console.WriteLine("A fájl nem létezik");
                return;
            }


            string oldestName = null;
            int oldestYear;
            using (var sr = new StreamReader(@"..\..\..\animals.txt"))
            {
                var line = sr.ReadLine();
                var datas = line.Split(';');
                var year = int.Parse(datas[1]);
                //első sor beolvasásnál be kell állítani fixen
                oldestName = datas[0];
                oldestYear = year;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    datas = line.Split(';');
                    year = int.Parse(datas[1]);

                    if (year < oldestYear)
                    {
                        oldestName = datas[0];
                        oldestYear = year;
                    }
                }
            }

            Console.WriteLine("A legöregebb állat {0} és {1} évben született", oldestName, oldestYear);

            Console.ReadKey();
        }
    }
}
