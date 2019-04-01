using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuits
{
    public abstract class Biscuit : ICloneable
    {
        public abstract Biscuit Clone();
        public abstract void Manger();
    }
}