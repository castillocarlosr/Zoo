using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;


namespace Zoo.Classes
{
    /// <summary>
    /// Abstract Class-> derived from Surface Parent Class.
    /// </summary>
    public abstract class Flying : Surface
    {
        public abstract bool Tail { get; set; }

        public override int Eyes { get; set; }

        public abstract string Flyer();
    }
}
