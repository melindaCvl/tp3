using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque banque1 = Banque.getInstance();
            Banque banque2 = Banque.getInstance();
            JoueurHumain joueur1 = new JoueurHumain(50000);
            JoueurHumain joueur2 = new JoueurHumain(50000);

            //
            int transaction = 20000;
            banque1.Payer(transaction);
            joueur1.Encaisser(transaction);

            //
            transaction = 10000;
            banque2.Payer(transaction);
            joueur2.Encaisser(transaction);

            //
            Console.WriteLine("Banque 1");
            Console.WriteLine(banque1.Cash);
            Console.WriteLine("");
            Console.WriteLine("Banque 2");
            Console.WriteLine(banque2.Cash);
            Console.WriteLine("");
            Console.WriteLine("Joueur 1");
            Console.WriteLine(joueur1.Cash);
            Console.WriteLine("");
            Console.WriteLine("Joueur 2");
            Console.WriteLine(joueur2.Cash);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
