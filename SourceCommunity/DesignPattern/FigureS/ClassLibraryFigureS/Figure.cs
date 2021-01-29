using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigureS
{
   public abstract class Figure 
   {

        //X accesseur de x
        //l 'accesseur ( propriete en C#) s'ecrit avec une majuscule par rapport a l'attribut(champs en C#)
        private int x;

        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract void NomForme();

        public abstract override string ToString();

        public abstract void SeDeplacer(int x, int y);

        public abstract void Accept(IVisiteur<bool> iv);

        public abstract void Accept(IVisiteur<Object> iv);


    }
}
