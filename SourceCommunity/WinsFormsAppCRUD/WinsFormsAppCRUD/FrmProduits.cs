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
    public partial class FrmProduits : Form
    {
        private SqlConnection sqlConnect;

        private SqlDataReader sqlDataRead;

        private SqlCommand command;

        private Tuple<int, string> tupleListeProd;


        public FrmProduits()
        {
            InitializeComponent();

            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {

            try
            {

                sqlConnect.Open();

                string strSqlProd = "SELECT * FROM Produits";

                command = new SqlCommand(strSqlProd, sqlConnect);

                SqlDataReader sqlDataRead = command.ExecuteReader();

                listBoxProduits.Text = "Liste des produits";



                while (sqlDataRead.Read())
                {
                    tupleListeProd = new Tuple<int, string>(sqlDataRead.GetInt32(0), sqlDataRead.GetString(1));

                    listBoxProduits.Items.Add(sqlDataRead.GetString(1));


                }

                sqlConnect.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                // "Failled";
            }


        }

        private void listBoxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect.Open();



            SqlCommand command = new SqlCommand(null, sqlConnect);

            command.CommandText = "SELECT * from Produits WHERE CODART = @numProd AND LIBART = @libProd";

            SqlParameter numProd = new SqlParameter("@numProd", SqlDbType.Int, 0);
            SqlParameter libProd = new SqlParameter("@libProd", SqlDbType.VarChar, 45);


            int param1 = tupleListeProd.Item1;
            string param2 = tupleListeProd.Item2.ToString();

            numProd.Value = param1;
            libProd.Value = param2;

            command.Parameters.Add(numProd);
            command.Parameters.Add(libProd);

            sqlDataRead = command.ExecuteReader();


            while (sqlDataRead.Read())
            {
                //listBoxProduits.Items.Add(sqlDataRead.GetInt32(0) + " " + sqlDataRead.GetDateTime(1).ToString("MM/dd/yyyy"));
                txtBoxCode.Text = sqlDataRead.GetInt32(0).ToString();
                txtBoxLibelle.Text = sqlDataRead.GetString(1);
                txtBoxStockAlerte = sqlDataRead.GetString(2);
                txtBoxStockPhysique = sqlDataRead.GetString(3);
                txtBoxQte = sqlDataRead.GetInt32(4).ToString();
                txtBoxUniteMesure = sqlDataRead.GetString(5);
            }


            sqlConnect.Close();
        }
    }
}
