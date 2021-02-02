using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppEau
{
    public abstract class EtatInitial
    {

        public int Pression
        {
            get => default;
            set
            {
            }
        }

        public int Temperature
        {
            get => default;
            set
            {
            }
        }

        public DateTime Temps
        {
            get => default;
            set
            {
            }
        }

        public abstract string Transformation(int Temperature, DateTime Temps);

        public abstract string ToString();

        public abstract int Chauffer(string Temperature);

        public abstract int Refroidir(int Temperature);

        public abstract int Agmenter(string Pression);

        public abstract int Baisser(int Pression);
    }
}