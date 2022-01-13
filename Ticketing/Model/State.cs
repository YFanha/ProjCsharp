using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class State
    {
        private int _id;
        private string _name;

        private State(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public static List<State> FindAll()
        {
            List<State> _states = new List<State>();

            MySqlDataReader reader = new MySqlCommand("SELECT * FROM states;", DatabaseInteractions.GetConnection()).ExecuteReader();

            while (reader.Read())
            {
                State aNewState = new State(reader.GetInt32("id"), reader.GetString("name"));
                _states.Add(aNewState);
            }
            reader.Close();

            return _states;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}