using System;
using System.Collections.Generic;

#nullable disable

namespace GenererModelsDeBDDSQLServer.Models
{
    public partial class Demandeurdemploi
    {
        public long NumSecuriteSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? DateDinscription { get; set; }
    }
}
