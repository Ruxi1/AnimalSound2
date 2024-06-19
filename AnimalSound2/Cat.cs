using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    public class Cat : Animal, IAnimal
    {
        public Cat()
        {
            SetType(GetType().Name);
            SetSound("meow");
        }
    }
}
