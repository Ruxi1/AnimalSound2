using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    public class Bee : Animal, IAnimal
    {
        public Bee()
        {
            SetType(GetType().Name);
            SetSound("buzz");
        }
    }
}
