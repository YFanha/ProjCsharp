using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class Technician : User
    {
        const int TECH_ROLES_ID = 2;

        public Technician(string email) : base(email)
        {
            
        }


        public static int RandomTechnician()
        {
            List<int> peopleId = new List<int>();
            
            string sql = "SELECT id FROM people WHERE roles_id = " + TECH_ROLES_ID + ";";
            MySqlCommand sqlQuery = new MySqlCommand(sql, DatabaseInteractions.GetConnection());
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
