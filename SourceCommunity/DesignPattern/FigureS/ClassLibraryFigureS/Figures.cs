using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigureS
{
    public class Figures : Figure
    {
        private List<Figure> listeFigures;

        public Figures()
        {
            listeFigures = new List<Figure>();
        }

        public List<Figure> ListeFigures
        {
            get { return listeFigures; }
            //set { listes = value; }
        }

        public void Add(Figure _figure)
        {
            listeFigures.Add(_figure);
        }

        public override void NomForme()
        {
            string strNomFigure = "Je suis une figure";
            Console.WriteLine(strNomFigure);
            foreach (Figure element in listeFigures)
            {
               element.NomForme();
            }
 
        }


        public override string ToString()
        {
            return "Je suis une figure";
        }



        public override void SeDeplacer(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public void Remove(Figure _figure)
        {
            if (listeFigures.Contains(_figure))
            {
                listeFigures.Remove(_figure);
            }
        }

        public override void Accept(IVisiteur<bool> iv)
        {
            throw new NotImplementedException();
        }

        public override void Accept(IVisiteur<Object> iv)
        {
            throw new NotImplementedException();
        }
    }
}
