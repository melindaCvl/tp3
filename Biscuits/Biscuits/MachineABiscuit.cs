using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuits
{
    public class MachineABiscuit
    {
        private Biscuit biscuit;

        public MachineABiscuit(Biscuit biscuit)
        {
            this.biscuit = biscuit;
        }

        public ArrayList FairePaquetBiscuit()
        {
            ArrayList listeBiscuit = new ArrayList();

            for (int indBisc = 0; indBisc < 24; indBisc++)
            {
                listeBiscuit.Add(biscuit.Clone());
            }

            return listeBiscuit;
        }
    }
}