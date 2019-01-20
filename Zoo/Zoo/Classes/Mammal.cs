using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract Class-> derived from Water Parent Class.
    /// </summary>
    public abstract class Mammal : Water
    {
        public abstract bool Tail { get; set; }

        public abstract int GiveBirth();
    }
}
