using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public class DinoShark : Fish
    {
        public override bool Scales { get; set; } = true;
        public override bool Packs { get; set; } = false;
        public override string Location { get; set; } = "Shark Tank";
        public override int Eyes { get; set; } = 2;
        public override decimal FeedCost { get; set; } = 54_673.75m;
        public override bool Safe { get; set; } = false;

        public override string Eat()
        {
            return "I will eat ANYTHING!";
        }

        public override int EggsPerYear()
        {
            return 25; //I lay 25 eggs per year.  Only the strongest survive.
        }
    }
}
