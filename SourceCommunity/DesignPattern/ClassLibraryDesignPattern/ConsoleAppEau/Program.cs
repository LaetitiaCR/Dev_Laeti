using ClassLibraryEau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEau
{
    class Program
    {
        static void Main(string[] args)
        {
            Eau e = new Eau();
            Console.WriteLine(e.ToString());

            e.AugmenterPression(240);
            Console.WriteLine(e.ToString());
            e.ChaufferTemperature(120);
            Console.WriteLine(e.ToString());


            
            e.BaisserPression(-250);
            Console.WriteLine(e.ToString());
            e.RefroidirTemperature(-150);
            Console.WriteLine(e.ToString());

        }
    }
}
