using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderProjet
{
    public class VoitureClioBuilder : VoitureBuilder
    {
        public override Voiture getVoiture()
        {
            voiture = new Voiture();
            voiture.Carosserie = "Carosserie 3 portes";
            voiture.Chassis = "Chassis court";
            voiture.Moteur = "Moteur essence";

            return voiture;
        }

        
    }
}