using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete Class.  Derived from Mammal Class.
    /// </summary>
    public class Orca : Mammal
    {
        public override bool Tail { get; set; } = true;
        public override bool Packs { get; set; } = true;
        public override string Location { get; set; } = "Open waters";
        public override int Eyes { get; set; } = 4;
        public override decimal FeedCost { get; set; } = 5432.75m;
        public override bool Safe { get; set; } = true;

        public override string Eat()
        {
            return "I eat fish from Pikes Place Markert";
        }

        public override int GiveBirth()
        {
            return 2;
        }
    }
}
