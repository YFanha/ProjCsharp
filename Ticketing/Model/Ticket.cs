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


        // Constructeur pour nouveau ticket
        public Ticket(string title, string description, int openingPersonId)
        {
            _connection = DatabaseConnection.GetConnection();
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
        private Ticket(int id, string title)
        { 
        }

        //Trouver les données d'un ticket grace à son
        public static Ticket Find(int id)
        {
            string sql = "SELECT * FROM ticket WHERE id = " + id + ";";
            MySqlCommand sqlQuery = new MySqlCommand(sql, DatabaseConnection.GetConnection());
            MySqlDataReader reader = sqlQuery.ExecuteReader();

            while (reader.Read())
            {
                
            }


            throw new NotImplementedException();
        }

        //Enregistrer le ticket dans la base de données
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
