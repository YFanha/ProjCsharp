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
            _connection = DatabaseConnection.GetConnection();

            //Récuperer données utilisateurs depuis l'email

            MySqlDataReader reader = DatabaseConnection.ReadSql("SELECT * FROM people WHERE email =\'" + email + "\'");

            while (reader.Read())
            {
                _email = email;
                _firstname = reader.GetString("firstname");
                _lastname = reader.GetString("lastname");
                _phoneNumber = reader.GetString("phoneNumber");
                _rolesId = int.Parse(reader.GetString("roles_id"));
            }

            Ticket t = Ticket.Find(100);
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

        public string Roles
        {
            get 
            {
                //Récupérer le nom du rôles depuis l'id
                /*string sql = "SELECT name FROM roles WHERE id = " + _rolesId+ ";";
                MySqlCommand sqlQuery = new MySqlCommand(sql, _connection);
                string roles = sqlQuery.ExecuteScalar()?.ToString();*/

                string roles = DatabaseConnection.ReadFirstWordSql("SELECT name FROM roles WHERE id = " + _rolesId + ";");

                return roles;
            }
        }
    }
}
