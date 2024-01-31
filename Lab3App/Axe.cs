using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Collectable
    {
        public Axe(string name) : base(name, score: 0, value: 0) { }

        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine($"{Name} Collected, Congrats!!!!");
            Console.WriteLine("Axe is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"Axe {Name} is displayed");
        }
    }
}
