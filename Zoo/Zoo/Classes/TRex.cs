using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo.Classes
{
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
