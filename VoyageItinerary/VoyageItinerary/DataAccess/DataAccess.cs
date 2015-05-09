using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace VoyageItinerary.DataAccess
{
    public class DataAccess
    {
        public DataSet ExecuteDataSet(string StoredProcedure)
        {
            DataSet myDs = new DataSet();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostGreSql"].ConnectionString);

            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(StoredProcedure,conn);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                da.Fill(myDs);
                return myDs;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}