using ClassLibraryDomainePersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetierProducts
{
    public class Contact
    {
        static  IPersitanceContact maPersistance;
        public static IPersitanceContact MaPersistance { get => maPersistance; set => maPersistance = value; }

        public int id;
        public string nom;
        public string num_rue;
        public string rue;
        public string ville;
        public string code_postal;
        public string personne_contact;
        public int satisfaction;


        public Contact(int id, string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
        {
            this.id = id;
            this.nom = nom;
            this.num_rue = num_rue;
            this.rue = rue;
            this.ville = ville;
            this.code_postal = code_postal;
            this.personne_contact = personne_contact;
            this.satisfaction = satisfaction;


        }

        public Contact(string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
        {
            this.id = -1;
            this.nom = nom;
            this.num_rue = num_rue;
            this.rue = rue;
            this.ville = ville;
            this.code_postal = code_postal;
            this.personne_contact = personne_contact;
            this.satisfaction = satisfaction;


        }

        public Contact(sContact sContact) : this(sContact.id, sContact.nom, sContact.num_rue, sContact.rue, sContact.ville, sContact.code_postal, sContact.personne_contact, sContact.satisfaction)
        {
        }

        public Contact(int id)
        {
            sContact structContact = maPersistance.GetContact(id);
            this.nom = structContact.nom;
            this.num_rue = structContact.num_rue;
            this.rue = structContact.rue;
            this.ville = structContact.ville;
            this.code_postal = structContact.code_postal;
            this.personne_contact = structContact.personne_contact;
            this.satisfaction = structContact.satisfaction;

            this.id = id;

        }


        public bool Save()
        {
            if (this.id == -1)
            {
                this.id = maPersistance.AddContact(this.GetStruct());
                return true;
            }
            else
            {
                return maPersistance.UpdateContact(this.GetStruct());
            }
        }

        public sContact GetStruct()
        {
            sContact structContact = new sContact
            {
                nom = this.nom,
                id = this.id,
                num_rue = this.num_rue,
                rue = this.rue,
                ville = this.ville,
                code_postal = this.code_postal,
                personne_contact = this.personne_contact,
                satisfaction = this.satisfaction
            };

            return structContact;
        }

        public static Contact Load(int id)
        {
            Contact contact = new Contact(id);
            return contact;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Num_rue { get => num_rue; set => num_rue = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Code_postal { get => code_postal; set => code_postal = value; }
        public string Personne_contact { get => personne_contact; set => personne_contact = value; }
        public int Satisfaction { get => satisfaction; set => satisfaction = value; }
    }
}
