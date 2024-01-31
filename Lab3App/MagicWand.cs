using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class MagicWand : Collectable
    {
        public MagicWand(string name) : base(name, score: 0, value: 0) { }

        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine($"{Name} Collected, Congrats!!!!");
            Console.WriteLine("MagicWand is used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Name} is displayed");
        }
    }
}

