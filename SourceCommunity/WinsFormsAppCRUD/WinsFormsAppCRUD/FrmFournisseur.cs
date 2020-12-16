using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinsFormsAppCRUD
{
    public partial class FrmFournisseur : Form
    {
        private SqlConnection sqlConnect;
      
        private SqlDataReader sqlDataRead;



        private int codeF;
        private string nomF;
        private string adresseF;
        private int cpF;
        private string villeF;
        private string contactF;
        private int satisfactionF;

        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void butValider_Click(object sender, EventArgs e)
        {
           
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
            
            
           
            

            try
            {


                sqlConnect.Open();


                SqlCommand command = new SqlCommand(null, sqlConnect);

                command.CommandText = "SELECT * FROM Fournis WHERE NUMFOU = @numfou";
                SqlParameter numfouParam = new SqlParameter("@numfou", SqlDbType.Int, 0);

                int param1 = Int32.Parse(txtCodeFournis.Text);
                numfouParam.Value = param1;

                command.Parameters.Add(numfouParam);

                command.ExecuteNonQuery();

                sqlDataRead = command.ExecuteReader();
                

                while (sqlDataRead.Read())
                {
                    codeF = sqlDataRead.GetInt32(0);

                    nomF = sqlDataRead.GetString(1);

                    adresseF = sqlDataRead.GetString(2);
                    cpF = sqlDataRead.GetInt32(3);
                    villeF = sqlDataRead.GetString(4);

                    contactF = sqlDataRead.GetString(5);
                    satisfactionF = sqlDataRead.GetInt32(6);


                    txtResult.Text = txtResult.Text + codeF + " " + nomF;

                }

                FrmFournisseur2 frmFourni2 = new FrmFournisseur2(nomF, adresseF, cpF, villeF, contactF, satisfactionF);
                frmFourni2.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Connection failled");
            }
        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {

        }

        private void butQuitter_Click(object sender, EventArgs e)
        {
            FrmFournisseur.ActiveForm.Close();
        }
    }
}
