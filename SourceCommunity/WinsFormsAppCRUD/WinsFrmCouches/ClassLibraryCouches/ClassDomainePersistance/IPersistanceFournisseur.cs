using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinsFormsAppCRUD.ClassLibraryCouches.ClassDomainePersistance
{
    interface IPersistanceFournisseur
    {
       
            //string ConnectionString
            //{
            //    get;
            //    set;
            //}

            int AddFournisseur(sFournisseur Fournisseur);
            bool UpdateFournisseur(sFournisseur Fournisseur);
            bool DeleteFournisseur(sFournisseur Fournisseur);
            sFournisseur GetFournisseur(int id);

        
    }
}
