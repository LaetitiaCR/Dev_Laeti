using ClassLibraryFigureS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigureS
{
    class Program 
    {
        static void Main(string[] args)
        {


            
            FigureRectangle figRect = new FigureRectangle();
            figRect.NomForme();

            FigureTriangle figTri = new FigureTriangle();
            figTri.NomForme();


            Console.WriteLine("**********************************");

            Figures figS = new Figures();


            figS.Add(figRect);
            figS.Add(figTri);

            figS.NomForme();


            Console.WriteLine("**********************************");

            //mafigure.Accept(new Visiteur()); -> aura pour consequence d'afficher le message

            VisiteurFigurePourConsole iv = new VisiteurFigurePourConsole();
            FigureRectangle figRect2 = new FigureRectangle();
            iv.Visit(figRect2);

            


        }
    }
}
