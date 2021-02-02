using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    public abstract class  Binaire : Expression
    {

        protected Expression operandeGauche;
        protected Expression operandeDroite;
       

        public Binaire(Expression operandeGauche, Expression operandeDroite)
        {
            this.operandeGauche = operandeGauche;
            this.operandeDroite = operandeDroite;
        }


    }
}
