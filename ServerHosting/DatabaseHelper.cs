using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHosting
{
    class DatabaseHelper
    {
        ////////////


        const string connectionString = "Server=DESKTOP-HDD6KN9\\SQLEXPRESS;" + "Database=AdmissionTestingSystem;Integrated Security = True";
        SqlConnection connection = null;
        public DatabaseHelper()
        {
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Properties for gettting and setting the Connection
        /// </summary>
        public SqlConnection getConnection()
        {
            return this.connection;
        }

        /// <summary>
        /// Function to get the data sql adapter , can be used for filling the datagridView.
        /// </summary>
        /// <param name="query">The user query to get the data</param>
        /// <returns></returns>
        public SqlDataAdapter getSqlDataAdapter(string query)
        {
            return new SqlDataAdapter(query, this.connection);
        }

        /// <summary>
        /// FUnction to get the Sql command for executing the query
        /// </summary>
        /// <param name="query">The user query to get the data</param>
        /// <returns></returns>
        public SqlCommand getSqlCommand(string query)
        {
            return new SqlCommand(query, this.connection);
        }



    }
}


/////////////


