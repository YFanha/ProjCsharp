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
        protected int _id;
        protected string _firstname;
        protected string _lastname;
        protected string _phoneNumber;
        protected string _email;
        protected int _rolesId;
        protected string _password;

        private const int USER_ROLE_ID = 1;

        public User(string email, string firstname, string lastname, string phoneNumber, string password)
        {
            _email = email;
            _firstname = firstname;
            _lastname = lastname;
            _phoneNumber = phoneNumber;
            _password = password;
            _rolesId = USER_ROLE_ID;
        }

        protected User(int id, string email, string firstname, string lastname, string phoneNumber, int role_id)
        {
            _email = email;
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _phoneNumber = phoneNumber;
            _rolesId = role_id;
        }

        public static User Find(string email)
        {
            //Récuperer données utilisateurs depuis l'email
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM people WHERE email =\'" + email + "\'", DatabaseInteractions.GetConnection()).ExecuteReader();


            User user = null;
            while (reader.Read())
            {
                user = GetUserFromReader(reader);
            }
            reader.Close();

            return user;
        }

        public static User GetUserFromReader(MySqlDataReader reader)
        {
            string email = reader.GetString("email");
            int id = reader.GetInt32("id");
            string firstname = reader.GetString("firstname");
            string lastname = reader.GetString("lastname");
            string phoneNumber = reader.GetString("phoneNumber");
            int role_id = int.Parse(reader.GetString("role_id"));

            return new User(id, email, firstname, lastname, phoneNumber, role_id);
        }

        //Code pas tester
        public void Register()
        {
            string sqlQuery = "INSERT INTO people (lastname, firstname, phoneNumber, email, password, role_id) VALUES (@lastname, @firstname, @phoneNumber, @email, @password, @role_id)";
            MySqlCommand registerCommand = new MySqlCommand(sqlQuery, DatabaseInteractions.GetConnection());

            registerCommand.Parameters.AddWithValue("@lastname", _lastname);
            registerCommand.Parameters.AddWithValue("@firstname", _firstname);
            registerCommand.Parameters.AddWithValue("@phoneNumber", _phoneNumber);
            registerCommand.Parameters.AddWithValue("@email", _email);
            registerCommand.Parameters.AddWithValue("@password", _password);
            registerCommand.Parameters.AddWithValue("@role_id", _rolesId);

            registerCommand.ExecuteNonQuery();
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

            return User.Find(email);
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
