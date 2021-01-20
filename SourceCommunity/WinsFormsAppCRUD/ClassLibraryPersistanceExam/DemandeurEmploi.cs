using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace ClassLibraryPersistanceExam
{
    public class DemandeurEmploi : IDemandeurEmploi
    {

        

        SqlConnection sqlConnection;

        public DemandeurEmploi(string _connectionString)
        {
             
            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = _connectionString;

        }



        public bool AddDemandeurEmploi(sDemandeurEmploi demandeurEmploi)
        {
            bool estAjouter = false;

            
                
            


            try
            {

                sqlConnection.Open();


                SqlCommand sqlCommand = new SqlCommand("ProcedureInsertFournisseur", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;


                sqlCommand.Parameters.Add(new SqlParameter("@pnumSS", demandeurEmploi.numSS));
                sqlCommand.Parameters.Add(new SqlParameter("@pnom", demandeurEmploi.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@pprenom", demandeurEmploi.prenom));
                sqlCommand.Parameters.Add(new SqlParameter("@pdateinscription", demandeurEmploi.dateInscription));




                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    
                    estAjouter = true;
                }
                else
                {
                 
                    estAjouter = false;
                }


                sqlConnection.Close();

            }
            catch (Exception e)
            {

                estAjouter = false;
            }

       

           
                
            

            return estAjouter;
        }

       
         
    }
}
