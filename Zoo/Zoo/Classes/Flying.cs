using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Flying : Surface
    {
        public abstract bool Tail { get; set; }

        public override int Eyes { get; set; }

        public abstract string Flyer();
    }
}
