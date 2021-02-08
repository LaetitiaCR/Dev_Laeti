using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryEau
{
    public class Gazeux : IEtat
    {

     


        //Etat solide
        private const float maxPressionSolide = (float)0.00611;   //bar(6, 11 hectopascal, cent pascal) 
        private const int maxTemperatureSolide = 0;     //en deçà de 273,15 K, (en deça de 0°C )


        //Etat Gazeux
        private const int minTemperatureGazeux = 100;                // (100°C)      373,15 K    
        private const float minPressionGazeux = (float)220.6;        //  (220,6 bar) (22,06 MPa ou 218 atm)

        
        public override string ToString()
        {
            return "Je suis un gaz";
        }


        public IEtat ChaufferTemperature(float etatActuelPression, int nouvelleTemperature)
        {
            return this;
        }

        public IEtat RefroidirTemperature(float etatActuelPression, int nouvelleTemperature)
        {
            if(nouvelleTemperature < minTemperatureGazeux & nouvelleTemperature > maxTemperatureSolide & etatActuelPression > maxPressionSolide & etatActuelPression < minPressionGazeux)
            {
                return new Liquide();
            }
            else if (nouvelleTemperature < maxTemperatureSolide & etatActuelPression < maxPressionSolide)
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
            return this;
        }

        public IEtat BaisserPression(float nouvellePression, int etatActuelTemperature)
        {
            if (nouvellePression < minPressionGazeux & nouvellePression > maxPressionSolide & etatActuelTemperature < minTemperatureGazeux & etatActuelTemperature > maxTemperatureSolide)
            {
                return new Liquide();
            }
            else if (nouvellePression < maxPressionSolide & etatActuelTemperature < maxTemperatureSolide)
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