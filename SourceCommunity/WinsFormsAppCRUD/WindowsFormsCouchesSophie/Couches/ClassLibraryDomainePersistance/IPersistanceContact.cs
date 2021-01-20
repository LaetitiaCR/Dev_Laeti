using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomainePersistance
{

    public interface IPersitanceContact
    {
        //string ConnectionString
        //{
        //    get;
        //    set;
        //}

        int AddContact(sContact contact);
        bool UpdateContact(sContact contact);
        bool DeleteContact(sContact contact);
        sContact GetContact(int id);

    }
}
