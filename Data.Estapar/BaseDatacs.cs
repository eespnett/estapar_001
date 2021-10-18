using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEstapar.Data.Estapar
{
   
    public class BaseDatacs
    {

        public string strConnection { get; set; }

        public BaseDatacs()
        {
            strConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Estapar001;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        internal int ExcluirManobra(int idManobrista)
        {
            throw new NotImplementedException();
        }
    }
}
