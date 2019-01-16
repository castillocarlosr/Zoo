using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public class Octopus : Fish
    {
        public override bool Scales { get; set; } = false;
        public override bool Packs { get; set; } = false;
        public override string Location { get; set; } = "Children's pool";
        public override int Eyes { get; set; } = 44;
        public override decimal FeedCost { get; set; } = 1_987.50m;
        public override bool Safe { get; set; } = true;

        public override string Eat()
        {
            return "I eat ink.  Yup";
        }

        public override int EggsPerYear()
        {
            return 200;
        }

        public string Smart()
        {
            return "I am very very smart";
        }
    }
}
