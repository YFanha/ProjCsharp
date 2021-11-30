
namespace Ticketing
{
    partial class View_tickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketCategories = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TicketState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppellantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketNumber,
            this.TicketDescription,
            this.TicketTitle,
            this.TicketCategories,
            this.TicketState,
            this.AppellantName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // TicketNumber
            // 
            this.TicketNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketNumber.HeaderText = "Numéro du ticket";
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.Width = 88;
            // 
            // TicketDescription
            // 
            this.TicketDescription.HeaderText = "Description";
            this.TicketDescription.Name = "TicketDescription";
            // 
            // TicketTitle
            // 
            this.TicketTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TicketTitle.HeaderText = "Titre du ticket";
            this.TicketTitle.Name = "TicketTitle";
            this.TicketTitle.Width = 96;
            // 
            // TicketCategories
            // 
            this.TicketCategories.HeaderText = "Categorie";
            this.TicketCategories.Name = "TicketCategories";
            // 
            // TicketState
            // 
            this.TicketState.HeaderText = "État du ticket";
            this.TicketState.Name = "TicketState";
            // 
            // AppellantName
            // 
            this.AppellantName.HeaderText = "Nom de l\'appelant";
            this.AppellantName.Name = "AppellantName";
            // 
            // View_tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "View_tickets";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketCategories;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketState;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppellantName;
    }
}

