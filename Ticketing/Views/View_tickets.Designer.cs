
namespace Ticketing
{
    partial class FrmViewTtickets
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TicketState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.openingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Supprimer un ticket";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter un ticket";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(469, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Se déconnecter";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketNumber,
            this.TicketTitle,
            this.TicketDescription,
            this.TicketCategory,
            this.TicketState,
            this.openingDate,
            this.openingPerson,
            this.lastModifiedDate,
            this.lastModifiedPerson,
            this.TicketManager});
            this.dgvTickets.Location = new System.Drawing.Point(12, 140);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 25;
            this.dgvTickets.Size = new System.Drawing.Size(1161, 150);
            this.dgvTickets.TabIndex = 3;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // TicketNumber
            // 
            this.TicketNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketNumber.HeaderText = "Numéro du ticket";
            this.TicketNumber.MinimumWidth = 6;
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.Width = 88;
            // 
            // TicketTitle
            // 
            this.TicketTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketTitle.HeaderText = "Titre du ticket";
            this.TicketTitle.MinimumWidth = 6;
            this.TicketTitle.Name = "TicketTitle";
            this.TicketTitle.Width = 96;
            // 
            // TicketDescription
            // 
            this.TicketDescription.HeaderText = "Description";
            this.TicketDescription.MinimumWidth = 6;
            this.TicketDescription.Name = "TicketDescription";
            this.TicketDescription.Width = 125;
            // 
            // TicketCategory
            // 
            this.TicketCategory.HeaderText = "Catégorie";
            this.TicketCategory.Items.AddRange(new object[] {
            "Test",
            "Test1",
            "Test2"});
            this.TicketCategory.MinimumWidth = 6;
            this.TicketCategory.Name = "TicketCategory";
            this.TicketCategory.Width = 125;
            // 
            // TicketState
            // 
            this.TicketState.HeaderText = "État";
            this.TicketState.MinimumWidth = 6;
            this.TicketState.Name = "TicketState";
            this.TicketState.Width = 125;
            // 
            // openingDate
            // 
            this.openingDate.HeaderText = "Date d\'ouverture";
            this.openingDate.Name = "openingDate";
            // 
            // openingPerson
            // 
            this.openingPerson.HeaderText = "Ouvert par";
            this.openingPerson.Name = "openingPerson";
            this.openingPerson.ReadOnly = true;
            // 
            // lastModifiedDate
            // 
            this.lastModifiedDate.HeaderText = "Dernière modification le";
            this.lastModifiedDate.Name = "lastModifiedDate";
            this.lastModifiedDate.ReadOnly = true;
            // 
            // lastModifiedPerson
            // 
            this.lastModifiedPerson.HeaderText = "Modifié par :";
            this.lastModifiedPerson.Name = "lastModifiedPerson";
            this.lastModifiedPerson.ReadOnly = true;
            // 
            // TicketManager
            // 
            this.TicketManager.HeaderText = "Responsable";
            this.TicketManager.MinimumWidth = 6;
            this.TicketManager.Name = "TicketManager";
            this.TicketManager.Width = 125;
            // 
            // FrmViewTtickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 541);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "FrmViewTtickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.FrmViewTtickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketCategory;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketState;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketManager;
    }
}

