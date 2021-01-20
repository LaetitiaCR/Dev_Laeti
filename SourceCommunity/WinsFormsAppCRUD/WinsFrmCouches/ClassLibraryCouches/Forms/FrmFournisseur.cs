using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsFormsAppCRUD.ClassLibraryCouches.Forms
{
    public partial class FrmFournisseur : Form
    {
        public FrmFournisseur()
        {
            InitializeComponent();
            sFournisseur sFourni = new sFournisseur(txtBoxNumFourni.Text, txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxVille.Text, txtBoxCP.Text, txtBoxContact.Text, txtBoxSatisfaction.Text);
        }

        private void butRechercher_Click(object sender, EventArgs e)
        {

        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
