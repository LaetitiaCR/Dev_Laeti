using ClassLibraryPersistanceSQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsFrmPourCouches
{
    public partial class FrmFournisseur : Form
    {
        private int id_Fourni;
        private string nom_Fourni;
        private string rue_Fourni;
        private string ville_Fourni;
        private int cp_Fourni;
        private string contact_Fourni;
        private int satisfaction_Fourni;

       
        // private string[] tabEntrerFournisseur;
       // private string[] _tabEntrerFournisseur;


        //private int id; private string nom; private string rue; private string ville; private string code_postal; private string personne_contact; private int satisfaction;
        public FrmFournisseur()
        {
            InitializeComponent();
            // Tableau = new string[6];

        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {


        }

        //private string name = "FirstName, LastName";
        

        //public string GetName()
        //{
          //  return name;
        //}


        private void setEntrerFournisseur(int numFourni, string nomFourni, string rue, string ville,
               int cp, string contact, int satisfaction)
        {
            
            this.id_Fourni = numFourni;
            this.nom_Fourni = nomFourni;
            this.rue_Fourni = rue;
            this.ville_Fourni = ville;
            this.cp_Fourni = cp;
            this.contact_Fourni = contact;
            this.satisfaction_Fourni = satisfaction;

            
        }

        private int getNumF() { return id_Fourni; }
        private string getNomF(){ return nom_Fourni; }
        private string getRueF() { return rue_Fourni; }
        private string getVilleF() { return ville_Fourni; }
        private int getCpF() { return cp_Fourni; }
        private string getContactF() { return contact_Fourni; }
        private int getSatisfactionF() { return satisfaction_Fourni; }

        private void butCreer_Click(object sender, EventArgs e)
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
        }

        private void butRechercher_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            PersistanceFournisseur p = new PersistanceFournisseur(connectionString);
            
            int id = int.Parse(txtBoxNumFourni.Text);
            sFournisseur sFourni = p.GetFournisseur(id);
            txtBoxNomFourni.Text = sFourni.nom;
            txtBoxRue.Text = sFourni.rue;
            txtBoxCP.Text = sFourni.code_postal.ToString();
            txtBoxVille.Text = sFourni.ville;
            txtBoxContact.Text = sFourni.personne_contact;
            txtBoxSatisfaction.Text = sFourni.satisfaction.ToString();

        }
    }
}
