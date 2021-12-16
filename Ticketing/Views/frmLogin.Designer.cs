
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
            this.txtboxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxLogin.Location = new System.Drawing.Point(283, 121);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(209, 29);
            this.txtboxLogin.TabIndex = 1;
            this.txtboxLogin.Text = "Email";
            this.txtboxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxPassword.Location = new System.Drawing.Point(283, 192);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(209, 29);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.Text = "Mot de passe";
            this.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnexion.Location = new System.Drawing.Point(283, 280);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(209, 39);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(12, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fermer";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConnectionError
            // 
            this.lblConnectionError.AutoSize = true;
            this.lblConnectionError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Location = new System.Drawing.Point(283, 224);
            this.lblConnectionError.Name = "lblConnectionError";
            this.lblConnectionError.Size = new System.Drawing.Size(0, 15);
            this.lblConnectionError.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConnectionError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxLogin);
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