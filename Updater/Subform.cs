using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class Subform : Form
    {
        private NotifyIcon notifyIcon;
        public Subform(NotifyIcon notifyIcon)
        {
            InitializeComponent();
            this.notifyIcon = notifyIcon;
        }
        private void Subform_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hide the form and show the NotifyIcon
            e.Cancel = true;
            this.Hide();
            notifyIcon.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
