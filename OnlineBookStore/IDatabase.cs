using System;
using System.Collections.Generic;
using System.Data.SqlClient;        //  SqlDataAdapter
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public interface IDatabase
    {
        string SelectCommand();
        SqlDataAdapter Adapter();
        
    }
}
