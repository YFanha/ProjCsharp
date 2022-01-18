using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

namespace Ticketing
{
    public class Ticket
    {
        private int _id;
        private string _title;
        private string _description;
        private int _categoryId; //
        private int _statesId; //
        private int _managerId; //
        private DateTime _openingDate; //
        private int _openeningPersonId;
        private DateTime _closingDate;
        private int _closingPersonId;
        private DateTime _lastModifiedDate;
        private int _lastModifiedPersonId;

        const int DEFAULT_STATES = 1;
        const int DEFAULT_CATEGORY = 4;

        //Nom des colonnes
        const string ID = "id";
        const string TITLE = "title";
        const string DESCRIPTION = "description";
        const string CATEGORY = "category_id";
        const string STATE = "state_id";
        const string MANAGER = "manager_id";
        const string OPENING_DATE = "openingDate";
        const string OPENING_PERSON = "openingPerson_id";
        const string CLOSING_DATE = "closingDate";
        const string CLOSING_PERSON = "closingPerson_id";
        const string LAST_MODIFIED_DATE = "lastModifiedDate";
        const string LAST_MODIFIED_PERSON = "lastModifiedPerson_id";



        // Constructeur pour nouveau ticket
        public Ticket(string title, string description, int openingPersonId, int category = DEFAULT_CATEGORY)
        {
            _managerId = Technician.RandomTechnician();

            _title = title;
            _description = description;
            _categoryId = category;
            _statesId = DEFAULT_STATES;
            _openingDate = DateTime.Now;
            _openeningPersonId = openingPersonId;
            _lastModifiedDate = DateTime.Now;
            _lastModifiedPersonId = openingPersonId;
        }

        //Constructeur pour ticket déjà enregistré dans la base de données
        private Ticket(int id, string title, string description, int category_id, int state_id, int manager_id, DateTime opening, int openingPerson, DateTime closing, int closingPerson, DateTime lastModified, int lastModifiedPerson)
        {
            _id = id;
            _title = title;
            _description = description;
            _categoryId = category_id;
            _statesId = state_id;
            _managerId = manager_id; //
            _openingDate = opening;
            _openeningPersonId = openingPerson;
            _closingDate = closing;
            _closingPersonId = closingPerson;
            _lastModifiedDate = lastModified;
            _lastModifiedPersonId = lastModifiedPerson;
        }

        public static List<Ticket> FindAll(string parameter = "")
        {
            MySqlDataReader reader = new MySqlCommand("SELECT * from tickets WHERE state_id LIKE \"%" + parameter + "%\"", DatabaseInteractions.GetConnection()).ExecuteReader();

            List<Ticket> ticketsList = new List<Ticket>();
            while (reader.Read())
            {
                Ticket newTicket = GetTicketFromReader(reader);
                ticketsList.Add(newTicket);
            }
            reader.Close();

            return ticketsList;
        }

        //Trouver les données d'un ticket grace à son id
        public static Ticket Find(int id)
        {
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM tickets WHERE id = " + id + ";", DatabaseInteractions.GetConnection()).ExecuteReader();

            Ticket ticket = null;

            while (reader.Read())
            {
                ticket = GetTicketFromReader(reader);
            }
            reader.Close();

            return ticket;
        }

        private static Ticket GetTicketFromReader(MySqlDataReader reader)
        {
            int id = 0;
            string title = null;
            string description = null;
            int category_id = 0;
            int state_id = 0;
            int manager_id = 0;
            DateTime opening = DateTime.Now;
            int openingPerson = 0;
            DateTime closing = DateTime.Now;
            int closingPerson = 0;
            DateTime lastmodified = DateTime.Now;
            int lastmodifiedPerson = 0;

            id = reader.GetInt32(ID);
            title = reader.GetString(TITLE);
            description = reader.GetString(DESCRIPTION);
            category_id = reader.GetInt32(CATEGORY);
            state_id = reader.GetInt32(STATE);
            manager_id = reader.GetInt32(MANAGER);
            opening = reader.GetDateTime(OPENING_DATE);
            openingPerson = reader.GetInt32(OPENING_PERSON);
            if (!reader.IsDBNull(8))
            {
                closing = reader.GetDateTime(CLOSING_DATE);
                closingPerson = reader.GetInt32(CLOSING_PERSON);
            }
            lastmodified = reader.GetDateTime(LAST_MODIFIED_DATE);
            lastmodifiedPerson = reader.GetInt32(LAST_MODIFIED_PERSON);


            return new Ticket(id, title, description, category_id, state_id, manager_id, opening, openingPerson, closing, closingPerson, lastmodified, lastmodifiedPerson);
        }

