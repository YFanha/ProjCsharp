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
        public Ticket ticket;

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
            lblTicketId.Text = ticket.Id.ToString();
            lblTitleValue.Text = ticket.Title;
            lblProblemTypeValue.Text = ticket.Category;
            lblDateValue.Text = ticket.OpeningDate.ToString();
            lblStateTicket.Text = ticket.State;
            lblTicketOpenBy.Text = ticket.OpeningPerson;
            lblTicketLastEdit.Text = ticket.LastModifiedDate.ToString();
            lblTicketEditBy.Text = ticket.LastModifiedPerson;
            lblTicketManager.Text = ticket.Manager;



            rtxtDescription.Text = ticket.Description;


        }

        private void btnRemoveTicket_Click(object sender, EventArgs e)
        {
            ticket.Delete();
            this.Close();
        }
    }
}
