using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    public class Nombre : Expression
    {

        private int nb;
        //private string chaine;
   

        public Nombre(int nb)
        {
            this.nb = nb;    
        }

        public int Nb { get; set; }

        public override int Evaluer()
        {  
            return nb;
        }

        public override string ToString() 
        {
            return ".nb.";
        }

    }
}
