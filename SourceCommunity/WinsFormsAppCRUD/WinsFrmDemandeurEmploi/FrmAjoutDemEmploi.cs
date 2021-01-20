using ClassLibraryPersistanceExam;
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

namespace WinsFrmDemandeurEmploi
{
    public partial class FrmAjoutDemEmploi : Form
    {
        public FrmAjoutDemEmploi()
        {
            InitializeComponent();
        }

        private void butAjouter_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["TrouveUnEmploi_BD"].ConnectionString;
            DemandeurEmploi demEmpl = new DemandeurEmploi(connectionString);
            sDemandeurEmploi sDemEmpl = new sDemandeurEmploi(ulong.Parse(txtsecu.Text), txtnom.Text, txtprenom.Text, DateTime.Parse(txtdate.Text));

            demEmpl.AddDemandeurEmploi(sDemEmpl);
            
        }

        private void txtsecu_TextChanged(object sender, EventArgs e)
        {
             if (int.Parse(txtsecu.Text.Substring(0, 1)) > 1)
            {
                MessageBox.Show("numéro de sécurité sociale non valide");
            }

           
        }
    }
}
