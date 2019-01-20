using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class.  Derived from Animal.  Its a parent class to Flying and Land classes.
    /// </summary>
    public abstract class Surface : Animal
    {
        public virtual bool Arms { get; set; } = true;

        public virtual int Legs { get; set; } = 8;

        public override string Moving()
        {
            return "I like to move it move it";
        }

        public abstract string Speak();

    }
}
