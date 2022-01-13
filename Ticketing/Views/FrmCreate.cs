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
using Ticketing;

namespace Création_tickets
{ 
    public partial class frmTicket : Form
    {
        private string ticketTypeProblem;
        private string ticketName;
        public User User;

        public frmTicket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ticketHour.Format = DateTimePickerFormat.Time;

            List<Category> categories = Category.FindAll();

            foreach(Category _category in categories)
            {
                ticketType.Items.Add(_category.Name);
                if (_category.Name == "Inconnu") ticketType.SelectedItem = _category.Name;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtxbDesc_TextChanged(object sender, EventArgs e)
        {
            string txtcar = ticketDesc.Text;
            int length = txtcar.Length;

            lblCaractere.Text = length.ToString();
        }

        private void lblCaractere_Click(object sender, EventArgs e)
        {

        }

        private void onNameChanged(object sender, EventArgs e)
        {
            ticketName = ((TextBox)sender).Text;
        }

        private void onTypeChanged(object sender, EventArgs e)
        {
            ticketType = (ComboBox)((ComboBox)sender);
        }
        
        private void onHourChanged(object sender, EventArgs e)
        {
            ticketHour.Value = ((DateTimePicker)sender).Value;
        }
        
        private void onDescChanged(object sender, EventArgs e)
        {
            ticketDesc = ((RichTextBox)sender);
        }
        
        private void onDateChanged(object sender, EventArgs e)
        {
            ticketDate = ((MonthCalendar)sender);
        }
        

        private void btnSend_Click(object sender, EventArgs e)
        {
            string problem = "Nom du ticket : " + ticketName + " | Type de problème : " + ticketType.SelectedItem + " | Heure de la panne : " + ticketHour.Text + " | Date de la panne " + ticketDate.SelectionStart.Day+"." + ticketDate.SelectionStart.Month + "." + ticketDate.SelectionStart.Year + " | Description : " + ticketDesc.Text;
            MessageBox.Show(problem);
            try
            {
                Ticket ticket = new Ticket(ticketName, ticketDesc.ToString(), User.Id);
                ticket.Save();
                this.Close();
            }
            catch (NoTechnicianAvailable ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
