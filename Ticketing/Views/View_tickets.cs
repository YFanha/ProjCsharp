using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class FrmViewTtickets : Form
    {
        private List<Ticket> _tickets;

        public FrmViewTtickets()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmViewTtickets_Load(object sender, EventArgs e)
        {
            _tickets = new List<Ticket>();
            _tickets = Ticket.FindAll();
        }
    }
}
