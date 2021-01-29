using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigureS
{
    public class FigureTriangle : Figure
    {
        public override void Accept(IVisiteur<bool> iv)
        {
            throw new NotImplementedException();
        }

        public override void NomForme()
        {
            string strNomForme = "Je suis un triangle";
            Console.WriteLine(strNomForme);
       

        }

        public override string ToString()
        {
            return "Je suis un triangle";
        }

        public override void SeDeplacer(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override void Accept(IVisiteur<Object> iv)
        {
            throw new NotImplementedException();
        }
    }
}
