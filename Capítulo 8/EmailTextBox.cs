using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capítulo_8
{
    public class EmailTextBox : TextBox
    {
        protected Color PreviousBackColor { get; set; }

        public EmailTextBox()
        {
            this.PreviousBackColor = this.BackColor;
        }

        protected override void
         OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
            string pattern = @"ˆ([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                             @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                             @"(([a-zA-Z0-9\-]+\.)+))" +
                             @"([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.Text))
            {
                this.BackColor = Color.Bisque;
                e.Cancel = true;
            }
            else
                this.BackColor = this.PreviousBackColor;
        }
    }
}
