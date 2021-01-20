using ClassLibraryDomainePersistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSQLServer
{
    public class PersitanceContact : IPersitanceContact
    {
        SqlConnection sqlConnection;

        public PersitanceContact(string _connectionString)
        {
            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = _connectionString;

        }

        public void Open()
        {
            sqlConnection.Open();
        }

        public void Close()
        {
            sqlConnection.Close();
        }

        public bool IsOpen()
        {
            return sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public int AddContact(sContact contact)
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            SqlParameter pOut = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("CreateContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                pOut = new SqlParameter("@id", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(pOut);

                sqlCommand.Parameters.Add(new SqlParameter("@prue_contact", contact.satisfaction));
                sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pnom_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pville_contact", contact.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@pcp_contact", contact.code_postal));
                sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_contact", contact.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_contact", contact.satisfaction));

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    Trace.TraceInformation($"{DateTime.Now} Création du contact {contact.nom}");
                }
                else
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la création du contact {contact.nom}");
                }

            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un contact {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            return (int)pOut.Value;
        }

        public List<int> AddContact(List<sContact> contacts)
        {
            List<int> maListeDeContact = new List<int>();

            try
            {
                foreach (sContact contact in contacts)
                {
                    maListeDeContact.Add(this.AddContact(contact));
                }
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un tableau de contact : {e.Message}");
            }

            Trace.Flush();

            return maListeDeContact;
        }

        public bool DeleteContact(sContact contact)
        {
            bool ok = false;

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", contact.id));

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    ok = true;
                    Trace.TraceInformation($"{DateTime.Now} Suppression du contact {contact.nom}");
                }

            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la supression du contact {contact.nom} {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            return ok;
        }

        public bool UpdateContact(sContact contact)
        {
            bool ok = false;

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", contact.id));
                sqlCommand.Parameters.Add(new SqlParameter("@prue_contact", contact.satisfaction));
                sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pnom_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pville_contact", contact.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@pcp_contact", contact.code_postal));
                sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_contact", contact.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_contact", contact.satisfaction));

                int nbLigneAffecte = sqlCommand.ExecuteNonQuery();
                if (nbLigneAffecte == 1)
                {
                    ok = true;
                }

                Trace.TraceInformation($"{DateTime.Now} Mise à jour du contact {contact.nom}");
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la mise à jour du contact {contact.nom} {e.Message}");
            }

            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            Trace.Flush();

            return ok;
        }

        public sContact GetContact(int id)
        {
            sContact contact = new sContact
            {
                id = -1
            };

            sqlConnection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Contact where id_contact=@pid_contact", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", id));

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                bool ok = false;
                if (sqlDataReader.Read()&& ((int)sqlDataReader["id_contact"]).Equals(id))
                { 
                    contact = new sContact(
                        (int)sqlDataReader["id_contact"],
                       (string)sqlDataReader["rue_contact"],
                        (string)sqlDataReader["num_rue_contact"],
                        (string)sqlDataReader["nom_contact"],
                        (string)sqlDataReader["ville_contact"],
                        (string)sqlDataReader["cp_contact"],
                        (string)sqlDataReader["personne_contact"],
                        (int)sqlDataReader["satisfaction_contact"]);

                    Trace.TraceInformation($"{DateTime.Now} Accès au contact {id}");

                    ok = true;
                }

                if (!ok)
                {
                    Trace.TraceError($"{DateTime.Now} Tentative d'acces à un contact inexistant : {id}");
                }

                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Echec de la tentative d'accès au contact {id} {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }


            return contact;



        }
    }
}
