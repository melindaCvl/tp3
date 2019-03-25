using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExoSingleton
{
    public class JoueurHumain : Joueur
    {
        public JoueurHumain(int cash) : base(cash) {}

        public int LancerDes()
        {
            return 0;
        }
    }
}