using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

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

        private MySqlConnection _connection;

        const int DEFAULT_STATES = 1;
        const int DEFAULT_CATEGORY = 5;

        //Nom des colonnes
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
        public Ticket(string title, string description, int openingPersonId)
        {
            _connection = DatabaseInteractions.GetConnection();
            _title = title;
            _description = description;
            _categoryId = DEFAULT_CATEGORY;
            _statesId = DEFAULT_STATES;
            _managerId = Technician.RandomTechnician(); //
            _openingDate = DateTime.Now;
            _openeningPersonId = openingPersonId;
            _lastModifiedDate = DateTime.Now;
            _lastModifiedPersonId = openingPersonId;
        }

        //Constructeur pour ticket déjà enregistré dans la base de données
        private Ticket(int id, string title, string description, int category_id, int state_id, int manager_id, DateTime opening, int openingPerson, DateTime closing, int closingPerson, DateTime lastModified, int lastModifiedPerson)
        {
            _title = title;
            _description = description;
            _categoryId = category_id;
            _statesId = state_id;
            _managerId = Technician.RandomTechnician(); //
            _openingDate = opening;
            _openeningPersonId = openingPerson;
            _closingDate = closing;
            _closingPersonId = closingPerson;
            _lastModifiedDate = lastModified;
            _lastModifiedPersonId = lastModifiedPerson;
        }

        //Trouver les données d'un ticket grace à son id
        public static Ticket Find(int id)
        {
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM ticket WHERE id = " + id + ";", DatabaseInteractions.GetConnection()).ExecuteReader();

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

            while (reader.Read())
            {
                title = reader.GetString(TITLE);
                description = reader.GetString(DESCRIPTION);
                category_id = reader.GetInt32(CATEGORY);
                state_id = reader.GetInt32(STATE);
                manager_id = reader.GetInt32(MANAGER);
                opening = reader.GetDateTime(OPENING_DATE);
                openingPerson = reader.GetInt32(OPENING_PERSON);
                closing = reader.GetDateTime(CLOSING_DATE);
                closingPerson = reader.GetInt32(CLOSING_PERSON);
                lastmodified = reader.GetDateTime(LAST_MODIFIED_DATE);
                lastmodifiedPerson = reader.GetInt32(LAST_MODIFIED_PERSON);
            }

            return new Ticket(id, title, description, category_id, state_id, manager_id, opening, openingPerson, closing, closingPerson, lastmodified, lastmodifiedPerson);
        }

        //Enregistrer le ticket dans la base de données
        public void Save()
        {
            MySqlCommand sqlQuery = new MySqlCommand("", _connection);
            try
            {
                
            }
        }
    }
}
