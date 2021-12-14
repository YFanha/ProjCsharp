
namespace Création_tickets
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketHour = new System.Windows.Forms.DateTimePicker();
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
            this.ticketType.FormattingEnabled = true;
            this.ticketType.Location = new System.Drawing.Point(191, 161);
            this.ticketType.Name = "ticketType";
            this.ticketType.Size = new System.Drawing.Size(143, 23);
            this.ticketType.TabIndex = 2;
            this.ticketType.Text = "Entrez votre problème";
            this.ticketType.TextChanged += new System.EventHandler(this.onTypeChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nom de l\'incident";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 484);
            this.Controls.Add(this.ticketHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ticketHour;
    }
}

