using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        protected string Name;
        public CollectionBoard Board;

        public Collectable(string Name)
        {
            this.Name = Name;
        }

        public virtual void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine(this.Name + " collected, congrats!!!");
        }

        public abstract void Display();
    }
}
