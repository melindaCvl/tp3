using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderProjet
{
    public class VoitureEspaceBuilder : VoitureBuilder
    {
        public override Voiture getVoiture()
        {
            voiture = new Voiture();
            voiture.Carosserie = "Carosserie 5 portes";
            voiture.Chassis = "Chassis long";
            voiture.Moteur = "Moteur dièsel";

            return voiture;
        }
    }
}