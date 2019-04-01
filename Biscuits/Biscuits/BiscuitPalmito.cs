using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuits
{
    public class BiscuitPalmito : Biscuit
    {
        private int nbOreilles;

        public BiscuitPalmito(int nbOreilles)
        {
            this.nbOreilles = nbOreilles;
        }

        public override Biscuit Clone()
        {
            return new BiscuitPalmito(nbOreilles);
        }

        public override void Manger()
        {
            Console.WriteLine("Palmito, ça se croque par ses " + nbOreilles + " oreilles !");
        }
    }
}