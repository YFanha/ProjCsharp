/**
 * Fichiers pour les fonctions d'interaction avec la base de données
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class DatabaseInteractions
    {
        private static MySqlConnection _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection is null)
            {
                string datasource = "127.0.0.1";
                string username = "admin";
                string database = "ticketing";
                string password = "Pa$$w0rd";
                int port = 3306;

                _connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={password};database={database}");
            }
            if(_connection.State == System.Data.ConnectionState.Closed )
            {
                _connection.Open();
            }

            return _connection;
        }

        public static string ReadFirstString(string sql)
        {
            MySqlCommand sqlQuery = new MySqlCommand(sql, DatabaseInteractions.GetConnection());
            return sqlQuery.ExecuteScalar()?.ToString();
        }

        public static void CloseConnection()
        {
            if(_connection is null)
            {
                throw new NoConnectionException();
            }
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
    }
}
