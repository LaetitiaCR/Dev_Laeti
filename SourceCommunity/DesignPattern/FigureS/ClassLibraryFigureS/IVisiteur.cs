using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigureS
{
    public interface IVisiteur <T>
    {

        T Visit(FigureCercle _c);
        T Visit(FigureRectangle _f);
        T Visit(FigureTriangle _t);

        T Visit(Figures _fs);

    }
}
