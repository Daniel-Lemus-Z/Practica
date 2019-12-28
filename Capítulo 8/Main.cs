using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capítulo_8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.CreateDefaultTab();
        }

        private void servidorMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MailServerSettings().ShowDialog();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CreateDefaultTab()
        {
            MailProperties MP = new MailProperties();
            MP.Name = "mailProperties";
            MP.Dock = DockStyle.Fill;
            TabPage tp = new TabPage("[ningún idioma]");
            tp.Controls.Add(MP);
            //this.MainTab.TabPages.Add(tp);


        }
    }
}
