using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryPersistanceExam
{
    public struct sDemandeurEmploi
    {
            public ulong numSS;
            public string nom;
            public string prenom;
            public DateTime dateInscription;

            public sDemandeurEmploi(ulong numSS, string nom, string prenom, DateTime dateInscription)
            {

                this.numSS = numSS;
                this.nom = nom;
                this.prenom = prenom;
                this.dateInscription = dateInscription;
               
            }

        
    }
}
