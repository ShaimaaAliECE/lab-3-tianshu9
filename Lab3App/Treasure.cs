using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public Treasure(string name, int score, int value) : base(name, score, value) { }

        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine($"{Name} Collected, Congrats!!!!");
            Board.UpdateScore(Score);
            Board.UpdateValue(Value);
        }

        public override void Display()
        {
            Console.WriteLine($"Treasure {Name} is displayed");
        }
    }
}

