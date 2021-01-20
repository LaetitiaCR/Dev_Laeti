using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSQLServer
{
   public  interface IPersistanceFournisseur
    {

        //string ConnectionString
        //{
        //    get;
        //    set;
        //}

        //int AddFournisseur(sFournisseur fournisseur);
            bool AddFournisseur(sFournisseur fournisseur);
            
            bool UpdateFournisseur(sFournisseur fournisseur);
            bool DeleteFournisseur(sFournisseur fournisseur);
            sFournisseur GetFournisseur(int id);

        
    }
}
