﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Client
    {
        public static void Main()
        {
            Labrador labrador = new Labrador();
            PlasticDog toyDog = new PlasticDog();

            // This Labrador should now act like a toy dog.
            DogAdapter adaptedLabrador = new DogAdapter(labrador);

            Console.Write("Labrador: ");
            labrador.Bark();

            Console.Write("Toy Dog: ");
            toyDog.FakeBark();

            Console.Write("Adapted Labrador: ");
            adaptedLabrador.FakeBark();

            Console.WriteLine("\nPress any key to exit.");
            Console.Read();
        }
    }
}
