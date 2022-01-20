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
    public class Technician : User
    {
        const int TECH_ROLES_ID = 2;

        public Technician(string email, string firstname, string lastname, string phoneNumber, string password) : base(email, firstname, lastname, phoneNumber, password)
        {
            _rolesId = TECH_ROLES_ID;
        }


        public static int RandomTechnician()
        {
            List<int> peopleId = new List<int>();
            
            string sql = "SELECT id FROM people WHERE role_id = " + TECH_ROLES_ID + ";";
            MySqlCommand sqlQuery = new MySqlCommand(sql, DatabaseInteractions.GetConnection());
            MySqlDataReader reader = sqlQuery.ExecuteReader();

            while (reader.Read())
            {
                peopleId.Add(reader.GetInt32("id"));
            }
            reader.Close();

            if(peopleId.Count <= 0)
            {
                throw new NoTechnicianAvailable();
            }

            Random rnd = new Random();
            int index = rnd.Next(peopleId.Count);

            return peopleId[index];
        }
    }
}
