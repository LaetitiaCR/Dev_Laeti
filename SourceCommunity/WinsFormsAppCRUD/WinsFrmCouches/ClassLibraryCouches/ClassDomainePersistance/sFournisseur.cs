using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinsFormsAppCRUD.ClassLibraryCouches.ClassDomainePersistance
{
    struct sFournisseur
    {
       
            public int id;
            public string nom;
            //public string num_rue;
            public string rue;
            public string code_postal;
            public string ville;
            public string personne_contact;
            public int satisfaction;

            public sFournisseur(int id, string nom, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
            {
                this.id = id;
                this.nom = nom;
                //this.num_rue = num_rue;
                this.rue = rue;
                this.ville = ville;
                this.code_postal = code_postal;
                this.personne_contact = personne_contact;
                this.satisfaction = satisfaction;
            }
        
    }
}
