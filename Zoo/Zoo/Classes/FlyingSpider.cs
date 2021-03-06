﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete Class.  Its derived from Flying Class.
    /// </summary>
    public class FlyingSpider : Flying
    {
        public override bool Tail { get; set; } = false;
        public override string Location { get; set; } = "Enclosed cages behind force field";
        public override decimal FeedCost { get; set; } = 688.25m;
        public new bool Safe()
        {
            return false;
        }

        public override string Eat()
        {
            return "I eat other spiders";
        }

        public override string Flyer()
        {
            return "I'm a spider and fly as well.  Yup.  I'm dangerous!";
        }

        public override string Speak()
        {
            return "clack clack clack.  scary clack";
        }
    }
}
