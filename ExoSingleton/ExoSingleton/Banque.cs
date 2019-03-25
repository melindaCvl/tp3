using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExoSingleton
{
    public class Banque : Joueur
    {
        private static Banque instance;
        private static int InitialCash = 100000;

        private Banque(int cash) : base(cash) { }

        public static Banque getInstance()
        {
            if (instance == null)
            {
                instance = new Banque(InitialCash);
            }

            return instance;
        }
    }
}