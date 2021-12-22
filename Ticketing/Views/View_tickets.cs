using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Création_tickets;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public partial class FrmViewTtickets : Form
    {
        private List<Ticket> _tickets;

        public FrmViewTtickets()
        {
            InitializeComponent();
        }

        private void FrmViewTtickets_Load(object sender, EventArgs e)
        {
            List<State> states = State.FindAll();
            ComboBox cmbState = new ComboBox();

            foreach(State state in states)
            {
                cmbState.Items.Add(state.Name);
            }

            ((DataGridViewComboBoxColumn)dgvTickets.Columns["TicketState"]).DataSource = cmbState.Items;


            _tickets = new List<Ticket>();
            _tickets = Ticket.FindAll();

            foreach(Ticket ticket in _tickets)
            {
                int newRowIndex = dgvTickets.Rows.Add();

                DataGridViewRow newRow = dgvTickets.Rows[newRowIndex];
            }
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTicket frmTicket = new frmTicket();
            frmTicket.ShowDialog();
            
        }
    }
}
