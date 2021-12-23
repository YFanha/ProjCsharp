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
        private MySqlConnection _connection;
        public User UserConnected;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _connection.Close();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            _connection = DatabaseInteractions.GetConnection();

            try
            {
                _connection.Open();   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("L'erreur suivante est survenue, contactez l'administrateur : \n" + ex.Number.ToString() + " : " + ex.Message);

                btnConnexion.Enabled = false;
                lblConnectionError.Text = "Impossible de se connecter au serveur.";
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                UserConnected = User.SignIn(txtboxLogin.Text, txtboxPassword.Text);

                //Ouvrir page des tickets
                FrmViewTtickets frmViewTickets = new FrmViewTtickets();
                Hide();
                frmViewTickets.User = UserConnected;
                frmViewTickets.ShowDialog();
                Show();
            }
            catch (BadPasswordException ex)
            {
                
                lblConnectionError.Text = ex.Message;
            }

        }
    }
}