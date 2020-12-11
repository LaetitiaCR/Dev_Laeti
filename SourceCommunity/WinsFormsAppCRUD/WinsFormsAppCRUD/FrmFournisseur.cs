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
        private SqlCommand sqlCde;
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
            //string queryString = "SELECT * FROM Fournis;";
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
            
           // sqlCde = new SqlCommand(queryString, sqlConnect);
            
           
            

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

                FrmFournisseur2 frmFour2 = new FrmFournisseur2(nomF, adresseF, cpF, villeF, contactF, satisfactionF);
                frmFour2.Show();



                //sqlCde = new SqlCommand();
                //sqlCde.Connection = sqlConnect;
                //Constitution Requête SQL
                //string strSql = "Select * from Fournis";
                //Positionnement des propriétés
                //sqlCde.CommandType = CommandType.Text;
                //sqlCde.CommandText = strSql;
                //Exécution de la commande
                //sqlRdr = sqlCde.ExecuteReader();


                //Lecture des données du DataReader
                //while (sqlRdr.Read())
                //{
                //    int codeF = sqlRdr.GetInt16(0);

                //    string nomF = sqlRdr.GetString(1);

                //    txtResult.Text = txtResult.Text + codeF + " " + nomF;

                //}
                // Fin des données
                //sqlRdr.Close();
            }
            catch (Exception ex)
            {
                txtResult.Text = "Failled";
            }
        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
