using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Fish:Water
    {
        public abstract bool Scales { get; set; }

        public abstract int EggsPerYear();
    }
}
