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
    public partial class FrmViewTtickets : Form
    {
        public User User;
        private List<Ticket> _tickets;
        private int _ticketSelected_id; //Id du ticket séléctionner, sert pour la modification.
        private bool _dgvDataLoaded; //Valeur savoir quand les données de la base de données sont inscrites dans la DataGridView.


        public FrmViewTtickets()
        {
            InitializeComponent();
        }

        private void FrmViewTtickets_Load(object sender, EventArgs e)
        {
            //Get all states
            List<State> states = State.FindAll();
            ComboBox cmbState = new ComboBox();

            cmbStateChoice.Items.Add("Tous");

            foreach (State state in states)
            {
                cmbState.Items.Add(state.Name);

                //Add states for choice of type of ticket
                cmbStateChoice.Items.Add(state);
            }
            ((DataGridViewComboBoxColumn)dgvTickets.Columns["TicketState"]).DataSource = cmbState.Items;

            //Get all categories
            List<Category> categories = Category.FindAll();
            ComboBox cmbCategory = new ComboBox();

            foreach (Category category in categories)
            {
                cmbCategory.Items.Add(category.Name);
            }
            ((DataGridViewComboBoxColumn)dgvTickets.Columns["TicketCategory"]).DataSource = cmbCategory.Items;


            _tickets = new List<Ticket>();
            cmbStateChoice.SelectedItem = "Tous"; //Cela va remplir la dgv grace à l'evenement <cmbStateChoice_SelectedIndexChanged>
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTicket frmTicket = new frmTicket();
            frmTicket.User = this.User;
            frmTicket.ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbStateChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dgvDataLoaded = false;

            dgvTickets.Rows.Clear();
            dgvTickets.Refresh();

            if (cmbStateChoice.SelectedItem.ToString() != "Tous")
            {
                State state = (State)cmbStateChoice.SelectedItem;
                _tickets = Ticket.FindAll(state.Id.ToString());
            }
            else
            {
                _tickets = Ticket.FindAll();
            }
            PutTicketInDataGridView();
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Insert Tickets from the list of ticket (_tickets) in datagridview
        private void PutTicketInDataGridView()
        {
            _dgvDataLoaded = false;
            foreach (Ticket ticket in _tickets)
            {
                int newRowIndex = dgvTickets.Rows.Add();

                DataGridViewRow newRow = dgvTickets.Rows[newRowIndex];

                newRow.Cells["TicketNumber"].Value = ticket.Id.ToString();
                newRow.Cells["TicketTitle"].Value = ticket.Title;
                newRow.Cells["TicketDescription"].Value = ticket.Description;
                newRow.Cells["TicketCategory"].Value = ticket.Category;
                newRow.Cells["TicketState"].Value = ticket.State;
                newRow.Cells["openingDate"].Value = ticket.OpeningDate;
                newRow.Cells["openingPerson"].Value = ticket.OpeningPerson;
                newRow.Cells["LastModifiedDate"].Value = ticket.LastModifiedDate;
                newRow.Cells["LastModifiedPerson"].Value = ticket.LastModifiedPerson;
                newRow.Cells["TicketManager"].Value = ticket.Manager;
            }
            _dgvDataLoaded = true;
        }

        private void dgvTickets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_dgvDataLoaded)
            {
                Ticket ticketToUpdate = Ticket.Find(_ticketSelected_id);

                //Update ticket's datas
                ticketToUpdate.Description = dgvTickets.CurrentRow.Cells["TicketDescription"].Value.ToString();
                ticketToUpdate.LastModifiedDate = DateTime.Parse(dgvTickets.CurrentRow.Cells["lastModifiedDate"].Value.ToString());
                ticketToUpdate.CategoryId = Category.FindFromName(dgvTickets.CurrentRow.Cells["TicketCategory"].Value.ToString()).Id;
                ticketToUpdate.StatesId = State.FindFromName(dgvTickets.CurrentRow.Cells["TicketState"].Value.ToString()).Id;
                ticketToUpdate.LastModifiedPersonId = User.Id;

                //Execute the Update query
                ticketToUpdate.Update();
            }
        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow.Cells[0].Value != null)
            {
                _ticketSelected_id =  int.Parse(dgvTickets.CurrentRow.Cells[0].Value.ToString());
            }

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvTickets.Rows.Clear();
            dgvTickets.Refresh();
            _tickets = Ticket.FindAll();
            PutTicketInDataGridView();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
