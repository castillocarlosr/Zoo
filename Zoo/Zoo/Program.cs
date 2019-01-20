using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jurrasic Zoo!");
            Console.WriteLine("\n");

            SurfaceAnimals();
            WaterAnimals();
        }

        public static void SurfaceAnimals()
        {
            Console.WriteLine("Pterodactyl I am!");
            Pterodactyl pterodactyl = new Pterodactyl();
            Console.WriteLine($"Tail: {pterodactyl.Tail}.");
            Console.WriteLine($"Location: {pterodactyl.Location}.");
            Console.WriteLine($"Feed Cost:${pterodactyl.FeedCost}.");
            Console.WriteLine($"# of Eyes: {pterodactyl.Eyes}.");
            Console.WriteLine($"Are they Safe: {pterodactyl.Safe}.");
            Console.WriteLine($"Flyer: {pterodactyl.Flyer()}.");
            Console.WriteLine($"Eat: {pterodactyl.Eat()}.");
            Console.WriteLine($"Speak: {pterodactyl.Speak()}.");
 
            Console.WriteLine("");
            Console.WriteLine("Flying-Spider I am!");
            FlyingSpider flyingSpider = new FlyingSpider();
            Console.WriteLine($"Tail: {flyingSpider.Tail}.");
            Console.WriteLine($"Location: {flyingSpider.Location}.");
            Console.WriteLine($"Feed Cost:${flyingSpider.FeedCost}.");
            Console.WriteLine($"# of Eyes: {flyingSpider.Eyes}.");
            Console.WriteLine($"Are they Safe: {flyingSpider.Safe()}.");
            Console.WriteLine($"Flyer: {flyingSpider.Flyer()}.");
            Console.WriteLine($"Eat: {flyingSpider.Eat()}.");
            Console.WriteLine($"Speak: {flyingSpider.Speak()}.");

            //Two Interfaces here!
            Console.WriteLine("");
            Console.WriteLine("T-Rex I am!");
            TRex rex = new TRex();
            Console.WriteLine($"Tail: {rex.Tail}.");
            Console.WriteLine($"Location: {rex.Location}.");
            Console.WriteLine($"Feed Cost:${rex.FeedCost}.");
            Console.WriteLine($"# of Eyes: {rex.Eyes}.");
            Console.WriteLine($"Are they Safe: {rex.Safe}.");
            Console.WriteLine($"Walking: {rex.Walking()}.");
            Console.WriteLine($"Eat: {rex.Eat()}.");
            Console.WriteLine($"Speak: {rex.Speak()}.");
            Console.WriteLine($"Drinking: {rex.Drinking()}.");
            Console.WriteLine($"Interface => Fun Tricks: {rex.FunTricks}.");
            Console.WriteLine($"Interface => Loves Humans: {rex.lovesHumans}.");

            Console.WriteLine("");
            Console.WriteLine("Brontosaurus I am!");
            Brontosaurs brontosaurs = new Brontosaurs();
            Console.WriteLine($"Tail: {brontosaurs.Tail}.");
            Console.WriteLine($"Location: {brontosaurs.Location}.");
            Console.WriteLine($"Feed Cost:${brontosaurs.FeedCost}.");
            Console.WriteLine($"# of Eyes: {brontosaurs.Eyes}.");
            Console.WriteLine($"Are they Safe: {brontosaurs.Safe}.");
            Console.WriteLine($"Walking: {brontosaurs.Walking()}.");
            Console.WriteLine($"Eat: {brontosaurs.Eat()}.");
            Console.WriteLine($"Speak: {brontosaurs.Speak()}.");
            Console.WriteLine($"Drinking: {brontosaurs.Drinking()}.");
        }

        public static void WaterAnimals()
        {
            Console.WriteLine("");
            Console.WriteLine("Dino-Shark I am!");
            DinoShark dinoShark = new DinoShark();
            Console.WriteLine($"Scales: {dinoShark.Scales}.");
            Console.WriteLine($"Packs: {dinoShark.Packs}.");
            Console.WriteLine($"Location: {dinoShark.Location}.");
            Console.WriteLine($"Eyes: {dinoShark.Eyes}.");
            Console.WriteLine($"Feeding Cost:${dinoShark.FeedCost}.");
            Console.WriteLine($"Are they safe: {dinoShark.Safe}.");
            Console.WriteLine($"Eat: {dinoShark.Eat()}.");
            Console.WriteLine($"How many eggs laid a year: {dinoShark.EggsPerYear()}.");


            Console.WriteLine("");
            Console.WriteLine("Octopus I am!");
            Octopus octopus = new Octopus();
            Console.WriteLine($"Scales: {octopus.Scales}.");
            Console.WriteLine($"Packs: {octopus.Packs}.");
            Console.WriteLine($"Location: {octopus.Location}.");
            Console.WriteLine($"Eyes: {octopus.Eyes}.");
            Console.WriteLine($"Feeding Cost:${octopus.FeedCost}.");
            Console.WriteLine($"Are they safe: {octopus.Safe}.");
            Console.WriteLine($"Eat: {octopus.Eat()}.");
            Console.WriteLine($"How many eggs laid a year: {octopus.EggsPerYear()}.");
            Console.WriteLine($"Smarts: {octopus.Smart()}.");

            Console.WriteLine("");
            Console.WriteLine("Orca I am!");
            Orca orca = new Orca();
            Console.WriteLine("");
            Console.WriteLine($"Tails: {orca.Tail}.");
            Console.WriteLine($"Packs: {orca.Packs}.");
            Console.WriteLine($"Location: {orca.Location}.");
            Console.WriteLine($"Eyes: {orca.Eyes}.");
            Console.WriteLine($"Feeding Cost:${orca.FeedCost}.");
            Console.WriteLine($"Are they safe: {orca.Safe}.");
            Console.WriteLine($"Eat: {orca.Eat()}.");
            Console.WriteLine($"How many does it give birth per year: {orca.GiveBirth()}.");

            //Interface here as Well
            Console.WriteLine("Dino-Otter I am!");
            DinoOtter dinoOtter = new DinoOtter();
            Console.WriteLine($"Tails: {dinoOtter.Tail}.");
            Console.WriteLine($"Packs: {dinoOtter.Packs}.");
            Console.WriteLine($"Location: {dinoOtter.Location}.");
            Console.WriteLine($"Eyes: {dinoOtter.Eyes}.");
            Console.WriteLine($"Feeding Cost:${dinoOtter.FeedCost}.");
            Console.WriteLine($"Are they safe: {dinoOtter.Safe}.");
            Console.WriteLine($"Eat: {dinoOtter.Eat()}.");
            Console.WriteLine($"How many does it give birth per year: {dinoOtter.GiveBirth()}.");
            Console.WriteLine($"Interface => Fun Tricks: {dinoOtter.FunTricks}.");
            Console.WriteLine($"Interface => Loves Humans: {dinoOtter.Splash()}.");
            Console.ReadLine();
        }
    }
}
