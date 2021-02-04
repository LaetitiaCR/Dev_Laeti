using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryEau
{
    

    public class Eau
    {

        /*

        //Etat solide
        private const float maxPressionSolide = (float)0.00611;   //bar(6, 11 hectopascal, cent pascal) 
        private const int maxTemperatureSolide = 0;     //en deçà de 273,15 K, (en deça de 0°C )


        //Etat liquide
        private const float minPressionLiquide = (float)0.00611;  //bar(611 Pascal 6,11 hectopascal, cent pascal)
        private const float maxPressionLiquide = (float)220.6;    //bar(22,06 MPa ou 218 atm);

        private const int minTemperatureLiquide = 0;     //  (0°C) 	    273,15 K 
        private const int maxTemperatureLiquide = 100;   // (100°C)     373,15 K 



        //Etat Gazeux
        private const int minTemperatureGazeux = 100;                // (100°C)      373,15 K    
        private const float minPressionGazeux = (float)220.6;        //  (220,6 bar) (22,06 MPa ou 218 atm)

        */
        

      

        private IEtat etatCourant;


       
        private float pressionCourante;
        private int temperatureCourante;

        /*
        public float Pression
        {
            get { return pression; }
            set { pression = value; }
        }

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
       */

        public Eau()
        {

            //initialisation on lui donne un état avec un temperature initial et une pression courante
            temperatureCourante = 0;
            pressionCourante = (float)0.00611;
            etatCourant = new Liquide();
           
        }

        public void ChaufferTemperature(int temperatureAAjouter)
        {
            temperatureCourante += temperatureAAjouter;
            etatCourant= etatCourant.ChaufferTemperature(pressionCourante, temperatureCourante);
            
        }

        public void RefroidirTemperature(int temperatureADiminuer)
        {
            temperatureCourante += temperatureADiminuer;
            etatCourant = etatCourant.RefroidirTemperature(pressionCourante, temperatureCourante);
          
        }

        public void AugmenterPression(float pressionAAjouter)
        {
            pressionCourante += pressionAAjouter;
            etatCourant = etatCourant.AugmenterPression(pressionCourante, temperatureCourante);
      
        }

        public void BaisserPression(float pressionADiminuer)
        {
            pressionCourante += pressionADiminuer;
            etatCourant = etatCourant.BaisserPression(pressionCourante, temperatureCourante);
      
        }

        public override string ToString()
        {
            return "je suis de l'eau " + etatCourant.ToString();
        }


    }
}