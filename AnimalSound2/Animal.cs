using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound2
{
    public abstract class Animal : IAnimal
    {
        protected string Type;
        protected string Sound;

        protected void SetType(string type)
        {
            Type = type;
        }

        protected void SetSound(string sound)
        {
            this.Sound = sound;
        }

        public void MakesSound()
        {
            Console.WriteLine("{0} makes sound: {1}", this.Type, this.Sound);
        }
    }
}
