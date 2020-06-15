using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() > 0)
                Console.WriteLine(args);

            Case menu = new Case();
            List<Flavor> flavors = menu.Flavors;
            List<Cone> cones = menu.Cones;

            flavors.Sort(new FlavorComparer());

            cones.Sort(new ConeComparer());

            foreach (Flavor flavor in flavors)
                Console.WriteLine(flavor);

            Console.WriteLine();

            foreach(Cone cone in cones)
                Console.WriteLine(cone);
        }
    }
}
