using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ticketing
{
    public partial class FrmDetailTicket : Form
    {
        public Ticket Ticket;

        public FrmDetailTicket()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetailTicket_Load(object sender, EventArgs e)
        {
            lblTicketId.Text = Ticket.Id.ToString();
            lblTitleValue.Text = Ticket.Title;
            lblProblemTypeValue.Text = Ticket.Category;
            lblDateValue.Text = Ticket.OpeningDate.ToString();
            lblStateTicket.Text = Ticket.State;
            lblTicketOpenBy.Text = Ticket.OpeningPerson;
            lblTicketLastEdit.Text = Ticket.LastModifiedDate.ToString();
            lblTicketEditBy.Text = Ticket.LastModifiedPerson;
            lblTicketManager.Text = Ticket.Manager;



            rtxtDescription.Text = Ticket.Description;


        }

        private void btnRemoveTicket_Click(object sender, EventArgs e)
        {
            //Ticket ticketToDelete = Ticket.Find(id);
            //ticketToDelete.Delete();
        }
    }
}
