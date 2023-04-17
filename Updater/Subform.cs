using LiveCharts;
using LiveCharts.Wpf;
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
        public Subform()
        {
            InitializeComponent();
            
        }
        private void Subform_Load(object sender, EventArgs e)
        {
            
        }
        // button Back to Home
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
