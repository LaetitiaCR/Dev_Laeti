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
    public partial class FrmFournisseurCmdes : Form
    {

        private SqlConnection sqlConnect;


        private string nomFourni;

        public FrmFournisseurCmdes(string nomFourni)
        {
            InitializeComponent();

            this.nomFourni = nomFourni;
            insertionChamps(nomFourni);
        }

        
        private void FrmFournisseurCmdes_Load(object sender, EventArgs e)
        {

        }


        private void insertionChamps(string nomFourni)
        {
            
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);




            /*
            sqlConnect.Open();

            
            SqlCommand command = new SqlCommand(null, sqlConnect);

            command.CommandText = "SELECT NUMCOM, DATCOM FROM ENTCOM INNER JOIN Fournis ON ENTCOM.NUMFOU = Fournis.NUMFOU  WHERE NOUFOU = @noufou";
            SqlParameter nomfouParam = new SqlParameter("@noufou", SqlDbType.VarChar, 0);

            string param1 = nomFourni;
            nomfouParam.Value = param1;

            command.Parameters.Add(nomfouParam);
           
            command.ExecuteNonQuery();
            
            
            SqlDataReader sqlDataRead = command.ExecuteReader();
            */


            //String strSqlFourni = "SELECT NUMCOM, DATCOM FROM ENTCOM, Fournis WHERE ENTCOM.NUMFOU = Fournis.NUMFOU  AND NOUFOU ='" + nomFourni + "'";

            String strSqlFourni = "SELECT NUMCOM, DATCOM FROM ENTCOM INNER JOIN Fournis ON ENTCOM.NUMFOU = Fournis.NUMFOU  WHERE NOUFOU ='" + nomFourni + "'";
            //String strSqlFourni = "SELECT NUMCOM, DATCOM FROM ENTCOM INNER JOIN Fournis ON ENTCOM.NUMFOU = Fournis.NUMFOU  WHERE NOUFOU = 'Nom du fournisseur 1'";
            SqlCommand command = new SqlCommand(strSqlFourni, sqlConnect);
            command.Connection.Open();


            SqlDataReader sqlDataRead = command.ExecuteReader();
            


         
            if (sqlDataRead.HasRows==true)
            {
                DataTable oDataTable = new DataTable();
                oDataTable.Load(sqlDataRead);
                int nbRows = oDataTable.Rows.Count;


                for (int i = 0; i < nbRows; i++)
                {
                    litBoxCmdeFourni.Items.Add(sqlDataRead.GetInt32(0) + " " + sqlDataRead.GetDateTime(2));
                }
            }
            //while (sqlDataRead.Read())
            //{   
            //    //litBoxCmdeFourni.Items.Add(String.Format("{0}, {1}", (IDataRecord)sqlDataRead[0], (IDataRecord)sqlDataRead[1]));
                

            //}

            
        }

        
    }
}
