using ClassLibraryPersistanceSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesterCouchePersitance
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["MyHomeServerConnection"].ConnectionString;
            PersistanceFournisseur p = new PersistanceFournisseur(connectionString);
            sFournisseur s = new sFournisseur();
            //p.Addfournisseur(s);
        }
    }
}
