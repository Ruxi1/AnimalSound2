using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (IAnimal animal in ListOfAnimals.GetAnimals())
            {
                animal.MakesSound();
            }

            Console.ReadKey();
        }
    }
}
