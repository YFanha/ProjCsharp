
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
            this.TicketManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 60);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Supprimer un ticket";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(377, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter un ticket";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(536, 16);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 60);
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
            this.TicketManager});
            this.dgvTickets.Location = new System.Drawing.Point(14, 187);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 25;
            this.dgvTickets.Size = new System.Drawing.Size(1327, 200);
            this.dgvTickets.TabIndex = 3;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // TicketNumber
            // 
            this.TicketNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketNumber.HeaderText = "Numéro du ticket";
            this.TicketNumber.MinimumWidth = 6;
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.Width = 108;
            // 
            // TicketTitle
            // 
            this.TicketTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketTitle.HeaderText = "Titre du ticket";
            this.TicketTitle.MinimumWidth = 6;
            this.TicketTitle.Name = "TicketTitle";
            this.TicketTitle.Width = 119;
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
            // TicketManager
            // 
            this.TicketManager.HeaderText = "Responsable";
            this.TicketManager.MinimumWidth = 6;
            this.TicketManager.Name = "TicketManager";
            this.TicketManager.Width = 125;
            // 
            // FrmViewTtickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 721);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketManager;
    }
}

