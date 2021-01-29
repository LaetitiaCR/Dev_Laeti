using ClassLibraryFigureS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigureS
{
    class VisiteurFigurePourConsole : IVisiteur<bool>
    {

        public bool Visit(FigureCercle _c)
        {
            Console.WriteLine(_c.ToString());
            return true;
        }

        public bool Visit(FigureRectangle _f)
        {
            Console.WriteLine(_f.ToString());
            return true;

        }

        public bool Visit(FigureTriangle _t)
        {
            Console.WriteLine(_t.ToString());
            return true;
        }

        public bool Visit(Figures _fs)
        {
            Console.WriteLine(_fs.ToString());
            return true;
        }

       
    }
}
