using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Diamond : Collectable
    {
        public Diamond(string name, int score) : base(name, score, 0) { }

        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine($"{Name} Collected, Congrats!!!!");
            Board.UpdateScore(Score);
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{Name} is displayed");
        }
    }
}

