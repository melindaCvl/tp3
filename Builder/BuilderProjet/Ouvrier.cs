using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BuilderProjet
{
    public class Ouvrier
    {
        public ArrayList voitureBuilder = new ArrayList();

        public void setVoitureBuilder(VoitureBuilder vb)
        {
            voitureBuilder.Add(vb);
        }

        public void assemblerVoiture()
        {
            throw new System.NotImplementedException();
        }

        public void getVoiture()
        {
            throw new System.NotImplementedException();
        }
    }
}