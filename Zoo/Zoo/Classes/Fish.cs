using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

/// <summary>
/// Abstract class.  Parent class is Water.  It's derived classes are DinoShars and Octopus.
/// </summary>
namespace Zoo.Classes
{
    public abstract class Fish:Water
    {
        public abstract bool Scales { get; set; }

        public abstract int EggsPerYear();
    }
}
