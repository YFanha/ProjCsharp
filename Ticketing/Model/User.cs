using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class User
    {
        private string _firstname;
        private string _lastname;
        private string _phoneNumber;
        private string _email;
        private int _rolesId;

        public User(string email, MySqlConnection connection)
        {
            //Récuperer données utilisateurs depuis l'email
            string sqlQuery = "SELECT * FROM people WHERE email =\'" + email + "\'";
            MySqlCommand executeQuery = new MySqlCommand(sqlQuery, connection);

            MySqlDataReader reader = executeQuery.ExecuteReader();

            while (reader.Read())
            {
                _email = email;
                _firstname = reader.GetString("firstname");
                _lastname = reader.GetString("lastname");
                _phoneNumber = reader.GetString("phoneNumber");
                _rolesId = int.Parse(reader.GetString("roles_id"));
            }
        }

        public string Firstname
        {
            get { return _firstname; }
        }

        public string Lastname
        {
            get { return _lastname; }
        }

        public string phoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Email
        {
            get { return _email; }
        }

        public int Roles
        {
            get { return _rolesId; }
        }
    }
}
