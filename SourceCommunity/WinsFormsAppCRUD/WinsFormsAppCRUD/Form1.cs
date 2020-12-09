using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WinsFormsAppCRUD
{
    public partial class Form1 : Form
    {
        // objet ADO.net
        private SqlConnection sqlConnect;

        public string ConnectionString { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sqlConnect.Close();
        }




        private void butConnect_Click(object sender, EventArgs e)
        {

            try
            {

            // accés à la base
            string connectString = "Data Source=DESKTOP-CMNIL4R;InitialCatalog = BDTest; Integrated Security = True";
            sqlConnect = new SqlConnection(connectString);

            // Ouvre la connection.
            
                sqlConnect.Open();
                txtInfo.Text = "Connexion au serveur réussie";
            }
            catch (SqlException se)
            {
                txtInfo.Text = "Erreur de connexion au serveur";
            }
            finally
            {
                sqlConnect.Close();
            }

        }
        

       
    }
}
