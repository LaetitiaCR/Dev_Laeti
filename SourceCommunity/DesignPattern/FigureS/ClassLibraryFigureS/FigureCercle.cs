using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigureS
{
    public class FigureCercle : Figure
    {

        private int rayon;

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public override void Accept(IVisiteur<bool> iv)
        {
            //string strNomForme = "Je suis un cercle";
        }

        public override void Accept(IVisiteur<Object> iv)
        {
            throw new NotImplementedException();
        }

        public override void NomForme()
        {
            string strNomForme = "Je suis un cercle";
            Console.WriteLine(strNomForme);
            
        }

        public override void SeDeplacer(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return "Je suis un cercle";
        }
    }
}
