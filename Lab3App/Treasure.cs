using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        private int Score;

        public Treasure(string Name, int Score) : base(Name)
        {
            this.Score = Score;
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += this.Score;
            Console.WriteLine("Total score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalScore();
        }
    }
}