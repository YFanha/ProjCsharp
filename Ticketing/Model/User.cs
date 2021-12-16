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
        protected MySqlConnection _connection;

        public User(string email)
        {
            _connection = DatabaseInteractions.GetConnection();

            //Récuperer données utilisateurs depuis l'email
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM people WHERE email =\'" + email + "\'", _connection).ExecuteReader();

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

        public int RolesId
        {
            get { return _rolesId; }
        }

        public string Role
        {
            get
            { 
                return DatabaseInteractions.ReadNameFromTable("SELECT name FROM roles WHERE id = " + _rolesId + ";");
            }
        }
    }
}
