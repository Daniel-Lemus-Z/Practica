namespace Capítulo_8
{
    partial class MailServerSettings
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
            this.components = new System.ComponentModel.Container();
            this.lblFromName = new System.Windows.Forms.Label();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.FromName = new System.Windows.Forms.TextBox();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.Anular = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Location = new System.Drawing.Point(12, 9);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(71, 13);
            this.lblFromName.TabIndex = 7;
            this.lblFromName.Text = "Nombre Exp.:";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(12, 31);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(59, 13);
            this.lblFromEmail.TabIndex = 8;
            this.lblFromEmail.Text = "Email Exp.:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 57);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 9;
            this.lblHost.Text = "Host:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña:";
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(121, 2);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(190, 20);
            this.FromName.TabIndex = 0;
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(121, 28);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(190, 20);
            this.FromEmail.TabIndex = 1;
            this.FromEmail.TextChanged += new System.EventHandler(this.FromEmail_TextChanged);
            this.FromEmail.Validating += new System.ComponentModel.CancelEventHandler(this.FromEmail_Validating);
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(121, 54);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(190, 20);
            this.Host.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(121, 80);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(190, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(121, 106);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(190, 20);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(155, 132);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(75, 23);
            this.Validar.TabIndex = 5;
            this.Validar.Text = "Aceptar";
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Anular
            // 
            this.Anular.Location = new System.Drawing.Point(236, 132);
            this.Anular.Name = "Anular";
            this.Anular.Size = new System.Drawing.Size(75, 23);
            this.Anular.TabIndex = 6;
            this.Anular.Text = "Cancelar";
            this.Anular.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MailServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 162);
            this.Controls.Add(this.Anular);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.FromName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblFromEmail);
            this.Controls.Add(this.lblFromName);
            this.Controls.Add(this.FromEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailServerSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parámetros del servidor mail";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Validar;
        private System.Windows.Forms.Button Anular;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}