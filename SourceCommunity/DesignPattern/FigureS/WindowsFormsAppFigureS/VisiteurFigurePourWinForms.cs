using ClassLibraryFigureS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFigureS
{
    class VisiteurFigurePourWinForms : IVisiteur<Object>
    {
        public object Visit(FigureCercle _c)
        {
            return _c;
        }

        public object Visit(FigureRectangle _f)
        {
            return _f;
        }

        public object Visit(FigureTriangle _t)
        {
           return _t;
        }

        public object Visit(Figures _fs)
        {
           return _fs; 
        }

       
    }
}
