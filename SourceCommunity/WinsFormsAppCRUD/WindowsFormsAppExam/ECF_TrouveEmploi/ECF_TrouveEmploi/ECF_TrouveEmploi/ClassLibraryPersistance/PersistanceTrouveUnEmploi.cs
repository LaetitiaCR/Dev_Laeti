using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public class PersistanceTrouveUnEmploi
    {
        public SqlConnection CommentRecupererConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString= ConfigurationManager.ConnectionStrings["TrouveUnEmploi_BD"].ConnectionString;
            return connexion;
        }

        //public bool Sauvegarder(...)
        //{
  
        // acoder 
        //}
    }
}
