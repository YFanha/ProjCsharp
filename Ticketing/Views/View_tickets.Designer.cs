
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewTtickets));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.cmbStateChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblReload = new System.Windows.Forms.Label();
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter un ticket";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(469, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Se déconnecter";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTickets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvTickets.Location = new System.Drawing.Point(-1, 140);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 25;
            this.dgvTickets.Size = new System.Drawing.Size(1213, 704);
            this.dgvTickets.TabIndex = 3;
            this.dgvTickets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTickets_CellMouseDoubleClick);
            this.dgvTickets.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellValueChanged);
            this.dgvTickets.SelectionChanged += new System.EventHandler(this.dgvTickets_SelectionChanged);
            // 
            // cmbStateChoice
            // 
            this.cmbStateChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStateChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStateChoice.FormattingEnabled = true;
            this.cmbStateChoice.Location = new System.Drawing.Point(1026, 19);
            this.cmbStateChoice.Name = "cmbStateChoice";
            this.cmbStateChoice.Size = new System.Drawing.Size(147, 29);
            this.cmbStateChoice.TabIndex = 4;
            this.cmbStateChoice.SelectedIndexChanged += new System.EventHandler(this.cmbStateChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(977, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "État :";
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(63, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(54, 54);
            this.btnReload.TabIndex = 6;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.Location = new System.Drawing.Point(63, 69);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(59, 15);
            this.lblReload.TabIndex = 7;
            this.lblReload.Text = "Actualiser";
            // 
            // TicketNumber
            // 
            this.TicketNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketNumber.HeaderText = "Numéro du ticket";
            this.TicketNumber.MinimumWidth = 6;
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.ReadOnly = true;
            this.TicketNumber.Width = 88;
            // 
            // TicketTitle
            // 
            this.TicketTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketTitle.HeaderText = "Titre du ticket";
            this.TicketTitle.MinimumWidth = 6;
            this.TicketTitle.Name = "TicketTitle";
            this.TicketTitle.ReadOnly = true;
            this.TicketTitle.Width = 96;
            // 
            // TicketDescription
            // 
            this.TicketDescription.HeaderText = "Description";
            this.TicketDescription.MinimumWidth = 6;
            this.TicketDescription.Name = "TicketDescription";
            // 
            // TicketCategory
            // 
            this.TicketCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TicketCategory.HeaderText = "Catégorie";
            this.TicketCategory.MinimumWidth = 6;
            this.TicketCategory.Name = "TicketCategory";
            // 
            // TicketState
            // 
            this.TicketState.HeaderText = "État";
            this.TicketState.MinimumWidth = 6;
            this.TicketState.Name = "TicketState";
            // 
            // openingDate
            // 
            this.openingDate.HeaderText = "Date d\'ouverture";
            this.openingDate.Name = "openingDate";
            this.openingDate.ReadOnly = true;
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
            this.TicketManager.ReadOnly = true;
            // 
            // FrmViewTtickets
            // 
            this.AcceptButton = this.btnReload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 541);
            this.Controls.Add(this.lblReload);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStateChoice);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "FrmViewTtickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.FrmViewTtickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.ComboBox cmbStateChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblReload;
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

