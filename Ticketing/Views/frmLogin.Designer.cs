
namespace Ticketing
{
    partial class FrmLogin
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
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblConnectionError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxLogin.Location = new System.Drawing.Point(323, 161);
            this.txtboxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(238, 34);
            this.txtboxLogin.TabIndex = 1;
            this.txtboxLogin.Text = "Email";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxPassword.Location = new System.Drawing.Point(323, 256);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(238, 34);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.Text = "Mot de passe";
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnexion.Location = new System.Drawing.Point(323, 373);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(239, 52);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(14, 549);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fermer";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConnectionError
            // 
            this.lblConnectionError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnectionError.AutoSize = true;
            this.lblConnectionError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Location = new System.Drawing.Point(323, 299);
            this.lblConnectionError.Name = "lblConnectionError";
            this.lblConnectionError.Size = new System.Drawing.Size(0, 20);
            this.lblConnectionError.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblConnectionError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblConnectionError;
    }
}