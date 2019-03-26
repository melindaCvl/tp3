using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class GareFactory : ProprieteFactory
    {
        public override Propriete creerPropriete()
        {
            return new Gare();
        }

      
    }
}