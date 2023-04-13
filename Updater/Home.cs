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
    public partial class Home : Form
    {
        private NotifyIcon notifyIcon;
        public Home()
        {
            InitializeComponent();

            // Create the NotifyIcon object
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("icons8-package-32.ico");
            notifyIcon.Text = "My Application";
            notifyIcon.Visible = true;

            // Add event handlers to the NotifyIcon
            notifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
            ContextMenu menu = new ContextMenu();
            MenuItem showMenuItem = new MenuItem("Show");
            showMenuItem.Click += new EventHandler(ShowMenuItem_Click);
            menu.MenuItems.Add(showMenuItem);
            MenuItem exitMenuItem = new MenuItem("Exit");
            exitMenuItem.Click += new EventHandler(ExitMenuItem_Click);
            menu.MenuItems.Add(exitMenuItem);
            notifyIcon.ContextMenu = menu;

            // Set the form's properties
            this.Text = "My Application";
            this.Resize += new EventHandler(Home_Resize);
            this.ShowInTaskbar = false;
        }
        private void ExitMenuItem_Click(Object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void Home_Resize(Object sender, EventArgs e)
        {
            // If the form is being minimized, hide it and show the NotifyIcon
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DoubleClick(Object sender, EventArgs e)
        {
            // Show the form and hide the NotifyIcon
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void ShowMenuItem_Click(Object sender, EventArgs e)
        {
            // Show the form and hide the NotifyIcon
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subform subform = new Subform(notifyIcon);
            subform.Show();
        }
    }
}
