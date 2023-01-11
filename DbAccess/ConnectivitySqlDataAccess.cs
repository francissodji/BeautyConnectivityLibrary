

using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ConnectivityLibrary.DbAccess
{

    public class ConnectivitySqlDataAccess : IConnectivitySqlDataAccess
    {

        private readonly IConfiguration _config;

        public ConnectivitySqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LaodData<T, U>(
                                     string storedProcedure,
                                     U parameters,
                                     string connectionStringName = "Default")
        {

            //using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            using IDbConnection connection = new SqlConnection(connectionStringName);
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }



        public async Task SaveData<T>(
                                     string storedProcedure,
                                     T parameters,
                                     string connectionStringName = "Default")
        {

            //using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            using IDbConnection connection = new SqlConnection(connectionStringName);

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }





        /*
        public async Task<IEnumerable<T>> LaodData<T, U>(string sqlStatement,
                                     U parameters,
                                     string connectionStringName,
                                     bool isStoredProcedure = false)
        {
            string theConnectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(theConnectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters, commandType: commandType).ToList();
                return rows;
            }
        }
        


        public int SaveData<T>(string sqlStatement,
                                      T parameters,
                                      string connectionStringName,
                                      bool isStoredProcedure = false)

        {
            int QueryExecuted;

            string theConnectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(theConnectionString))
            {
                QueryExecuted = connection.Execute(sqlStatement, parameters, commandType: commandType);
            }

            return QueryExecuted;
        }

        */
    }
}
