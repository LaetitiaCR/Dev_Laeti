using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryEau
{
    public class Liquide : IEtat
    {


        //Etat liquide
        private const float minPressionLiquide = (float)0.00611;  //bar(611 Pascal 6,11 hectopascal, cent pascal)
        private const float maxPressionLiquide = (float)220.6;    //bar(22,06 MPa ou 218 atm);

        private const int minTemperatureLiquide = 0;     //  (0°C) 	    273,15 K 
        private const int maxTemperatureLiquide = 100;   // (100°C)     373,15 K 



       


        public override string ToString()
        {
            return "Je suis un liquide";
        }

       

        public IEtat ChaufferTemperature(float etatActuelPression, int nouvelleTemperature)
        {
            if(nouvelleTemperature > maxTemperatureLiquide & etatActuelPression > maxPressionLiquide)
            {
                return new Gazeux();
            }
            else
            {
                return this;
            }
        
        }

        public IEtat RefroidirTemperature(float etatActuelPression, int nouvelleTemperature)
        {
            if (nouvelleTemperature < minTemperatureLiquide & etatActuelPression < minPressionLiquide)
            {
                return new Solide();
            }
            else
            {
                return this;
            }
        }

       

        public IEtat AugmenterPression(float nouvellePression, int etatActuelTemperature)
        {
            if (nouvellePression > maxPressionLiquide & etatActuelTemperature > maxTemperatureLiquide)
            {
                return new Gazeux();
            }
            else
            {
                return this;
            }
                

        }

        public IEtat BaisserPression(float nouvellePression, int etatActuelTemperature)
        {
            if (nouvellePression < minPressionLiquide & etatActuelTemperature < minTemperatureLiquide)
            {
                return new Solide();
            }
            else
            {
                return this;
            }
        }


    }
}