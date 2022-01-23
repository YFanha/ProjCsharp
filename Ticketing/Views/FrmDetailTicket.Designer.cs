
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStateTicket = new System.Windows.Forms.Label();
            this.lblTicketOpenBy = new System.Windows.Forms.Label();
            this.lblTicketLastEdit = new System.Windows.Forms.Label();
            this.lblTicketEditBy = new System.Windows.Forms.Label();
            this.lblTicketManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfirmMessage
            // 
            this.lblConfirmMessage.AutoSize = true;
            this.lblConfirmMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmMessage.Location = new System.Drawing.Point(26, 45);
            this.lblConfirmMessage.Name = "lblConfirmMessage";
            this.lblConfirmMessage.Size = new System.Drawing.Size(219, 32);
            this.lblConfirmMessage.TabIndex = 1;
            this.lblConfirmMessage.Text = "Détail du ticket n°";
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketId.Location = new System.Drawing.Point(213, 51);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(34, 25);
            this.lblTicketId.TabIndex = 7;
            this.lblTicketId.Text = "##";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateValue.Location = new System.Drawing.Point(185, 184);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(63, 25);
            this.lblDateValue.TabIndex = 14;
            this.lblDateValue.Text = "label7";
            // 
            // lblProblemTypeValue
            // 
            this.lblProblemTypeValue.AutoSize = true;
            this.lblProblemTypeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTypeValue.Location = new System.Drawing.Point(193, 151);
            this.lblProblemTypeValue.Name = "lblProblemTypeValue";
            this.lblProblemTypeValue.Size = new System.Drawing.Size(63, 25);
            this.lblProblemTypeValue.TabIndex = 13;
            this.lblProblemTypeValue.Text = "label7";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleValue.Location = new System.Drawing.Point(103, 115);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(44, 25);
            this.lblTitleValue.TabIndex = 12;
            this.lblTitleValue.Text = "title";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(25, 184);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 25);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date de la panne :";
            // 
            // lblProblemType
            // 
            this.lblProblemType.AutoSize = true;
            this.lblProblemType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemType.Location = new System.Drawing.Point(24, 151);
            this.lblProblemType.Name = "lblProblemType";
            this.lblProblemType.Size = new System.Drawing.Size(182, 25);
            this.lblProblemType.TabIndex = 10;
            this.lblProblemType.Text = "Type de problème :";
            // 
            // lblProblemTitle
            // 
            this.lblProblemTitle.AutoSize = true;
            this.lblProblemTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTitle.Location = new System.Drawing.Point(24, 115);
            this.lblProblemTitle.Name = "lblProblemTitle";
            this.lblProblemTitle.Size = new System.Drawing.Size(68, 25);
            this.lblProblemTitle.TabIndex = 9;
            this.lblProblemTitle.Text = "Titre : ";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Location = new System.Drawing.Point(26, 507);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(437, 229);
            this.rtxtDescription.TabIndex = 16;
            this.rtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(26, 476);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 25);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Location = new System.Drawing.Point(346, 741);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(118, 37);
            this.btnCloseApp.TabIndex = 24;
            this.btnCloseApp.Text = "Fermer";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTicket.Location = new System.Drawing.Point(10, 741);
            this.btnRemoveTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(118, 37);
            this.btnRemoveTicket.TabIndex = 25;
            this.btnRemoveTicket.Text = "Supprimer ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "État du ticket :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ouvert par :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date de la dernière modification :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Modifié par :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Responsable :";
            // 
            // lblStateTicket
            // 
            this.lblStateTicket.AutoSize = true;
            this.lblStateTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStateTicket.Location = new System.Drawing.Point(174, 224);
            this.lblStateTicket.Name = "lblStateTicket";
            this.lblStateTicket.Size = new System.Drawing.Size(63, 25);
            this.lblStateTicket.TabIndex = 31;
            this.lblStateTicket.Text = "label7";
            // 
            // lblTicketOpenBy
            // 
            this.lblTicketOpenBy.AutoSize = true;
            this.lblTicketOpenBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketOpenBy.Location = new System.Drawing.Point(149, 268);
            this.lblTicketOpenBy.Name = "lblTicketOpenBy";
            this.lblTicketOpenBy.Size = new System.Drawing.Size(63, 25);
            this.lblTicketOpenBy.TabIndex = 32;
            this.lblTicketOpenBy.Text = "label7";
            // 
            // lblTicketLastEdit
            // 
            this.lblTicketLastEdit.AutoSize = true;
            this.lblTicketLastEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketLastEdit.Location = new System.Drawing.Point(310, 312);
            this.lblTicketLastEdit.Name = "lblTicketLastEdit";
            this.lblTicketLastEdit.Size = new System.Drawing.Size(63, 25);
            this.lblTicketLastEdit.TabIndex = 33;
            this.lblTicketLastEdit.Text = "label7";
            // 
            // lblTicketEditBy
            // 
            this.lblTicketEditBy.AutoSize = true;
            this.lblTicketEditBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketEditBy.Location = new System.Drawing.Point(145, 352);
            this.lblTicketEditBy.Name = "lblTicketEditBy";
            this.lblTicketEditBy.Size = new System.Drawing.Size(63, 25);
            this.lblTicketEditBy.TabIndex = 34;
            this.lblTicketEditBy.Text = "label7";
            // 
            // lblTicketManager
            // 
            this.lblTicketManager.AutoSize = true;
            this.lblTicketManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketManager.Location = new System.Drawing.Point(149, 393);
            this.lblTicketManager.Name = "lblTicketManager";
            this.lblTicketManager.Size = new System.Drawing.Size(63, 25);
            this.lblTicketManager.TabIndex = 35;
            this.lblTicketManager.Text = "label7";
            // 
            // FrmDetailTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 781);
            this.Controls.Add(this.lblTicketManager);
            this.Controls.Add(this.lblTicketEditBy);
            this.Controls.Add(this.lblTicketLastEdit);
            this.Controls.Add(this.lblTicketOpenBy);
            this.Controls.Add(this.lblStateTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStateTicket;
        private System.Windows.Forms.Label lblTicketOpenBy;
        private System.Windows.Forms.Label lblTicketLastEdit;
        private System.Windows.Forms.Label lblTicketEditBy;
        private System.Windows.Forms.Label lblTicketManager;
    }
}