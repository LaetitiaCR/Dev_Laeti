using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryFigureS
{
    public class FigureRectangle : Figure
    {

        private int longueur;

        private int largeur;

        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }





        public override void Accept(IVisiteur<bool> iv)
        {
            iv.Visit(this);
        }

        public override void Accept(IVisiteur<Object> iv)
        {
            iv.Visit(this);
        }

        public override void NomForme()
        {
            string strNomForme= "Je suis un rectangle";
            Console.WriteLine(strNomForme);

        }

        public override void SeDeplacer(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return "Je suis un rectangle";
        }
    }
}
