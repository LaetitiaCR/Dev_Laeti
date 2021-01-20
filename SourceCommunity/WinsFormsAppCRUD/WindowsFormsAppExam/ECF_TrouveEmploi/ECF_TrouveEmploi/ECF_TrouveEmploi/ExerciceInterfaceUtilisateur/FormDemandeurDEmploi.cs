using ClassLibraryMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceInterfaceUtilisateur
{
    public partial class FormDemandeurDEmploi : Form
    {
        DemandeurDEmploi unDemandeurDEmploi;
        public DemandeurDEmploi UnDemandeurDEmploi { get => unDemandeurDEmploi; }

        public FormDemandeurDEmploi(string prenom, ulong numSS, DateTime dateInscription, string diplome)
        {
            InitializeComponent();

           // le nom
           // -le prénom,
           // -le numéro de sécurité social
            //-la date d’inscription à TrouveEmploi
            //- les diplômes avec le niveau de formation correspondant(InfBac, Bac, Bac + 1, Bac + 2, Bac + 3, Bac + 4, Bac + 5, SupBac + 5) et leurs années de validation

            // acoder
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            PersistanceFournisseur p = new PersistanceFournisseur(connectionString);
            // setEntrerFournisseur(int.Parse(txtBoxNumFourni.Text), txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxVille.Text,
            // int.Parse(txtBoxCP.Text), txtBoxContact.Text, int.Parse(txtBoxSatisfaction.Text));

            //(int id, string nom, string rue, string ville, int code_postal, string personne_contact, int satisfaction)
            //sFournisseur s = new sFournisseur(getNumF(), getNomF(), getRueF(), getVilleF(), getCpF(), getContactF(), getSatisfactionF());
            sFournisseur s = new sFournisseur(int.Parse(txtBoxNumFourni.Text), txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxVille.Text,
              int.Parse(txtBoxCP.Text), txtBoxContact.Text, int.Parse(txtBoxSatisfaction.Text));

            //(id, nom, rue, ville, code_postal, personne_contact, satisfaction);

            p.AddFournisseur(s);
            // acoder
        }

        

        
    }
}
