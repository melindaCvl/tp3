using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderProjet
{
    public abstract class VoitureBuilder
    {
        public Voiture voiture;

        public abstract Voiture getVoiture();
    }
}