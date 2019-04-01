using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuits
{
    class Program
    {
        static void Main(string[] args)
        {
            BiscuitPalmito biscuitPalmito = new BiscuitPalmito(20);
            BiscuitPepito biscuitPepito = new BiscuitPepito("noir");

            MachineABiscuit machine = new MachineABiscuit(biscuitPalmito);
            MachineABiscuit machine2 = new MachineABiscuit(biscuitPepito);

            // Biscuits Palmito
            ArrayList listeBiscuits = machine.FairePaquetBiscuit();
            foreach (Biscuit b in listeBiscuits)
            {
                b.Manger();
            }

            // Biscuits Pepito
            listeBiscuits = machine2.FairePaquetBiscuit();
            foreach (Biscuit b in listeBiscuits)
            {
                b.Manger();
            }

            Console.ReadKey();

        }
    }
}
