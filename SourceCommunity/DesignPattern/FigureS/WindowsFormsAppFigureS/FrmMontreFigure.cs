using ClassLibraryFigureS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFigureS
{
    public partial class FrmMontreFigure : Form
    {
        public FrmMontreFigure()
        {
            InitializeComponent();
        }

        private void butShow_Click(object sender, EventArgs e)
        {

            DessineFigure(0);
            //this.Paint += new PaintEventHandler(FrmFigurePaint);
        }



        public void DessineFigure(int deplace)
        {
       
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            VisiteurFigurePourWinForms ivwf = new VisiteurFigurePourWinForms();
            FigureRectangle figRect = new FigureRectangle();
            FigureRectangle figRectV1 = (FigureRectangle)ivwf.Visit(figRect);


            figRectV1.X = 10 + deplace;
            figRectV1.Y = 10 + deplace;

            figRectV1.Largeur = 50;
            figRectV1.Longueur = 100;
           

            formGraphics.FillRectangle(myBrush, new Rectangle(figRectV1.X, figRectV1.Y, figRectV1.Largeur, figRectV1.Longueur));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        

        private void butDeplacer_Click(object sender, EventArgs e)
        {
            //deplacer de 10;
            int deplace = 10;
            DessineFigure(deplace);



        }


        /*
        private void GetPixel_Example(PaintEventArgs e)
        {
            // Create a Bitmap object from an image file.
            Bitmap myBitmap = new Bitmap(@"C:\Users\tanyalebershtein\Desktop\Sample Pictures\Tulips.jpg");

            // Get the color of a pixel within myBitmap.
            Color pixelColor = myBitmap.GetPixel(50, 50);

            // Fill a rectangle with pixelColor.
            SolidBrush pixelBrush = new SolidBrush(pixelColor);
            e.Graphics.FillRectangle(pixelBrush, 0, 0, 100, 100);
        }


        public void DrawRectangle(PaintEventArgs e, int x, int y, int width, int height)
        {


            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);

        }

       


        private void GetRectangle(PaintEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();



            FigureRectangle rect = new FigureRectangle();
            //PaintEventArgs e = new PaintEventArgs();
            int x = 10; int y = 15; int width = 100; int height = 50;
            rect.DrawRectangle(e, x, y, width, height);
            
            //int newX = 15; int newY = 20;
            //rect.SeDeplacer(newX, newY);

        }
 
         
         */


    }
}
