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

        //Constante pour définir le type d'utilisateur /!\ DOIT CORRESPONDRE à LA BASE DE DONNÉE (Valeur de la table ´roles´) /!\
        const int USER_ROLE_ID = 1;
        const int TECH_ROLE_ID = 2;
        const int ADMIN_ROLE_ID = 3;


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

            try
            {
                _connection = DatabaseInteractions.GetConnection();
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

                Hide();

                if(UserConnected.RolesId == TECH_ROLE_ID || UserConnected.Id == ADMIN_ROLE_ID)
                {

                    //Ouvrir page des tickets
                    FrmViewTtickets frmViewTickets = new FrmViewTtickets();
                    frmViewTickets.User = UserConnected;
                    frmViewTickets.ShowDialog();

                }else if(UserConnected.RolesId == USER_ROLE_ID)
                {
                    frmTicket frmCreateTicket = new frmTicket();
                    frmCreateTicket.User = UserConnected;
                    frmCreateTicket.ShowDialog();
                }
                
                txtboxLogin.Text = "";
                txtboxPassword.Text = "";
                Show();
            }
            catch (BadPasswordException ex)
            {
                
                lblConnectionError.Text = ex.Message;
            }

        }
    }
}