using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract Class-> derived from Surface Parent Class.
    /// </summary>
    public abstract class Land : Surface
    {
        public abstract bool Tail { get; set; }

        public abstract string Walking();

        public virtual string Drinking()
        {
            return " Living on land always makes me thirsty.  More water please!";
        }
    }
}
