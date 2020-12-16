using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsFormsAppCRUD
{
    public partial class FrmFournisseur2 : Form
    {

        private String nomFour;
        private String adresseFour;
        private String villeFour;
        private int cpFour;
        private String contact;
        private int satisfaction;


        public FrmFournisseur2(String nomFour, String adresseFour, int cpFour, String villeFour, String contact, int satisfaction)
        {
            InitializeComponent();

            this.nomFour = nomFour;
            this.adresseFour = adresseFour;
            this.villeFour = villeFour;
            this.cpFour = cpFour;
            this.contact = contact;
            this.satisfaction = satisfaction;
            
            InsertionChamp(nomFour, adresseFour,  cpFour, villeFour,contact, satisfaction);
        }

        private void InsertionChamp(String nomFour, String adresseFour, int cpFour, String villeFour, String contact, int satisfaction) {
            txtNom.Text = nomFour;
            txtAdresse.Text = adresseFour;
            txtCpVille.Text = cpFour + " " + villeFour;
            txtContact.Text = contact;
            txtSatisfaction.Text = satisfaction.ToString();
        }
        private void FrmFournisseur2_Load(object sender, EventArgs e)
        {

        }

        private void butRetour_Click(object sender, EventArgs e)
        {
            FrmFournisseur2.ActiveForm.Close();
        }
    }
}
