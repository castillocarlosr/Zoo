using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class DinoOtter : Mammal, ITricks
    {
        public override bool Tail { get; set; } = true;
        public override bool Packs { get; set; } = true; //They travel in packs
        public override string Location { get; set; } = "Aquarium Pool 2";
        public override int Eyes { get; set; } = 2;
        public override decimal FeedCost { get; set; } = 2_234.50m;
        public override bool Safe { get; set; } = true;
        public bool FunTricks { get; set; } = true;

        public override string Eat()
        {
            return "I like healthy snacks of nuts and cheap tuna or shrimp";
        }

        public override int GiveBirth()
        {
            return 2; //Gives birth to 4 DinoOtters per year.
        }

        public string Perform()
        {
            throw new NotImplementedException();
        }

        public string Splash()
        {
            return "I like to make a BIG SPLASH!!!!!!  Cheer for me!";  
        }
    }
}