        //Enregistrer le ticket dans la base de données
        public void Save()
        {
            MySqlCommand InsertCommand = new MySqlCommand();

            string stringQuery = "INSERT INTO tickets (" + TITLE + ", " + DESCRIPTION + ", " + CATEGORY + ", " + STATE + ", " + MANAGER + ", " + OPENING_DATE + ", " + OPENING_PERSON + ", " + LAST_MODIFIED_DATE + ", " + LAST_MODIFIED_PERSON + ") VALUES (@title, @description, @category, @state, @manager , @openingDate, @openingPerson, @lastModifiedDate, @lastModifiedPerson);";
            InsertCommand.CommandText = stringQuery;
            InsertCommand.Connection = DatabaseInteractions.GetConnection();

            InsertCommand.Parameters.AddWithValue("@title", _title);
            InsertCommand.Parameters.AddWithValue("@description", _description);
            InsertCommand.Parameters.AddWithValue("@category", _categoryId);
            InsertCommand.Parameters.AddWithValue("@state", _statesId);
            InsertCommand.Parameters.AddWithValue("@manager", _managerId);
            InsertCommand.Parameters.AddWithValue("@openingDate", _openingDate);
            InsertCommand.Parameters.AddWithValue("@openingPerson", _openeningPersonId);
            InsertCommand.Parameters.AddWithValue("@lastModifiedDate", _lastModifiedDate);
            InsertCommand.Parameters.AddWithValue("@lastModifiedPerson", _lastModifiedPersonId);

            InsertCommand.ExecuteNonQuery();
        }

        public void Update()
        {
            MySqlCommand updateCommand = new MySqlCommand();

            string sqlQuery = "Update tickets SET title = @title, description = @description, category_id = @category_id, state_id = @state_id, lastModifiedDate = @lastModifiedDate, lastModifiedPerson_id = @lastModifiedPerson_id WHERE id = @id;";
            
            updateCommand.CommandText = sqlQuery;
            updateCommand.Connection = DatabaseInteractions.GetConnection();

            updateCommand.Parameters.AddWithValue("@title", _title);
            updateCommand.Parameters.AddWithValue("@description", _description);
            updateCommand.Parameters.AddWithValue("@category_id", _categoryId);
            updateCommand.Parameters.AddWithValue("@state_id", _statesId);
            updateCommand.Parameters.AddWithValue("@lastModifiedDate", _lastModifiedDate);
            updateCommand.Parameters.AddWithValue("@lastModifiedPerson_id", _lastModifiedPersonId);

            updateCommand.Parameters.AddWithValue("@id", _id);

            updateCommand.ExecuteNonQuery();
        }

        //Getter/Setter des variables
        /**
         * Variable modifiable : Description, CategoryId, StatesId, ManagerId, LastModifiedDate,LastModifiedPersonId / ClosingDate, ClosingPersonId => que sous condition
         * */
        public int Id
        {
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        public string Category
        {
            get { return DatabaseInteractions.ReadFirstString("SELECT name FROM categories WHERE id = " + CategoryId + ";"); }
        }

        public int StatesId
        {
            get { return _statesId; }
            set { _statesId = value; }
        }

        public string State
        {
            get { return DatabaseInteractions.ReadFirstString("SELECT name FROM states WHERE id = " + StatesId + ";"); }
        }

        public int ManagerId
        {
            get { return _managerId; }
            set { _managerId = value; }
        }
        public string Manager
        {
            get { return User.GetFullName(ManagerId); }
        }

        public DateTime OpeningDate
        {
            get { return _openingDate; }
        }

        public int OpeningPersonId
        {
            get { return _openeningPersonId; }
        }
        public string OpeningPerson
        {
            get { return User.GetFullName(OpeningPersonId); }
        }

        public DateTime ClosingDate
        {
            get { return _closingDate; }
            set { _closingDate = value; }
        }

        public int ClosingPersonId
        {
            get { return _closingPersonId; }
            set { _closingPersonId = value; }
        }

        public string ClosingPerson
        {
            get { return User.GetFullName(ClosingPersonId); }
        }

        public DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        public int LastModifiedPersonId
        {
            get { return _lastModifiedPersonId; }
            set { _lastModifiedPersonId = value; }
        }

        public string LastModifiedPerson
        {
            get { return User.GetFullName(LastModifiedPersonId); }
        }
    }
}
