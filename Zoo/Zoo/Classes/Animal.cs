using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{

    public abstract class Animal
    {
        /// <summary>
        /// Properties for the Animal Abstract class. (Parent Class)  
        /// </summary>
        public abstract string Location { get; set; }
        public abstract int Eyes { get; set; }
        public abstract decimal FeedCost { get; set; }
        public virtual bool Safe { get; set; }

        /// <summary>
        /// Methods below for Eating and Moving around in the zoo
        /// </summary>
        public abstract string Eat();

        public abstract string Moving();

    }
}
