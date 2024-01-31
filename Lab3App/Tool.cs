using System;
using System.Collections.Generic;

namespace Lab3App
{

    internal class Tool : Collectable
    {
        public Tool(string name, int score, int value) : base(name, score, value) { }

        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
        }

        public override void Display()
        {
            Console.WriteLine($"Coin: {Name}, Score: {Score}, Value: {Value}");
        }
    }

}

