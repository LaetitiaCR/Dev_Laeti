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
        private SqlConnection sqlConnection;

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

            SqlConnection connection;
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);

            try
            {    
                connection.Open();
                string textSearched1 = "Data Source=";
                string textAfter1;
                textAfter1 = connectionString.Split(new string[] { textSearched1 }, StringSplitOptions.None).Last();
                int longChaineASoustraire1;
                longChaineASoustraire1 = connectionString.Length - textAfter1.Length;
                string serveurName = textAfter1.Substring(0, longChaineASoustraire1+3);




                //string textSearched1 = "Data Source=";
                string textSearched2 = "Initial Catalog =";
                //string textAfter2;
                //String textSearched3 = "Integrated Security = true";
                //textBefore2 = connectionString.Split(new string[] { textSearched2 }, StringSplitOptions.None));
                // textAfter2 = connectionString.Split(new string[] { textSearched2 }, StringSplitOptions.None).Last();
                //textAfter3 = connectionString.Split(new string[] { textSearched3 }, StringSplitOptions.None).Last();

                //int longChaineASoustraire2;
                //longChaineASoustraire2 = (connectionString.Length- textAfter2.Length) - (connectionString.Length- textAfter3.Length);

                //String posdeb = textAfter2.Substring(0, connectionString.Length- textAfter3.Length-textSearched3.Length);
                //String posdeb = textAfter2.Substring(0, textAfter2.Length - textSearched2.Length);
                int posdeb = textSearched1.Length + serveurName.Length + textSearched2.Length;
                String bddName = connectionString.Substring(posdeb+1, connectionString.Length-27-posdeb);

                // string baseName = textAfter2.Substring(0, longChaineASoustraire2 + 3);

                // string textBefore = connectionString.Split(new string[] { textSearched2 }, StringSplitOptions.None).Last();

                // int position = connectionString.IndexOf(";")

                txtServeur.Text = serveurName ;
                txtBdd.Text = bddName;
                txtInfo.Text = "Connexion au serveur réussie";  

            }
            catch (SqlException)
            {
                txtInfo.Text = "Erreur de connexion au serveur";
            }
            finally
            {
                //connection.Close();
            }
                    
        }
    }
}
