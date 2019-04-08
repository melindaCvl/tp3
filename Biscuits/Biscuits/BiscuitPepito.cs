using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuits
{
    public class BiscuitPepito : Biscuit
    {
        private string typeChocolat;

        public BiscuitPepito(String typeChocolat)
        {
            this.typeChocolat = typeChocolat;
        }

        public override Biscuit Clone()
        {
            return new BiscuitPepito(typeChocolat);
        }

        public override void Manger()
        {
            Console.WriteLine("Aïe Pepito au chocolat " + typeChocolat + " !");
        }
    }
}