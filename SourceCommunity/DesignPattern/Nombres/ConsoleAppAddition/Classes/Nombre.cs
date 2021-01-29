using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    class Nombre : Expression
    {
        private int nb;
   

        public Nombre(int nb)
        {
            this.nb = nb;
    
            
        }
        public int Nb { get; set; }

        public override int Evaluer()
        {
        
            return nb;
        }


    }
}
