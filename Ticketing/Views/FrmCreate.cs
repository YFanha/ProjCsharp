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
    public partial class frmTicket : Form
    {
        private string ticketName;

        public User User;

        //Constante pour définir le type d'utilisateur /!\ DOIT CORRESPONDRE à LA BASE DE DONNÉE (Valeur de la table ´roles´) /!\
        const int USER_ROLE_ID = 1;
        const int TECH_ROLE_ID = 2;
        const int ADMIN_ROLE_ID = 3;

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
            string problem = "Votre ticket a bien été envoyé. \nNom du ticket : " + ticketName + "\nType de problème : " + ticketType.SelectedItem + "\nHeure de la panne : " + ticketHour.Text + "\nDate de la panne " + ticketDate.SelectionStart.Day+"." + ticketDate.SelectionStart.Month + "." + ticketDate.SelectionStart.Year + "\nDescription : " + ticketDesc.Text;
            
            try
            {
                Category category = Category.FindFromName(ticketType.Text);

                Ticket ticket = new Ticket(ticketName, ticketDesc.Text.ToString(), User.Id, category.Id);
                ticket.Save();

                if(User.RolesId == USER_ROLE_ID)
                {
                    lblTitleValue.Text = ticketName;
                    lblProblemTypeValue.Text = ticketType.SelectedItem.ToString();
                    lblDateValue.Text = ticketDate.SelectionStart.Day + "." + ticketDate.SelectionStart.Month + "." + ticketDate.SelectionStart.Year;
                    rtxtDescription.Text = ticketDesc.Text;

                    grpBoxConfirmMsg.Visible = true;

                } else
                {
                    this.Close();
                }
            }
            catch (NoTechnicianAvailable ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblProblemTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            ticketHour.Format = DateTimePickerFormat.Time;
            ticketType.SelectedItem = "Inconnu";
            txbName.Text = "";
            ticketDesc.Text = "";

            grpBoxConfirmMsg.Visible = false;
        }
    }
}
