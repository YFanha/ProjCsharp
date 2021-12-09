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

        private static MySqlConnection _connection;

        const int DEFAULT_STATES = 1;
        const int DEFAULT_CATEGORY = 5;
        const int TECH_ROLES_ID = 2;


        // Constructeur pour nouveau ticket
        public Ticket(MySqlConnection connection,string title, string description, int openingPersonId)
        {
            _connection = connection;
            _title = title;
            _description = description;
            _categoryId = DEFAULT_CATEGORY;
            _statesId = DEFAULT_STATES;
            _managerId = RandomManager();
            _openingDate = DateTime.Now;
            _openeningPersonId = openingPersonId;
            _lastModifiedDate = DateTime.Now;
            _lastModifiedPersonId = openingPersonId;
        }

        //Constructeur pour ticket déjà enregistré dans la base de données
        private Ticket(int id, string title)
        { 
        }

        //Trouver les données d'un ticket grace à son
        public static Ticket Find(int id)
        {
            string sql = "SELECT * FROM ticket WHERE id = " + id + ";";
            MySqlCommand sqlQuery = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = sqlQuery.ExecuteReader();

            while (reader.Read())
            {
                
            }
        }

        //Enregistrer le ticket dans la base de données
        public void Save()
        {
            throw new NotImplementedException();
        }

        
        // Get a random Manager's id
        public int RandomManager()
        {
            List<int> peopleId = new List<int>();

            string sql = "SELECT id FROM people WHERE roles_id = " + TECH_ROLES_ID +";";
            MySqlCommand sqlQuery = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = sqlQuery.ExecuteReader();

            while (reader.Read())
            {
                peopleId.Add(reader.GetInt32("id"));
            }

            Random rnd = new Random();
            int index = rnd.Next(peopleId.Count);

            return peopleId[index];
        }
    }
}
