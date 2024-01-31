using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Collectable : Displayable
	{
		public string Name { get; set; }
		public int Score { get; set; }
		public int Value { get; set; }
		public CollectionBoard Board { get; set; }

		public Collectable(string name, int score, int value)
		{
			Name = name;
			Score = score;
			Value = value;
		}

		public abstract void AddMe(List<Collectable> collected);

		public abstract void Display();
	}
}

