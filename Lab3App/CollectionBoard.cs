using System;
namespace Lab3App
{
    internal class CollectionBoard
    {
        private int totalScore;
        private int totalValue;

        public void UpdateScore(int score)
        {
            totalScore += score;
            Console.WriteLine($"Total Score is updated to: {totalScore}");
        }

        public void UpdateValue(int value)
        {
            totalValue += value;
            Console.WriteLine($"Total Value is updated to: {totalValue}");
        }
    }
}

