using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete Class.  Derived from Animal Class.  Its a parent class to Fish and Mammal class.
    /// </summary>
    public abstract class Water : Animal
    {
        public virtual int Tails { get; set; } = 1;

        public abstract bool Packs { get; set; }

        public override string Moving()
        {
            return "I like to do synchronize swimming";
        }

        public virtual string Noise()
        {
            return ("swooosh 'water noise' ");
        }
    }
}
