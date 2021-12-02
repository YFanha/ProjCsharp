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


namespace loginTest
{
    public partial class LoginWindow : Form
    {



        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            try 
            {
                string datasource = "localhost";
                string username = "root";
                string pass = "";
                int port = 3306;


                MySqlConnection connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={pass};database=clientstest");
                connection.Open();

                if(connection.State == ConnectionState.Open)
                {
                    lblConnection.Text = "Connected";
                     lblConnection.ForeColor = Color.Green;
                    
                }
                else
                {
                    lblConnection.Text = "Not Connected";
                    lblConnection.ForeColor = Color.Red;
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string datasource = "localhost";
            string username = "root";
            string pass = "";
            int port = 3306;


            MySqlConnection connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={pass};database=clientstest");

            try
            {
                connection.Open();

                string sqlCommand = "SELECT password FROM users WHERE username = \'" + txtboxLogin.Text + "\';";

                using MySqlCommand cmd = new MySqlCommand(sqlCommand, connection);
                {
                    string psw = cmd.ExecuteScalar()?.ToString();
                    if(psw == txtboxPassword.Text)
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
        private void txtboxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
