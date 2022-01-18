
namespace Ticketing
{
    partial class FrmDetailTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConfirmMessage = new System.Windows.Forms.Label();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblProblemTypeValue = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProblemType = new System.Windows.Forms.Label();
            this.lblProblemTitle = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmMessage
            // 
            this.lblConfirmMessage.AutoSize = true;
            this.lblConfirmMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmMessage.Location = new System.Drawing.Point(23, 34);
            this.lblConfirmMessage.Name = "lblConfirmMessage";
            this.lblConfirmMessage.Size = new System.Drawing.Size(170, 25);
            this.lblConfirmMessage.TabIndex = 1;
            this.lblConfirmMessage.Text = "Détail du ticket n°";
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketId.Location = new System.Drawing.Point(186, 38);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(27, 20);
            this.lblTicketId.TabIndex = 7;
            this.lblTicketId.Text = "##";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateValue.Location = new System.Drawing.Point(162, 138);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(50, 20);
            this.lblDateValue.TabIndex = 14;
            this.lblDateValue.Text = "label7";
            // 
            // lblProblemTypeValue
            // 
            this.lblProblemTypeValue.AutoSize = true;
            this.lblProblemTypeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTypeValue.Location = new System.Drawing.Point(169, 113);
            this.lblProblemTypeValue.Name = "lblProblemTypeValue";
            this.lblProblemTypeValue.Size = new System.Drawing.Size(50, 20);
            this.lblProblemTypeValue.TabIndex = 13;
            this.lblProblemTypeValue.Text = "label7";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleValue.Location = new System.Drawing.Point(90, 86);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(35, 20);
            this.lblTitleValue.TabIndex = 12;
            this.lblTitleValue.Text = "title";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(22, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 20);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date de la panne :";
            // 
            // lblProblemType
            // 
            this.lblProblemType.AutoSize = true;
            this.lblProblemType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemType.Location = new System.Drawing.Point(21, 113);
            this.lblProblemType.Name = "lblProblemType";
            this.lblProblemType.Size = new System.Drawing.Size(142, 20);
            this.lblProblemType.TabIndex = 10;
            this.lblProblemType.Text = "Type de problème :";
            // 
            // lblProblemTitle
            // 
            this.lblProblemTitle.AutoSize = true;
            this.lblProblemTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTitle.Location = new System.Drawing.Point(21, 86);
            this.lblProblemTitle.Name = "lblProblemTitle";
            this.lblProblemTitle.Size = new System.Drawing.Size(54, 20);
            this.lblProblemTitle.TabIndex = 9;
            this.lblProblemTitle.Text = "Titre : ";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Location = new System.Drawing.Point(23, 217);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(412, 200);
            this.rtxtDescription.TabIndex = 16;
            this.rtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(23, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Location = new System.Drawing.Point(332, 420);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(103, 28);
            this.btnCloseApp.TabIndex = 24;
            this.btnCloseApp.Text = "Fermer";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTicket.Location = new System.Drawing.Point(9, 420);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(103, 28);
            this.btnRemoveTicket.TabIndex = 25;
            this.btnRemoveTicket.Text = "Supprimer ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            // 
            // FrmDetailTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnRemoveTicket);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateValue);
            this.Controls.Add(this.lblProblemTypeValue);
            this.Controls.Add(this.lblTitleValue);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProblemType);
            this.Controls.Add(this.lblProblemTitle);
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.lblConfirmMessage);
            this.Name = "FrmDetailTicket";
            this.Text = "Détail du ticket";
            this.Load += new System.EventHandler(this.FrmDetailTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmMessage;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblProblemTypeValue;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProblemType;
        private System.Windows.Forms.Label lblProblemTitle;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnRemoveTicket;
    }
}