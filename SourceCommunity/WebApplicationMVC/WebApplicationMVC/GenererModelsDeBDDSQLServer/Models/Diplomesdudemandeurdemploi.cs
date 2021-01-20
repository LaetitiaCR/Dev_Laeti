using System;
using System.Collections.Generic;

#nullable disable

namespace GenererModelsDeBDDSQLServer.Models
{
    public partial class Diplomesdudemandeurdemploi
    {
        public long IdDemandeurDemploi { get; set; }
        public int IdDuDiplomes { get; set; }
        public DateTime AnneeDeValidation { get; set; }

        public virtual Demandeurdemploi IdDemandeurDemploiNavigation { get; set; }
        public virtual Diplome IdDuDiplomesNavigation { get; set; }
    }
}
