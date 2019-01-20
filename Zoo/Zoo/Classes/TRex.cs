using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class.  It's derived from Land class
    /// Interface included.  ICuddles interface.
    /// </summary>
    public class TRex : Land, ICuddles, ITricks
    {
        public override bool Tail { get; set; } = true;
        public override string Location { get; set; } = "Free roam around the zoo";
        public override int Eyes { get; set; } = 2;
        public override decimal FeedCost { get; set; } = 24_500.50m;
        public override bool Safe { get; set; } = true;
        public bool lovesHumans { get; set; } = true;
        public bool FunTricks { get; set; } = true;

        public override string Drinking()
        {
            return "I enjoy drinking soda pop";
        }

        public override string Eat()
        {
            return "I enjoy healthy balance of vegitable and lean meats.";
        }

        public string Hug()
        {
            return "I enjoy being hugged as I myself can not reach to hug others.  That makes me a sad T-Rex...";
        }

        public override string Speak()
        {
            return "Woof woof.  ROAARRR!";
        }

        public override string Walking()
        {
            return "I enjoy a casual walk.  Some say I'm more dog than T-REX.";
        }

        string ITricks.Perform()
        {
            return "Watch me make a back flip.";
        }
    }
}
