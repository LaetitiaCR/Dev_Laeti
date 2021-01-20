using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinsFormsAppCRUD.ClassLibraryCouches.ClassDomainePersistance;

namespace WinsFormsAppCRUD.ClassLibraryCouches.ClassMetiers
{
    class Fournisseur
    {
            static IPersistanceFournisseur maPersistance;
            public static IPersistanceFournisseur MaPersistance { get => maPersistance; set => maPersistance = value; }

            public int id;
            public string nom;
           // public string num_rue;
            public string rue;
            public string code_postal;
            public string ville;
            
            public string personne_contact;
            public int satisfaction;


            public Fournisseur(int id, string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
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

            public Fournisseur(string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
            {
                this.id = -1;
                this.nom = nom;
                //this.num_rue = num_rue;
                this.rue = rue;
                this.ville = ville;
                this.code_postal = code_postal;
                this.personne_contact = personne_contact;
                this.satisfaction = satisfaction;


            }

            public Fournisseur(sFournisseur sFournisseur) : this(sFournisseur.id, sFournisseur.nom, sFournisseur.num_rue, sFournisseur.rue, sFournisseur.ville, sFournisseur.code_postal, sFournisseur.personne_contact, sFournisseur.satisfaction)
            {
            }

            public Fournisseur(int id)
            {
                sFournisseur structFournisseur = maPersistance.GetFournisseur(id);
                this.nom = structFournisseur.nom;
               // this.num_rue = structFournisseur.num_rue;
                this.rue = structFournisseur.rue;
                this.ville = structFournisseur.ville;
                this.code_postal = structFournisseur.code_postal;
                this.personne_contact = structFournisseur.personne_contact;
                this.satisfaction = structFournisseur.satisfaction;

                this.id = id;

            }


            public bool Save()
            {
                if (this.id == -1)
                {
                    this.id = maPersistance.AddFournisseur(this.GetStruct());
                    return true;
                }
                else
                {
                    return maPersistance.UpdateFournisseur(this.GetStruct());
                }
            }

            public sFournisseur GetStruct()
            {
                sFournisseur structFournisseur = new sFournisseur
                {
                    nom = this.nom,
                    id = this.id,
                   // num_rue = this.num_rue,
                    rue = this.rue,
                    ville = this.ville,
                    code_postal = this.code_postal,
                    personne_contact = this.personne_contact,
                    satisfaction = this.satisfaction
                };

                return structFournisseur;
            }

            public static Fournisseur Load(int id)
            {
                Fournisseur fournisseur = new Fournisseur(id);
                return fournisseur;
            }

            public string Nom { get => nom; set => nom = value; }
            //public string Num_rue { get => num_rue; set => num_rue = value; }
            public string Rue { get => rue; set => rue = value; }
            public string Ville { get => ville; set => ville = value; }
            public string Code_postal { get => code_postal; set => code_postal = value; }
            public string Personne_contact { get => personne_contact; set => personne_contact = value; }
            public int Satisfaction { get => satisfaction; set => satisfaction = value; }
        }
   
}
