﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition.Classes
{
    class Addition : Binaire
    {
        
        //private string chaine;
        private int nb;

        public Addition(Expression operandeGauche, Expression operandeDroite) : base (operandeGauche, operandeDroite)
        {

        }

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
