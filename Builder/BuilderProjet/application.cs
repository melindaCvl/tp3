using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProjet
{
    class Application
    {
        static void Main(string[] args)
        {
            Ouvrier unOuvrier = new Ouvrier();

            VoitureClioBuilder unConstructeur = new VoitureClioBuilder();
            unOuvrier.setVoitureBuilder(unConstructeur);

            VoitureEspaceBuilder constructeurEspace = new VoitureEspaceBuilder();
            unOuvrier.setVoitureBuilder(constructeurEspace);
        }
    }
}
