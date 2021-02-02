using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppEau
{
    public class Liquide : Etat, IEtat
    {

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override string Transformation(int Temperature, DateTime Temps)
        {
            throw new System.NotImplementedException();
        }

        public override int Agmenter(string Pression)
        {
            throw new System.NotImplementedException();
        }

        public override int Baisser(int Pression)
        {
            throw new System.NotImplementedException();
        }

        public override int Chauffer(string Temperature)
        {
            throw new System.NotImplementedException();
        }

        public override int Refroidir(int Temperature)
        {
            throw new System.NotImplementedException();
        }
    }
}