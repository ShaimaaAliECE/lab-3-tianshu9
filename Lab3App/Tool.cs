﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        public Tool(string Name) : base(Name) { }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);

            DoAction();
        }

        public virtual void DoAction() { }
    }
}