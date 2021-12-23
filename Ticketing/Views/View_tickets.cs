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
            //Get all states
            List<State> states = State.FindAll();
            ComboBox cmbState = new ComboBox();

            foreach(State state in states)
            {
                cmbState.Items.Add(state.Name);
            }
            ((DataGridViewComboBoxColumn)dgvTickets.Columns["TicketState"]).DataSource = cmbState.Items;

            //Get all categories
            List<Category> categories = Category.FindAll();
            ComboBox cmbCategory = new ComboBox();

            foreach(Category category in categories)
            {
                cmbCategory.Items.Add(category.Name);
            }
            ((DataGridViewComboBoxColumn)dgvTickets.Columns["TicketCategory"]).DataSource = cmbCategory.Items;


            _tickets = new List<Ticket>();
            _tickets = Ticket.FindAll();

            foreach(Ticket ticket in _tickets)
            {
                int newRowIndex = dgvTickets.Rows.Add();

                DataGridViewRow newRow = dgvTickets.Rows[newRowIndex];

                newRow.Cells["TicketNumber"].Value = ticket.Id; 
                newRow.Cells["TicketTitle"].Value = ticket.Title; 
                newRow.Cells["TicketDescription"].Value = ticket.Description; 
                //newRow.Cells["TicketCategory"].Value = ticket.CategoryId; 
                //newRow.Cells["TicketState"].Value = ticket.StatesId; 
                newRow.Cells["openingDate"].Value = ticket.OpeningDate; 
                newRow.Cells["openingPerson"].Value = ticket.OpeningPerson; 
                newRow.Cells["LastModifiedDate"].Value = ticket.LastModifiedDate; 
                newRow.Cells["LastModifiedPerson"].Value = ticket.LastModifiedPerson; 
                newRow.Cells["TicketManager"].Value = ticket.Manager; 
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

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
