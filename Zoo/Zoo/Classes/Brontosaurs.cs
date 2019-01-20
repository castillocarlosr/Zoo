using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete Class-> derived from Land Parent Class.
    /// </summary>
    public class Brontosaurs : Land
    {
        public override bool Tail { get; set; } = true;
        public override string Location { get; set; } = "Safari Plains area of Zoo";
        public override int Eyes { get; set; } = 2;
        public override decimal FeedCost { get; set; } = 1_987_654.50m; //big animal needs a lot of food
        public override bool Safe { get; set; } = false;

        public override string Drinking()
        {
            return "Is careful when drinking because it can't swim!";
        }

        public override string Eat()
        {
            return "I like eating A LOT of PLANTS and TREE LEAFS";
        }

        public override string Speak()
        {
            return "Mooooooowwwwww";
        }

        public override string Walking()
        {
            return "I'm surprisngly a fast walker.";
        }
    }
}
