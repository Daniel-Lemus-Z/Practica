using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capítulo_8
{
    public partial class MailServerSettings : Form
    {

        public MailServerSettings()
        {
            InitializeComponent();

            CustomControl C = new CustomControl();
            C.Location = new System.Drawing.Point(0, 0);
            C.Size = this.Size;
            this.Controls.Add(C);

        }

        private void Validar_Click(object sender, EventArgs e)
        {

        }

        private void FromEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"ˆ([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                    @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                    @"(([a-zA-Z0-9\-]+\.)+))" +
                    @"([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.FromEmail.Text))
            {
                this.errorProvider.SetError(this.FromEmail, "El formato de email es incorrecto");
                e.Cancel = true;
            }
        }

        void Valid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Host.Text))
                this.errorProvider.SetError(this.Host, "Se debe rellenar el campo de host");
        }
       
    }
}
