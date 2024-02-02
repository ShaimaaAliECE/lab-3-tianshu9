using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        private int Value;

        public Coin(string Name, int score, int value) : base(Name, score)
        {
            this.Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += this.Value;
            Console.WriteLine("Total value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Name + " is displayed");
        }
    }
}