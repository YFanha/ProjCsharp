
namespace tickets
{
    partial class Tickets
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTickets = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfHelpPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fistnamePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourAvalaible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeProblem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.Location = new System.Drawing.Point(24, 47);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(227, 37);
            this.lblTickets.TabIndex = 0;
            this.lblTickets.Text = "Gestion de tickets";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajout d\'un ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketName,
            this.nameOfHelpPerson,
            this.fistnamePerson,
            this.numPhone,
            this.emailPerson,
            this.hourAvalaible,
            this.descProblem,
            this.dateOpen,
            this.typeProblem,
            this.state});
            this.dataGridView1.Location = new System.Drawing.Point(119, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketName
            // 
            this.ticketName.HeaderText = "Nom du ticket";
            this.ticketName.Name = "ticketName";
            // 
            // nameOfHelpPerson
            // 
            this.nameOfHelpPerson.HeaderText = "Nom de la client(e)";
            this.nameOfHelpPerson.Name = "nameOfHelpPerson";
            // 
            // fistnamePerson
            // 
            this.fistnamePerson.HeaderText = "Prénom de la client(e)";
            this.fistnamePerson.Name = "fistnamePerson";
            // 
            // numPhone
            // 
            this.numPhone.HeaderText = "Numéro de téléphone";
            this.numPhone.Name = "numPhone";
            // 
            // emailPerson
            // 
            this.emailPerson.HeaderText = "Email";
            this.emailPerson.Name = "emailPerson";
            // 
            // hourAvalaible
            // 
            this.hourAvalaible.HeaderText = "Heure joignable";
            this.hourAvalaible.Name = "hourAvalaible";
            // 
            // descProblem
            // 
            this.descProblem.HeaderText = "Description du problème";
            this.descProblem.Name = "descProblem";
            // 
            // dateOpen
            // 
            this.dateOpen.HeaderText = "Date d\'ouverture";
            this.dateOpen.Name = "dateOpen";
            // 
            // typeProblem
            // 
            this.typeProblem.HeaderText = "Type du problème";
            this.typeProblem.Name = "typeProblem";
            this.typeProblem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeProblem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // state
            // 
            this.state.HeaderText = "Etat ";
            this.state.Name = "state";
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Sven+Lisa";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTickets);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfHelpPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn fistnamePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourAvalaible;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpen;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeProblem;
        private System.Windows.Forms.DataGridViewComboBoxColumn state;
        private System.Windows.Forms.TextBox textBox1;
    }
}

