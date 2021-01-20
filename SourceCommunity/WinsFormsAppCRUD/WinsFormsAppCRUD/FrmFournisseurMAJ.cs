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
    public partial class FrmFournisseurMAJ : Form
    {
        private SqlConnection sqlConnect;

        private SqlDataReader sqlDataRead;
        private bool multilignes;
      
        public FrmFournisseurMAJ()
        {
            InitializeComponent();

            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
        }

        private void butRechercher_Click(object sender, EventArgs e)
        {
            rechercherFournisseur();
        }


        private void rechercherFournisseur()
        {

            try
            {

                sqlConnect.Open();


                SqlCommand command = new SqlCommand(null, sqlConnect);

                command.CommandText = "SELECT * FROM Fournis WHERE NUMFOU = @numfou";
                SqlParameter numfouParam = new SqlParameter("@numfou", SqlDbType.Int, 0);

                int param1 = Int32.Parse(txtBoxNumFourni.Text);
           
                numfouParam.Value = param1;

                command.Parameters.Add(numfouParam);

                command.ExecuteNonQuery();

                sqlDataRead = command.ExecuteReader();


                while (sqlDataRead.Read())
                {
                    //codeF = sqlDataRead.GetInt32(0);
                    
                    txtBoxNomFourni.Text = sqlDataRead.GetString(1);

                    txtBoxRue.Text = sqlDataRead.GetString(2);
                  
                    txtBoxCP.Text = sqlDataRead.GetInt32(3).ToString();
                    txtBoxVille.Text = sqlDataRead.GetString(4);

                    txtBoxContact.Text = sqlDataRead.GetString(5);
                    txtBoxSatisfaction.Text = sqlDataRead.GetInt32(6).ToString();
                }

                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Connection failled");
            }
        }

        private void butCreer_Click(object sender, EventArgs e)
        {
            bool fourniExiste = FournisseurExiste();
            if(fourniExiste==false) {

                if (txtBoxNomFourni.Text == "" && txtBoxRue.Text == "" && txtBoxCP.Text == "" && txtBoxVille.Text == "" && txtBoxContact.Text == "" && txtBoxSatisfaction.Text == "") 
                {
                    MessageBox.Show("Entrer les champs à insérer concernant le fournisseur");
                }
                else
                {
                    AjoutFournisseur(txtBoxNumFourni.Text, txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxCP.Text, txtBoxVille.Text, txtBoxContact.Text, txtBoxSatisfaction.Text);
                }
            }
        }


        private void AjoutFournisseur(string numFourni, string nomFourni, string rueFourni, string cpFourni, string villeFourni, string contactFourni, string satisfactionFourni)
        {
            //numFourni
            //nomFourni
            //rueFourni
            //cpFourni
            //villeFourni
            //contactFourni
            //satisfactionFourni

            sqlConnect.Open();

            string strsql = "insert into Fournis values (" + int.Parse(numFourni) + ", '" + nomFourni + "', '" + rueFourni + "', " + int.Parse(cpFourni) + ", '" + villeFourni + "', '" + contactFourni + "', " + int.Parse(satisfactionFourni) + ")";
          
            SqlCommand command = new SqlCommand(strsql, sqlConnect);

            sqlDataRead = command.ExecuteReader();

            MessageBox.Show("Le fournisseur a été ajouté à la base");

            sqlConnect.Close();
        }

        private bool FournisseurExiste()
        {
            try
            {
                sqlConnect.Open();

                SqlCommand command = new SqlCommand(null, sqlConnect);

                command.CommandText = "SELECT * FROM Fournis WHERE NUMFOU = @numfou";
                SqlParameter numfouParam = new SqlParameter("@numfou", SqlDbType.Int, 0);

                int param1 = Int32.Parse(txtBoxNumFourni.Text);

                numfouParam.Value = param1;

                command.Parameters.Add(numfouParam);

                command.ExecuteNonQuery();

                sqlDataRead = command.ExecuteReader();


                if (sqlDataRead.HasRows)
                {
                    multilignes = true;
                }

                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Connection failled");
            }

            return (multilignes == true) ? true : false;

        }

        private void butModifier_Click(object sender, EventArgs e)
        {
            ModifierFournisseur(txtBoxNumFourni.Text, txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxCP.Text, txtBoxVille.Text, txtBoxContact.Text, txtBoxSatisfaction.Text);
        }

        private void ModifierFournisseur(string numFourni, string nomFourni, string rueFourni, string cpFourni, string villeFourni, string contactFourni, string satisfactionFourni)
        {
            sqlConnect.Open();

            string strsql = "UPDATE Fournis SET NOUFOU = '" + nomFourni + "', RUEFOU = '" + rueFourni + "', POSFOU = " + int.Parse(cpFourni) + ", VILFOU = '" + villeFourni + "', CONFOU = '" + contactFourni + "', SATISF = " + int.Parse(satisfactionFourni) +
            "where NUMFOU =" + int.Parse(numFourni) ;

            SqlCommand command = new SqlCommand(strsql, sqlConnect);

            sqlDataRead = command.ExecuteReader();

            MessageBox.Show("Le fournisseur a été modifié de la base");

            sqlConnect.Close();
        }

        private void butSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerFournisseur(txtBoxNumFourni.Text, txtBoxNomFourni.Text, txtBoxRue.Text, txtBoxCP.Text, txtBoxVille.Text, txtBoxContact.Text, txtBoxSatisfaction.Text);
            txtBoxNumFourni.Text = ""; txtBoxNomFourni.Text = ""; txtBoxRue.Text = ""; txtBoxCP.Text = ""; txtBoxVille.Text = ""; txtBoxContact.Text = ""; txtBoxSatisfaction.Text = "";
        }

        private void SupprimerFournisseur(string numFourni, string nomFourni, string rueFourni, string cpFourni, string villeFourni, string contactFourni, string satisfactionFourni)
        {
            sqlConnect.Open();

            string strsql = "DELETE FROM Fournis WHERE NUMFOU =" + int.Parse(numFourni);
           
            SqlCommand command = new SqlCommand(strsql, sqlConnect);

            sqlDataRead = command.ExecuteReader();

            MessageBox.Show("Le fournisseur a été supprimer de la base");

            sqlConnect.Close();
        }

        private void FrmFournisseurMAJ_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxNumFourni_TextChanged(object sender, EventArgs e)
        {
            if (VerifieLongueurNumFournisseur(this.txtBoxNumFourni.Text))
            {
                if (VerifieLeFormatNumFournisseur(this.txtBoxNumFourni.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(this.txtBoxNumFourni, "un entier est attendu");
                }


            }
            
        }

        private bool VerifieLongueurNumFournisseur(String longTexteAverifier)
        {
            
            if(longTexteAverifier.Length>0 && longTexteAverifier.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
   
        }

        private  bool VerifieLeFormatNumFournisseur(string typeTexteAVerifier)
        {
            try
            {
                int.Parse(typeTexteAVerifier);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtBoxNomFourni_TextChanged(object sender, EventArgs e)
        {
            if (VerifieLongueurNomFournisseur(this.txtBoxNomFourni.Text))
            {
                
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtBoxNomFourni, "une chaine est attendu");
            }


            
        }

        private bool VerifieLongueurNomFournisseur(String longTexteAverifier)
        {
            //string.IsNullOrEmpty(longTexteAverifier)
            if (longTexteAverifier.Length > 0 && longTexteAverifier.Length < 45)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
