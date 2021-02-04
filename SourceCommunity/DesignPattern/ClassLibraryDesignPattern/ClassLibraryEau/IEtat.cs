using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryEau
{
    public interface IEtat
    {
        IEtat AugmenterPression(float nouvellePression, int etatActuelTemperature);
        IEtat BaisserPression(float nouvellePression, int etatActuelTemperature);
        IEtat ChaufferTemperature(float etatActuelPression, int nouvelleTemperature);
        IEtat RefroidirTemperature(float etatActuelPression, int nouvelleTemperature);


    

   

       


    }
}