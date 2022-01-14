
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
            this.cmbStateChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblReload = new System.Windows.Forms.Label();
            this.grpBoxConfirmMsg = new System.Windows.Forms.GroupBox();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblProblemTypeValue = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProblemType = new System.Windows.Forms.Label();
            this.lblProblemTitle = new System.Windows.Forms.Label();
            this.lblConfirmMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.grpBoxConfirmMsg.SuspendLayout();
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
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            this.dgvTickets.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellValueChanged);
            this.dgvTickets.SelectionChanged += new System.EventHandler(this.dgvTickets_SelectionChanged);
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
            // 
            // openingPerson
            // 
            this.openingPerson.HeaderText = "Ouvert par";
            this.openingPerson.Name = "openingPerson";
            // 
            // lastModifiedDate
            // 
            this.lastModifiedDate.HeaderText = "Dernière modification le";
            this.lastModifiedDate.Name = "lastModifiedDate";
            // 
            // lastModifiedPerson
            // 
            this.lastModifiedPerson.HeaderText = "Modifié par :";
            this.lastModifiedPerson.Name = "lastModifiedPerson";
            // 
            // TicketManager
            // 
            this.TicketManager.HeaderText = "Responsable";
            this.TicketManager.MinimumWidth = 6;
            this.TicketManager.Name = "TicketManager";
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
            // grpBoxConfirmMsg
            // 
            this.grpBoxConfirmMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxConfirmMsg.Controls.Add(this.btnCloseApp);
            this.grpBoxConfirmMsg.Controls.Add(this.btnNewTicket);
            this.grpBoxConfirmMsg.Controls.Add(this.lblDateValue);
            this.grpBoxConfirmMsg.Controls.Add(this.lblProblemTypeValue);
            this.grpBoxConfirmMsg.Controls.Add(this.lblTitleValue);
            this.grpBoxConfirmMsg.Controls.Add(this.rtxtDescription);
            this.grpBoxConfirmMsg.Controls.Add(this.lblDescription);
            this.grpBoxConfirmMsg.Controls.Add(this.lblDate);
            this.grpBoxConfirmMsg.Controls.Add(this.lblProblemType);
            this.grpBoxConfirmMsg.Controls.Add(this.lblProblemTitle);
            this.grpBoxConfirmMsg.Controls.Add(this.lblConfirmMessage);
            this.grpBoxConfirmMsg.Location = new System.Drawing.Point(228, 12);
            this.grpBoxConfirmMsg.Name = "grpBoxConfirmMsg";
            this.grpBoxConfirmMsg.Size = new System.Drawing.Size(753, 490);
            this.grpBoxConfirmMsg.TabIndex = 22;
            this.grpBoxConfirmMsg.TabStop = false;
            this.grpBoxConfirmMsg.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Location = new System.Drawing.Point(928, 846);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(103, 28);
            this.btnCloseApp.TabIndex = 23;
            this.btnCloseApp.Text = "Fermer";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTicket.Location = new System.Drawing.Point(31, 846);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(103, 28);
            this.btnNewTicket.TabIndex = 22;
            this.btnNewTicket.Text = "Nouveau ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateValue.Location = new System.Drawing.Point(173, 162);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(50, 20);
            this.lblDateValue.TabIndex = 8;
            this.lblDateValue.Text = "label7";
            // 
            // lblProblemTypeValue
            // 
            this.lblProblemTypeValue.AutoSize = true;
            this.lblProblemTypeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTypeValue.Location = new System.Drawing.Point(180, 137);
            this.lblProblemTypeValue.Name = "lblProblemTypeValue";
            this.lblProblemTypeValue.Size = new System.Drawing.Size(50, 20);
            this.lblProblemTypeValue.TabIndex = 7;
            this.lblProblemTypeValue.Text = "label7";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleValue.Location = new System.Drawing.Point(85, 110);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(0, 20);
            this.lblTitleValue.TabIndex = 6;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Location = new System.Drawing.Point(32, 234);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(700, 235);
            this.rtxtDescription.TabIndex = 5;
            this.rtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(32, 211);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(33, 162);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de la panne :";
            // 
            // lblProblemType
            // 
            this.lblProblemType.AutoSize = true;
            this.lblProblemType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemType.Location = new System.Drawing.Point(32, 137);
            this.lblProblemType.Name = "lblProblemType";
            this.lblProblemType.Size = new System.Drawing.Size(142, 20);
            this.lblProblemType.TabIndex = 2;
            this.lblProblemType.Text = "Type de problème :";
            // 
            // lblProblemTitle
            // 
            this.lblProblemTitle.AutoSize = true;
            this.lblProblemTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTitle.Location = new System.Drawing.Point(32, 110);
            this.lblProblemTitle.Name = "lblProblemTitle";
            this.lblProblemTitle.Size = new System.Drawing.Size(54, 20);
            this.lblProblemTitle.TabIndex = 1;
            this.lblProblemTitle.Text = "Titre : ";
            // 
            // lblConfirmMessage
            // 
            this.lblConfirmMessage.AutoSize = true;
            this.lblConfirmMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmMessage.Location = new System.Drawing.Point(32, 47);
            this.lblConfirmMessage.Name = "lblConfirmMessage";
            this.lblConfirmMessage.Size = new System.Drawing.Size(65, 25);
            this.lblConfirmMessage.TabIndex = 0;
            this.lblConfirmMessage.Text = "Ticket";
            // 
            // FrmViewTtickets
            // 
            this.AcceptButton = this.btnReload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 541);
            this.Controls.Add(this.grpBoxConfirmMsg);
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
            this.grpBoxConfirmMsg.ResumeLayout(false);
            this.grpBoxConfirmMsg.PerformLayout();
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
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblReload;
        private System.Windows.Forms.GroupBox grpBoxConfirmMsg;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblProblemTypeValue;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProblemType;
        private System.Windows.Forms.Label lblProblemTitle;
        private System.Windows.Forms.Label lblConfirmMessage;
    }
}

