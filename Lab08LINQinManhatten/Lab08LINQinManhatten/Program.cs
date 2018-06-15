using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab08LINQinManhatten.Classes;

namespace Lab08LINQinManhatten
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manhatten manhatten = CreateManhatten();
            OutputAllNeighborhoods(manhatten);
            Console.WriteLine("Press any button to query all the previoius queries in one");
            Console.ReadLine();
            OutputAllNeighborhoodsWithUniqueNames(manhatten);
        }

        public static Manhatten CreateManhatten ()
        {
            string path = "../../../data.json";
            string json = File.ReadAllText(path);
            Manhatten manhatten = Newtonsoft.Json.JsonConvert.DeserializeObject<Manhatten>(json);


            return manhatten;
        }

        public static void OutputAllNeighborhoods(Manhatten manhatten)
        {
            var results = from n in manhatten.Features
                          where n.Properties.Neighborhood != null
                          select n.Properties.Neighborhood;
            Console.WriteLine("Printing off every neighborhood in Manhatten");
            foreach(var neighborhood in results)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("Press any key to see all neighborhoods with a name");
            Console.ReadLine();

            var noEmptyNames = results.Where(n => n != "");
            Console.WriteLine("Printing off every neighborhood with a name in Manhatten");
            foreach (var neighborhood in noEmptyNames)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("Press any key to see all unique neighborhoods");
            Console.ReadLine();

            var uniqueNeighborhoods = noEmptyNames.Distinct();
            Console.WriteLine("Printing off every neighborhood with a unique name in Manhatten");
            foreach (var neighborhood in uniqueNeighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public static void OutputAllNeighborhoodsWithUniqueNames(Manhatten manhatten)
        {
            var results = manhatten.Features.Where(n => n.Properties.Neighborhood != null)
                                            .Where(n => n.Properties.Neighborhood != "")
                                            .GroupBy(g => g.Properties.Neighborhood)
                                            .Select(m => m.First());
                                            ;

            Console.WriteLine("Printing off every neighborhood with a unique name in Manhatten");
            foreach (var neighborhood in results)
            {
                Console.WriteLine(neighborhood.Properties.Neighborhood);
            }
        }
    }
}
