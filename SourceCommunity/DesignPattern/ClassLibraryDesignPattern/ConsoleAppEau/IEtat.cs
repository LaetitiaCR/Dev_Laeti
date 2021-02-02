using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppEau
{
    public interface IEtat
    {
        void Etat(Solide solide);
        void Etat(Liquide Liquide);
        void Etat(Gazeux Gazeux);
    }
}