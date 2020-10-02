using System;
using System.ComponentModel;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldInhibitant[] worldlist = { new england(), new russia(), new WorldInhibitant() };

            foreach (var worlds in worldlist)
            {
                worlds.worldsounds();
            }
        }
    }
    class WorldInhibitant
    {
        virtual public void worldsounds()
        {
            Console.WriteLine("I live in the world");
        }
    }
    class england : WorldInhibitant
    {
        override public void worldsounds()
        {
            Console.WriteLine("england says BRITISH FOREVER");
        } 
    }
    class russia : WorldInhibitant
    {
        public override void worldsounds()
        {
            Console.WriteLine("russia says nyohohohohohohoo");
        }
    }

}
