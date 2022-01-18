
namespace Ticketing
{
    partial class frmTicket
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ticketType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ticketDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketHour = new System.Windows.Forms.DateTimePicker();
            this.lblConfirmMessage = new System.Windows.Forms.Label();
            this.lblProblemTitle = new System.Windows.Forms.Label();
            this.lblProblemType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblProblemTypeValue = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.grpBoxConfirmMsg = new System.Windows.Forms.GroupBox();
            this.grpBoxConfirmMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(36, 161);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 0;
            this.txbName.TextChanged += new System.EventHandler(this.onNameChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(109, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Création de tickets";
            // 
            // ticketType
            // 
            this.ticketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketType.Location = new System.Drawing.Point(191, 161);
            this.ticketType.Name = "ticketType";
            this.ticketType.Size = new System.Drawing.Size(143, 23);
            this.ticketType.TabIndex = 2;
            this.ticketType.TextChanged += new System.EventHandler(this.onTypeChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Titre du problème";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type de problème";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 454);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ticketDate
            // 
            this.ticketDate.Location = new System.Drawing.Point(268, 234);
            this.ticketDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ticketDate.Name = "ticketDate";
            this.ticketDate.ShowToday = false;
            this.ticketDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date de la panne";
            // 
            // ticketDesc
            // 
            this.ticketDesc.Location = new System.Drawing.Point(34, 234);
            this.ticketDesc.MaxLength = 300;
            this.ticketDesc.Name = "ticketDesc";
            this.ticketDesc.Size = new System.Drawing.Size(222, 164);
            this.ticketDesc.TabIndex = 12;
            this.ticketDesc.Text = "";
            this.ticketDesc.TextChanged += new System.EventHandler(this.rtxbDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description du problème";
            // 
            // lblCaractere
            // 
            this.lblCaractere.AutoSize = true;
            this.lblCaractere.Location = new System.Drawing.Point(34, 402);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(13, 15);
            this.lblCaractere.TabIndex = 14;
            this.lblCaractere.Text = "0";
            this.lblCaractere.Click += new System.EventHandler(this.lblCaractere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "caractères max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "/ 300";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(181, 454);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Heure de la panne";
            // 
            // ticketHour
            // 
            this.ticketHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ticketHour.Location = new System.Drawing.Point(364, 161);
            this.ticketHour.Name = "ticketHour";
            this.ticketHour.ShowUpDown = true;
            this.ticketHour.Size = new System.Drawing.Size(103, 23);
            this.ticketHour.TabIndex = 19;
            this.ticketHour.TabStop = false;
            // 
            // lblConfirmMessage
            // 
            this.lblConfirmMessage.AutoSize = true;
            this.lblConfirmMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmMessage.Location = new System.Drawing.Point(32, 47);
            this.lblConfirmMessage.Name = "lblConfirmMessage";
            this.lblConfirmMessage.Size = new System.Drawing.Size(280, 25);
            this.lblConfirmMessage.TabIndex = 0;
            this.lblConfirmMessage.Text = "Votre ticket a bien été envoyé.";
            // 
            // lblProblemTitle
            // 
            this.lblProblemTitle.AutoSize = true;
            this.lblProblemTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemTitle.Location = new System.Drawing.Point(34, 110);
            this.lblProblemTitle.Name = "lblProblemTitle";
            this.lblProblemTitle.Size = new System.Drawing.Size(54, 20);
            this.lblProblemTitle.TabIndex = 1;
            this.lblProblemTitle.Text = "Titre : ";
            this.lblProblemTitle.Click += new System.EventHandler(this.lblProblemTitle_Click);
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
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Location = new System.Drawing.Point(32, 250);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(446, 205);
            this.rtxtDescription.TabIndex = 5;
            this.rtxtDescription.Text = "";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleValue.Location = new System.Drawing.Point(101, 110);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(35, 20);
            this.lblTitleValue.TabIndex = 6;
            this.lblTitleValue.Text = "title";
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
            // btnNewTicket
            // 
            this.btnNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTicket.Location = new System.Drawing.Point(31, 458);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(103, 28);
            this.btnNewTicket.TabIndex = 22;
            this.btnNewTicket.Text = "Nouveau ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Location = new System.Drawing.Point(375, 458);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(103, 28);
            this.btnCloseApp.TabIndex = 23;
            this.btnCloseApp.Text = "Fermer";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
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
            this.grpBoxConfirmMsg.Location = new System.Drawing.Point(2, 0);
            this.grpBoxConfirmMsg.Name = "grpBoxConfirmMsg";
            this.grpBoxConfirmMsg.Size = new System.Drawing.Size(513, 492);
            this.grpBoxConfirmMsg.TabIndex = 21;
            this.grpBoxConfirmMsg.TabStop = false;
            this.grpBoxConfirmMsg.Visible = false;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 492);
            this.Controls.Add(this.grpBoxConfirmMsg);
            this.Controls.Add(this.ticketHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ticketType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbName);
            this.Name = "frmTicket";
            this.Text = "Création de tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxConfirmMsg.ResumeLayout(false);
            this.grpBoxConfirmMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ticketType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MonthCalendar ticketDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ticketDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ticketHour;
        private System.Windows.Forms.Label lblConfirmMessage;
        private System.Windows.Forms.Label lblProblemTitle;
        private System.Windows.Forms.Label lblProblemType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblProblemTypeValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.GroupBox grpBoxConfirmMsg;
    }
}

