using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    class Soustraction : Binaire
    {
        private int nb;
        public Soustraction()
        {

        }

        public override int Evaluer()
        {
            return nb;
        }

    }
}
