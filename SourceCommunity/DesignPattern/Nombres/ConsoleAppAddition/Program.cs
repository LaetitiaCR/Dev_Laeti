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
            string operateur = "+";

            
            Expression expr = new Expression();
          
            //int eval = expr.Evaluer();

            //Nombre nb1 = new Nombre(3);


            


            Expression exprNb1 = new Nombre(2);
            Expression exprNb2 = new Nombre(3);

            Binaire bin1 = new Binaire();
            //exprNb1.Evaluer();


            /*
           

            Nombre nb1 = new Nombre(3);
            Nombre nb2 = new Nombre(2);
            */

           // int eval1 = nb1.Evaluer();

            if (operateur == "+")
            {

            }
        }
    }
}
