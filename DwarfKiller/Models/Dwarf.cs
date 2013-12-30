using System;

namespace DwarfKiller.Models
{
    public class Dwarf : Character
    {
        //Notice that there are no properties directly in Dwarf.
        //We inherit from Character, which gives us access just like Hero
        //maybe in the future we can add more properties, or have another "Enemy" class to inherit from

        public Dwarf() //This is a constructor. It will execute every time someone instantiates a new Dwarf.
        {
            //Some languages require constructors, in C#, it is handled automatically for you if you don't want one
            //Within here we can set some defaults, basically do whatever we want
            //Anything that we want to run for a new dwarf is important to put here

            //Random number generator with a seed (Look up what a seed does for randoms)
            var rnd = new Random(DateTime.Now.Millisecond);

            HitPoints = rnd.Next(8,14);
            AttackPoints = 3;
            DefensePoints = 5;

            //Instantiation shortcut for string array
            string[] dwarfNames = {"Jim-Bob", "Billy-Jean", "Bob Dole", "Bif Tanner", "Barack Obama", "Ron Paul", "Shay Kaspear"};

            //Get a random number based on the array length above to pick a name at random by index
            var randomNameIndex = rnd.Next(0, dwarfNames.GetUpperBound(0)+1);

            Name = dwarfNames[randomNameIndex];
        }
    }
}
