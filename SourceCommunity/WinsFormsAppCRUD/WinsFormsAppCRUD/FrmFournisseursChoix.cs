using Microsoft.SqlServer.Server;
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
    public partial class FrmFournisseursChoix : Form
    {

        private SqlConnection sqlConnect;
        private string strSqlFourni;
        private ConnectionStringSettings chaineConnexion;
        private String connectionString;
        private SqlDataReader sqlDataRead;
        private SqlCommand command;
        private Tuple<int, string> tupleListeFourni;


        public FrmFournisseursChoix()
        {
            InitializeComponent();
            chaineConnexion = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"];


            connectionString =
            ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
          
        }

        private void butQuitter_Click(object sender, EventArgs e)
        {
            FrmFournisseursChoix.ActiveForm.Close();
        }


        private void FrmFournisseursChoix_Load(object sender, EventArgs e)
        {


            try
            {

                sqlConnect.Open();

                strSqlFourni = "SELECT * FROM Fournis";

                command = new SqlCommand(strSqlFourni, sqlConnect);

                SqlDataReader sqlDataRead = command.ExecuteReader();

                comboBoxFourni.Text = "Liste de nom de fournisseurs";

                

                while (sqlDataRead.Read())
                {
                    tupleListeFourni = new Tuple<int, string>(sqlDataRead.GetInt32(0), sqlDataRead.GetString(1));

                    comboBoxFourni.Items.Add(sqlDataRead.GetInt32(0) + " " + sqlDataRead.GetString(1));

                    
                }

                sqlConnect.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                // "Failled";
            }

            

        }



        private void comboboxFourni_selectedValueChanged(object sender, EventArgs e)
        {
           


            try
            {
                sqlConnect.Open();



                SqlCommand command = new SqlCommand(null, sqlConnect);

                command.CommandText = "SELECT NUMCOM, DATCOM FROM ENTCOM, Fournis WHERE ENTCOM.NUMFOU = Fournis.NUMFOU  AND Fournis.NUMFOU = @numfou AND NOUFOU=@nomfou";

                SqlParameter numfouParam = new SqlParameter("@numfou", SqlDbType.Int, 0);
                SqlParameter nomfouParam = new SqlParameter("@nomfou", SqlDbType.VarChar, 45);

                
                int param1 = tupleListeFourni.Item1;
                string param2 = tupleListeFourni.Item2.ToString();

                numfouParam.Value = param1;
                nomfouParam.Value = param2;
                
                command.Parameters.Add(numfouParam);
                command.Parameters.Add(nomfouParam);

                sqlDataRead = command.ExecuteReader();

                

                while (sqlDataRead.Read())
                {
                   listBoxFourni.Items.Add(sqlDataRead.GetInt32(0) + " " + sqlDataRead.GetDateTime(1).ToString("MM/dd/yyyy"));
                }


                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void comboBoxFourni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
