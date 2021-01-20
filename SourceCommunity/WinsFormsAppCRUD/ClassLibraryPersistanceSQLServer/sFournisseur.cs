using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSQLServer
{
    public struct sFournisseur
    {
       
            public int id;
            public string nom;
            //public string num_rue;
            public string rue;
            //Mettre le code postale en string dans la base de donnée et changer type variable
            public int code_postal;
            
            public string ville;
            public string personne_contact;
            public int satisfaction;

            public sFournisseur(int id, string nom, string rue, string ville, int code_postal, string personne_contact, int satisfaction)
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
