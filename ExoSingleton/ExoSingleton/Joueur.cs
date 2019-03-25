using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExoSingleton
{
    public class Joueur
    {
        public int Cash = 0;
        
        public ArrayList Possessions = new ArrayList();

        public Joueur(int cash)
        {
            Cash = cash;
        }

        public void Payer(int cash)
        {
            Cash = Cash - cash;
        }

        public void Encaisser(int cash)
        {
            Cash = Cash + cash;
        }

        public void Acheter()
        {
            throw new System.NotImplementedException();
        }

        public void Vendre()
        {
            throw new System.NotImplementedException();
        }
    }
}