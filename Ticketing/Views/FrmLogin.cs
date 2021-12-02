using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public partial class FrmLogin : Form
    {
        MySqlConnection connection;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_load(object sender, EventArgs e)
        {
            try
            {
                string datasource = "10.229.33.34";
                string username = "admin";
                string pass = "Pa$$w0rd";
                int port = 3306;


                connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={pass};database=ticketing");
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlCommand = "SELECT password FROM people WHERE email = \'" + txtboxLogin.Text + "\';";

                using MySqlCommand cmd = new MySqlCommand(sqlCommand, connection);
                {
                    string psw = cmd.ExecuteScalar()?.ToString();
                    if (psw == txtboxPassword.Text)
                    {
                        MessageBox.Show("Connexion réussie !");
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect !");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}