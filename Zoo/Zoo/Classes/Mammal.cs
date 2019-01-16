using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Mammal : Water
    {
        public abstract bool Tail { get; set; }

        public abstract int GiveBirth();
    }
}
