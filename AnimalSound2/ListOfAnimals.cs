using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    public static class ListOfAnimals
    {
        public static IEnumerable<IAnimal> GetAnimals()
        {
            return new List<IAnimal> { new Cat(), new Bee(), new Dog() };
        }
    }
}
