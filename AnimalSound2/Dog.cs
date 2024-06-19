using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    public class Dog : Animal, IAnimal
    {
        public Dog()
        {
            SetType(GetType().Name);
            SetSound("ham");
        }
    }
}
