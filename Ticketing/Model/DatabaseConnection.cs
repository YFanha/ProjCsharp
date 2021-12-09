﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class DatabaseConnection
    {
        private static MySqlConnection _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection is null)
            {
                string datasource = "10.229.33.34";
                string username = "admin";
                string database = "ticketing";
                string pass = "Pa$$w0rd";
                int port = 3306;

                _connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={pass};database={database}");
            }

            return _connection;
        }
    }
}
