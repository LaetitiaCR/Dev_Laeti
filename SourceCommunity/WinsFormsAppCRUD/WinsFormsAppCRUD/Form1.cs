using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using System.Data.SqlClient;

namespace WinsFormsAppCRUD
{
    public partial class Form1 : Form
    {
        // objet ADO.net
        //private SqlConnection sqlConnection;
        private String serverName;
        private SqlConnection connection;

        private String baseDonneesName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings chaineConnexion = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"];

            //Console.WriteLine(chaineConnexion.Name);
            //Console.WriteLine(chaineConnexion.ConnectionString);
            //Console.WriteLine(chaineConnexion.ProviderName);

          
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            
            try
            {    
                connection.Open();


                SqlConnectionStringBuilder builder =
                    new SqlConnectionStringBuilder(connectionString);

                builder.ConnectionString = connectionString;
                serverName = (string)builder["Server"];
                baseDonneesName = (string)builder["Initial Catalog"];
                txtServeur.Text = serverName;
                txtBdd.Text = baseDonneesName;
                txtInfo.Text = "Open";  

            }
            catch (SqlException)
            {
                txtInfo.Text = "Message : Impossible d'ouvrir la base dee donnéées "
                    + baseDonneesName + "demandée par la connexion. La connexion a échoué. Echec de l'ouverture de session de l'utilisateur  " 
                    + serverName;
            }
            finally
            {
                //connection.Close();
            }
                    
        }

        private void butDeconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            txtServeur.Text = "";
            txtBdd.Text = "";
            txtInfo.Text = "La connection a été fermée";
        }
    }
}
