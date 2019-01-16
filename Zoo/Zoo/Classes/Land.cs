using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Land : Surface
    {
        public abstract bool Tail { get; set; }

        public abstract string Walking();

        public abstract string Drinking();
    }
}
