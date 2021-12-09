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


namespace Création_tickets
{



    public partial class frmTicket : Form
    {
        string ticketTypeProblem;
        string ticketName;

        public frmTicket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Time;

            
            cmbType.Items.Add("Problème logiciel");
            cmbType.Items.Add("Problème réseau");
            cmbType.Items.Add("Problème système");
            cmbType.Items.Add("Problème matériel");
            cmbType.Items.Add("Autre problèmes");


            /*string ticketName = txbName.Text;
            if (cmbType.SelectedItem is not null)
            {
                ticketTypeProblem = cmbType.SelectedItem.ToString();
            }
            string ticketTime = timePicker.CustomFormat;
            string ticketDesc = rtxbDesc.Text;
            string ticketDate = mcrTicketDate.Text; //*/
            

      
            

            // string datasource = "10.229.33.34";
            // string username = "admin";
            // string pass = "Pa$$w0rd";
            // int port = 3306;
            //
            //
            // connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={pass};database=ticketing");
            // connection.Open();

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

        private void onNameChanged(object sender, EventArgs e)
        {
            ticketName = ((TextBox)sender).Text;
        }

        private void onTypeChanged(object sender, EventArgs e)
        {
            cmbType = ((ComboBox)sender).;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string problem = "Nom du ticket : " + ticketName + "Type de problème" + ticketTypeProblem + ticketTime + ticketDesc + ticketDate;
            string problem = "Nom du ticket : " + ticketName + " Type de problème : ";
            MessageBox.Show(problem); 


            //Save();




            //insert into db with infos
            //connection.Open();

            // string sqlCommand = "INSERT INTO client (prenom, nom, ville, age) VALUES ('Rébecca', 'Armand', 'Saint-Didier-des-Bois', 24)";




            //using MySqlCommand cmd = new MySqlCommand(sqlCommand, connection);
            //    {
            //        
            //        if()
            //        {
            //            
            //        }
            //        else
            //        {
            //            
            //        }
            //    }
            //



        }

        
    }
}
