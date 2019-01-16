using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public class Pterodactyl : Flying
    {
        public override bool Tail { get; set; } = true;
        public override string Location { get; set; } = "Free Range in Zoo";
        public override decimal FeedCost { get; set; } = 7000.50m;
        public override int Eyes { get; set; } = 4;
        public override bool Safe { get; set; } = true;

        public override string Flyer()
        {
            return "I like to hover over people visiting me.";
        }

        public override string Eat()
        {
            return "I enjoy eating bird food and scraps from the food court.";
        }

        public override string Speak()
        {
            return "Kaaaaaaaaahnnnn";
        }
    }
}
