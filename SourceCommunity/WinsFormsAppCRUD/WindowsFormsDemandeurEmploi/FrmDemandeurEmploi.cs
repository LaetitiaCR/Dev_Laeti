using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemandeurEmploi
{
    public partial class FrmDemandeurEmploi : Form
    {
        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void FrmDemandeurEmploi_Load(object sender, EventArgs e)
        {

        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            
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

        private void butAjouter_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["TrouveUnEmploi_BD"].ConnectionString;
            DemandeurEmploi demEmpl = new DemandeurEmploi(connectionString);
        }

        private void lblnumSS_Click(object sender, EventArgs e)
        {

        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprenom_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
