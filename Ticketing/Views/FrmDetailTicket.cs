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
            lblTicketId.Text = "12312312";
        }
    }
}
