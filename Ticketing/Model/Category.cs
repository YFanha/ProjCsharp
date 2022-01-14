using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public class Category
    {
        private string _name;
        private int _id;

        private Category(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public static List<Category> FindAll()
        {
            List<Category> categories = new List<Category>();

            MySqlDataReader reader = new MySqlCommand("SELECT * FROM categories;", DatabaseInteractions.GetConnection()).ExecuteReader();

            while (reader.Read())
            {
                Category aNewState = new Category(reader.GetInt32("id"), reader.GetString("name"));
                categories.Add(aNewState);
            }
            reader.Close();

            return categories;
        }

        public static Category FindFromName(string name)
        {
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM categories WHERE name LIKE \"" + name + "\";", DatabaseInteractions.GetConnection()).ExecuteReader();
            Category category = null;

            while (reader.Read())
            {
                category = new Category(reader.GetInt32("id"), reader.GetString("name"));
            }
            reader.Close();

            return category;
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
