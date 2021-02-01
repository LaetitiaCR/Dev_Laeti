using ConsoleAppAddition.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddition
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            Expression expr1 = new Addition(new Nombre(33), new Nombre(33));
            int resultat1 = expr1.Evaluer();

            Expression expr2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            int resultat2 = expr2.Evaluer();



        }
    }
}
