namespace Capítulo_8
{
    partial class MailProperties
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSendType = new System.Windows.Forms.Label();
            this.SendType = new System.Windows.Forms.ComboBox();
            this.MailContent = new System.Windows.Forms.GroupBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.LoadBody = new System.Windows.Forms.Button();
            this.PreviewBody = new System.Windows.Forms.Button();
            this.MailContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSendType
            // 
            this.lblSendType.AutoSize = true;
            this.lblSendType.Location = new System.Drawing.Point(3, 12);
            this.lblSendType.Name = "lblSendType";
            this.lblSendType.Size = new System.Drawing.Size(77, 13);
            this.lblSendType.TabIndex = 0;
            this.lblSendType.Text = "Tipo de envío:";
            // 
            // SendType
            // 
            this.SendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendType.FormattingEnabled = true;
            this.SendType.Location = new System.Drawing.Point(100, 9);
            this.SendType.Name = "SendType";
            this.SendType.Size = new System.Drawing.Size(199, 21);
            this.SendType.TabIndex = 1;
            // 
            // MailContent
            // 
            this.MailContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailContent.Controls.Add(this.PreviewBody);
            this.MailContent.Controls.Add(this.LoadBody);
            this.MailContent.Controls.Add(this.lblBody);
            this.MailContent.Controls.Add(this.textBox1);
            this.MailContent.Controls.Add(this.lblSubject);
            this.MailContent.Enabled = false;
            this.MailContent.Location = new System.Drawing.Point(7, 40);
            this.MailContent.Name = "MailContent";
            this.MailContent.Size = new System.Drawing.Size(299, 105);
            this.MailContent.TabIndex = 2;
            this.MailContent.TabStop = false;
            this.MailContent.Text = "Contenido";
            this.MailContent.Enter += new System.EventHandler(this.MailContent_Enter);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 37);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(41, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Objeto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(6, 74);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(44, 13);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = "Cuerpo:";
            // 
            // LoadBody
            // 
            this.LoadBody.Location = new System.Drawing.Point(93, 69);
            this.LoadBody.Name = "LoadBody";
            this.LoadBody.Size = new System.Drawing.Size(75, 23);
            this.LoadBody.TabIndex = 3;
            this.LoadBody.Text = "Examinar...";
            this.LoadBody.UseVisualStyleBackColor = true;
            // 
            // PreviewBody
            // 
            this.PreviewBody.Location = new System.Drawing.Point(174, 69);
            this.PreviewBody.Name = "PreviewBody";
            this.PreviewBody.Size = new System.Drawing.Size(75, 23);
            this.PreviewBody.TabIndex = 4;
            this.PreviewBody.Text = "Vista Previa";
            this.PreviewBody.UseVisualStyleBackColor = true;
            // 
            // MailProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MailContent);
            this.Controls.Add(this.SendType);
            this.Controls.Add(this.lblSendType);
            this.Name = "MailProperties";
            this.Size = new System.Drawing.Size(316, 154);
            this.MailContent.ResumeLayout(false);
            this.MailContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendType;
        private System.Windows.Forms.ComboBox SendType;
        private System.Windows.Forms.GroupBox MailContent;
        private System.Windows.Forms.Button PreviewBody;
        private System.Windows.Forms.Button LoadBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSubject;
    }
}
