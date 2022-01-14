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
        private int _id;
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
                _id = reader.GetInt32("id");
                _firstname = reader.GetString("firstname");
                _lastname = reader.GetString("lastname");
                _phoneNumber = reader.GetString("phoneNumber");
                _rolesId = int.Parse(reader.GetString("role_id"));
            }

            reader.Close();
        }

        public int Id
        {
            get { return _id; }
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
                return DatabaseInteractions.ReadFirstString("SELECT name FROM roles WHERE id = " + _rolesId + ";");
            }
        }

        public static User SignIn(string email, string password)
        {
            string correctPassword = DatabaseInteractions.ReadFirstString("SELECT password FROM people WHERE email = \'" + email + "\';");
            
            if (password != correctPassword)
            {
                throw new BadPasswordException();
            }

            return new User(email);
        }

        public static int GetId(string fullname)
        {
            throw new NotImplementedException();
            //Regex pour séparer les deux noms

            //Reader

            //Retourner Id
        }

        public static string GetFullName(int id)
        {
            string fullName = "";
            MySqlDataReader reader = new MySqlCommand("SELECT lastname, firstname FROM people WHERE id =\'" + id + "\'", DatabaseInteractions.GetConnection()).ExecuteReader();

            while (reader.Read())
            {
                fullName += reader.GetString("lastname") + " ";
                fullName += reader.GetString("firstname");
            }
            reader.Close();
            return fullName;

        }
    }
}
