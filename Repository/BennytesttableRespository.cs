using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
using System;

namespace ASPCoreSample.Repository
{
    public class BennytesttableRespository : IRepository<Bennytesttable>
    {
        private string connectionString;
        public BennytesttableRespository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public IEnumerable<Bennytesttable> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                try
                {
                    dbConnection.Open();
                }
                catch (Exception ex)
                {
                    string a = "";
                }
                return dbConnection.Query<Bennytesttable>("SELECT * FROM bennytesttable");
            }
        }
    }
}
