using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string Name, int score) : base(Name, score) { }

        public override void Display()
        {
            Console.WriteLine("Diamond" + this.Name + " is displayed");
        }
    }
}

