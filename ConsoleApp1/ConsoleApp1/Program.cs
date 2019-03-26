using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            TerrainFactory usineTerrain = new TerrainFactory();
            EEFactory usineEauElec = new EEFactory();
            GareFactory usineGare = new GareFactory();

            Console.WriteLine(usineTerrain.creerPropriete().calculerLoyer());
            Console.WriteLine(usineTerrain.creerPropriete().calculerLoyer());
            Console.WriteLine(usineGare.creerPropriete().calculerLoyer());
            Console.WriteLine(usineEauElec.creerPropriete().calculerLoyer());
            

            
        }
    }
}
