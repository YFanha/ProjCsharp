using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Création_tickets
{

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtxbDesc_TextChanged(object sender, EventArgs e)
        {
            string txtcar = rtxbDesc.Text;
            int length = txtcar.Length;

            lblCaractere.Text = length.ToString();
        }

        private void lblCaractere_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
