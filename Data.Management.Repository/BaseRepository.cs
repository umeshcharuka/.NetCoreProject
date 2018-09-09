using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Management.Repository
{
    public class BaseRepository:IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
    {
        string connectionString = "Data Source=.;Initial Catalog=WEBAPI;Integrated Security=True";
        con = new SqlConnection(connectionString);
    }
    public void Dispose()
    {
        //throw new NotImplementedException();  
    }
}  
}
