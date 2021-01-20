using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSQLServer
{
    class brouillon
    {


        /*


        public bool AddFournisseur(sFournisseur fournisseur)
        {
            bool result = false;
            //bool isAjouter=false;
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            //SqlParameter pOut = null;

            try
            {


                SqlDataAdapter sqlData = new SqlDataAdapter();

                string insertSQL = "INSERT INTO Fournis VALUES(@pid, @pnom_fournisseur, @prue_fournisseur, @pcp_fournisseur, " +
                    "@pville_fournisseur, @ppersonne_fournisseur, @psatisfaction_fournisseur)";
                sqlData.InsertCommand = new SqlCommand(insertSQL, sqlConnection);




                sqlData.InsertCommand.Parameters.Add("@pid", SqlDbType.Int).Value = fournisseur.id;
                sqlData.InsertCommand.Parameters.Add("@pnom_fournisseur", SqlDbType.VarChar).Value = fournisseur.nom;
                sqlData.InsertCommand.Parameters.Add("@prue_fournisseur", SqlDbType.VarChar).Value = fournisseur.rue;
                sqlData.InsertCommand.Parameters.Add("@pville_fournisseur", SqlDbType.Int).Value = fournisseur.ville;
                sqlData.InsertCommand.Parameters.Add("@pcp_fournisseur", SqlDbType.VarChar).Value = fournisseur.code_postal;
                sqlData.InsertCommand.Parameters.Add("@ppersonne_fournisseur", SqlDbType.VarChar).Value = fournisseur.personne_contact;
                sqlData.InsertCommand.Parameters.Add("@psatisfaction_fournisseur", SqlDbType.Int).Value = fournisseur.satisfaction;



                //sqlConnection.Open();
                 sqlData.InsertCommand.ExecuteNonQuery();

                result = true;
                //result = sqlData.InsertCommand.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un contact {e.Message}");
            }
            return result;


        }



        
            private add2Fourni() { 

                StringBuilder stringBuild = new StringBuilder();

                
                sbSP.AppendLine("CREATE PROCEDURE [spInsertADAuthorization] @AD_Account varchar(255),@AD_SID varchar(255)," +
                    "@AD_EmailAddress varchar(255),@DateImported datetime,@Active bit AS BEGIN SET NOCOUNT ON; INSERT INTO AD_Authorization " +
                    "(AD_Account, AD_SID, AD_EmailAddress, DateImported, Active) VALUES (@AD_Account,@AD_SID,@AD_EmailAddress,@DateImported,@Active) END");
                

                stringBuild.AppendLine("CREATE PROCEDURE pro_Fournis_Insert @pid int int, @pnom_fournisseur varchar(45), @prue_fournisseur varchar(45), " +
                    "@pville_fournisseur varchar(45), @pcp_fournisseur int, @ppersonne_fournisseur varchar(45), @psatisfaction_fournisseur int" +
                    "AS " +
                    "INSERT INTO Fournis (NUMFOU, NOUFOU, RUEFOU, POSFOU, VILFOU, CONFOU, SATISF) " +
                    " VALUES(@pid, @pnom_fournisseur, @prue_fournisseur, @pcp_fournisseur, @pville_fournisseur, @ppersonne_fournisseur," +
                    " @psatisfaction_fournisseur");


                SqlCommand sqlCommand = new SqlCommand(stringBuild.ToString(), sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //  SqlDataAdapter adapter = new SqlDataAdapter();

                
                create procedure usp_test
                     @p1 char(10) = 'foo',
                     @p2 int = 42
                    as
                    select @p1, @p2;
                     go
                

                                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Fournis (NUMFOU, NOUFOU, RUEFOU, POSFOU, VILFOU, CONFOU, SATISF) " +
                    " VALUES(@id, @pnom_fournisseur, @prue_fournisseur, @pcp_fournisseur, @pville_fournisseur, @ppersonne_fournisseur, @psatisfaction_fournisseur)", sqlConnection);

                sqlCommand.CommandType = CommandType.Text;
                


                sqlCommand.Parameters.Add(new SqlParameter("p@id", fournisseur.id));


                sqlCommand.Parameters.Add(new SqlParameter("@pnom_fournisseur", fournisseur.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@prue_fournisseur", fournisseur.rue));

                //sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", fournisseur.num_rue));

                sqlCommand.Parameters.Add(new SqlParameter("@pville_fournisseur", fournisseur.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@pcp_fournisseur", fournisseur.code_postal));
                sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_fournisseur", fournisseur.personne_contact));
                sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_fournisseur", fournisseur.satisfaction));



                result = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
              


                //command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
                //command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");

                // adapter.InsertCommand = sqlCommand;



                

                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE [spInsertADAuthorization] @AD_Account varchar(255),@AD_SID varchar(255),@AD_EmailAddress varchar(255)," +
                    "@DateImported datetime,@Active bit AS BEGIN SET NOCOUNT ON; " +
                    "INSERT INTO AD_Authorization (AD_Account, AD_SID, AD_EmailAddress, DateImported, Active) " +
                    "VALUES (@AD_Account,@AD_SID,@AD_EmailAddress,@DateImported,@Active) END");

                


                //SqlCommand sqlCommand = new SqlCommand(sbSP.ToString(), sqlConnection);

                StringBuilder stringBuild = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE[Fournis_Insert]@id int, @pnom_fournisseur string, @prue_fournisseur string, @pville_fournisseur string, "+
                    "@pcp_fournisseur int, @ppersonne_fournisseur string, @psatisfaction_fournisseur int AS " +
                    "INSERT INTO[dbo].[Fournis] (NUMFOU, NOUFOU, RUEFOU, POSFOU, VILFOU, CONFOU, SATISF) " +
                    " VALUES(@id, @pnom_fournisseur, @prue_fournisseur, @pcp_fournisseur, @pville_fournisseur, @ppersonne_fournisseur, @psatisfaction_fournisseur)";


                SqlCommand sqlCommand = new SqlCommand(stringBuild.ToString(), sqlConnection);
                

                //sqlCommand.CommandType = CommandType.StoredProcedure;


                

                SqlParameter numfouParam = new SqlParameter("@numfou", SqlDbType.Int, 0);

                int param1 = Int32.Parse(txtBoxNumFourni.Text);

                numfouParam.Value = param1;

                command.Parameters.Add(numfouParam);
                

                //pOut = new SqlParameter("@id", SqlDbType.Int);
                //pOut.Direction = ParameterDirection.Output;
                //sqlCommand.Parameters.Add(pOut);


                // SqlCommand command = new SqlCommand(commandText, connection);
                //command.Parameters.Add("@ID", SqlDbType.Int);
                // command.Parameters["@ID"].Value = customerID;

                
                sqlCommand.Parameters.Add(new SqlParameter("@id", fournisseur.id));


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
                    isAjouter = true;
                }
                else
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la création du contact {fournisseur.nom}");
                    isAjouter= false;
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
                
                // return (int)pOut.Value;
                //return isAjouter;
            }

            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un contact {e.Message}");
            }
            return result;
        }


        
        public int AddFournisseur(sFournisseur fournisseur)
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


               // SqlCommand command = new SqlCommand(commandText, connection);
                //command.Parameters.Add("@ID", SqlDbType.Int);
               // command.Parameters["@ID"].Value = customerID;


                //sqlCommand.Parameters.Add(new SqlParameter("@id", fournisseur.id));


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
        */
    }
}
