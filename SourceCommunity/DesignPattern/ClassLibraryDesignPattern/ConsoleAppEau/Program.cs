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

            e.AugmenterPression(10);
            Console.WriteLine(e.ToString());
            e.ChaufferTemperature(100);
            Console.WriteLine(e.ToString());
        }
    }
}
