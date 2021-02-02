using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    class Addition : Binaire
    {
        
        //private string chaine;
       
       

        public Addition(Expression operandeGauche, Expression operandeDroite) : base (operandeGauche, operandeDroite)
        {
           
            
        }

        public override int Evaluer()
        {
            int resultatAdd;
            //Expression expr1 = new Nombre();
            resultatAdd = operandeGauche.Evaluer() + operandeDroite.Evaluer();
            return resultatAdd;
        }

        public override string ToString()
        {
            return ".resultatAdd.";
        }

    }
}
