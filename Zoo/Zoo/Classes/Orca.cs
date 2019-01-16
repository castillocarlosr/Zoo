using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public class Orca : Mammal
    {
        public override bool Tail { get; set; }
        public override bool Packs { get; set; }
        public override string Location { get; set; }
        public override int Eyes { get; set; }
        public override decimal FeedCost { get; set; }
        public override bool Safe { get; set; }

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
