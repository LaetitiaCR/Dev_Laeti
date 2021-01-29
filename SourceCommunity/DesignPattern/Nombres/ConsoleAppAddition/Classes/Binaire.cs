using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    class Binaire : Expression
    {

        private int nb;

        protected Expression operandeGauche;
        protected Expression operandeDroite;
        public Binaire()
        {

        }
        public Binaire(Expression operandeGauche, Expression operandeeDroite)
        {

        }

        public override int Evaluer()
        {
            return nb;
        }
    }
}
