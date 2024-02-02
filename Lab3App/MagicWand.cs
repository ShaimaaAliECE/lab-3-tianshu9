using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string Name) : base(Name) { }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

        public override void Display()
        {
            Console.WriteLine(String.Format("MagicWand {0} is displayed", this.Name));
        }
    }
}
