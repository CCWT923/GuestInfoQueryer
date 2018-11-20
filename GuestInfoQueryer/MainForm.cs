using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuestInfoQueryer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_MaxSize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private SybaseQueryer sybaseQueryer;
        private String hostName;
        private string userName;
        private string password;

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Panel_SideDecoration.Top = Btn_Settings.Top;
            Panel_Settings.Visible = true;
            Panel_Settings.BringToFront();
            Panel_About.Visible = false;
            Panel_Home.Visible = false;
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Panel_SideDecoration.Top = Btn_About.Top;
            Panel_About.BringToFront();
            Panel_About.Visible = true;
            Panel_Home.Visible = false;
            Panel_Settings.Visible = false;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Panel_SideDecoration.Top = Btn_Home.Top;
            Panel_Home.Visible = true;
            Panel_Home.BringToFront();
            Panel_Settings.Visible = false;
            Panel_About.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Panel_SideDecoration.Top = Btn_Home.Top;
            Panel_SideDecoration.Left = 0;
            Panel_Home.Dock = DockStyle.Fill;
            Panel_About.Dock = DockStyle.Fill;
            Panel_Settings.Dock = DockStyle.Fill;
            Panel_About.Visible = false;
            Panel_Settings.Visible = false;
        }
    }
}
