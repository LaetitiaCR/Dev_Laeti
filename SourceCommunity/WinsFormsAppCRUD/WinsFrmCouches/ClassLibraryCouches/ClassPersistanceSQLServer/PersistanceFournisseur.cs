using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinsFormsAppCRUD.ClassLibraryCouches.ClassDomainePersistance;

namespace WinsFormsAppCRUD.ClassLibraryCouches.ClassPersistanceSQLServer
{
    class PersistanceFournisseur : IPersistanceFournisseur
    {
            SqlConnection sqlConnection;

            public PersistanceFournisseur(string _connectionString)
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

            public int AddFournisseur(sFournisseur Fournisseur)
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
                    
                    sqlCommand.Parameters.Add(new SqlParameter("@pnom_fournisseur", fournisseur.nom));
                    sqlCommand.Parameters.Add(new SqlParameter("@prue_fournisseur", fournisseur.rue));

                    //sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", fournisseur.num_rue));
                    
                    sqlCommand.Parameters.Add(new SqlParameter("@pville_fournisseur", fournisseur.ville));
                    sqlCommand.Parameters.Add(new SqlParameter("@pcp_fournisseur", fournisseur.code_postal));
                    sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_fournisseur", fournisseur.personne_contact));
                    sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_fournisseur", fournisseur.satisfaction));
                    
                    

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        Trace.TraceInformation($"{DateTime.Now} Création du contact {fournisseur.nom}");
                    }
                    else
                    {
                        Trace.TraceError($"{DateTime.Now} Execution échouée de la création du contact {fournisseur.nom}");
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

            public List<int> Addfournisseur(List<sfournisseur> fournisseurs)
            {
                List<int> maListeDeFournisseur = new List<int>();

                try
                {
                    foreach (sfournisseur contact in fournisseurs)
                    {
                        maListeDeFournisseur.Add(this.AddFournisseur(contact));
                    }
                }
                catch (Exception e)
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un tableau de contact : {e.Message}");
                }

                Trace.Flush();

                return maListeDeFournisseur;
            }

            public bool DeleteFournisseur(sfournisseur fournisseur)
            {
                bool ok = false;

                if (sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand("DeleteFournisseur", sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", fournisseur.id));

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        ok = true;
                        Trace.TraceInformation($"{DateTime.Now} Suppression du contact {fournisseur.nom}");
                    }

                }
                catch (Exception e)
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la supression du contact {fournisseur.nom} {e.Message}");
                }

                Trace.Flush();

                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
                return ok;
            }

            public bool UpdateFournisseur(sfournisseur fournisseur)
            {
                bool ok = false;

                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand("UpdateFournisseur", sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@pid_fournisseur", fournisseur.id));
                    sqlCommand.Parameters.Add(new SqlParameter("@pnom_fournisseur", fournisseur.nom));
                    sqlCommand.Parameters.Add(new SqlParameter("@prue_fournisseur", fournisseur.rue));
                    //sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", fournisseur.num_rue));
                   
                    sqlCommand.Parameters.Add(new SqlParameter("@pville_fournisseur", fournisseur.ville));
                    sqlCommand.Parameters.Add(new SqlParameter("@pcp_fournisseur", fournisseur.code_postal));
                    sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_contact", fournisseur.personne_contact));
                    sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction", fournisseur.satisfaction));
                    

                    int nbLigneAffecte = sqlCommand.ExecuteNonQuery();
                    if (nbLigneAffecte == 1)
                    {
                        ok = true;
                    }

                    Trace.TraceInformation($"{DateTime.Now} Mise à jour du contact {fournisseur.nom}");
                }
                catch (Exception e)
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la mise à jour du contact {fournisseur.nom} {e.Message}");
                }

                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }

                Trace.Flush();

                return ok;
            }

            public sfournisseur GetFournisseur(int id)
            {
                sfournisseur fournisseur = new sfournisseur
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
                    if (sqlDataReader.Read() && ((int)sqlDataReader["id_contact"]).Equals(id))
                    {
                            fournisseur = new sfournisseur(
                            (int)sqlDataReader["NUMFOU"],
                            (string)sqlDataReader["NOUFOU"],
                           (string)sqlDataReader["RUEFOU"],
                            //(string)sqlDataReader["num_rue_contact"],          
                            (string)sqlDataReader["POSFOU"],
                            (string)sqlDataReader["VILFOU"],
                            (string)sqlDataReader["CONFOU"],
                            (int)sqlDataReader["SATISF"]);

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


                return fournisseur;



            }

        public bool UpdateFournisseur(sFournisseur Fournisseur)
        {
            //Fournisseur.code_postal
            throw new NotImplementedException();
        }

        public bool DeleteFournisseur(sFournisseur Fournisseur)
        {
            throw new NotImplementedException();
        }

        sFournisseur IPersistanceFournisseur.GetFournisseur(int id)
        {
            throw new NotImplementedException();
        }
    }
    
}
