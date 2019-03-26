using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Propriete
    {
        public int donnees
        {
            get => default(int);
            set
            {

            }
        }

        public string titre
        {
            get => default(string);
            set
            {
            }
        }

        public int prixAchat
        {
            get => default(int);
            set
            {
            }
        }

        public abstract string calculerLoyer();
        
    }
}