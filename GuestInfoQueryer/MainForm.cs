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

        private SybaseQueryer sybaseQueryer;
        private string _hostName;
        private string _userName;
        private string _password;
        private int _port;
        private string _charset;
        private string _database;
        private DataTable _dataTable;

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
            _DebugCount = 0;
            TextBox_QueryString.Visible = false;
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
            _hostName = TextBox_Server.Text;
            _userName = TextBox_Username.Text;
            _password = TextBox_Password.Text;
            bool result = int.TryParse(TextBox_Port.Text, out _port);
            if(result == false)
            {
                _port = 5000;
            }
            _database = TextBox_Database.Text;
            _charset = TextBox_Charset.Text;
        }
        
        private void Btn_TestConnection_Click(object sender, EventArgs e)
        {
            string msg = "";
            SybaseQueryer queryer = new SybaseQueryer(TextBox_Server.Text, TextBox_Username.Text, TextBox_Password.Text);
            if(queryer.TestConnection(out msg))
            {
                Lbl_TestResult.Text = "连接成功。";
                Lbl_TestResult.ForeColor = Color.Green;
            }
            else
            {
                Lbl_TestResult.Text = "连接失败！" + msg;
                Lbl_TestResult.ForeColor = Color.Red;
            }

        }

        private void Btn_Query_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if(Panel_Home.Visible == false)
            {
                Btn_Home.PerformClick();
            }

            try
            {
                sybaseQueryer = new SybaseQueryer(_hostName, _userName, _password, _port, _database, _charset);
                sybaseQueryer.Connect();
                _dataTable = sybaseQueryer.Query(TextBox_QueryString.Text);
                FillListView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FillListView()
        {
            int number = 0;
            for(int i = 0; i < _dataTable.Columns.Count; i++)
            {
                listView1.Columns.Add(_dataTable.Columns[i].ColumnName);
            }
            ListViewItem mainItem;
            for(int i = 0; i < _dataTable.Rows.Count; i++)
            {
                mainItem = listView1.Items.Add((++number).ToString());
                for(int j = 0; j < _dataTable.Columns.Count; j++)
                {
                    mainItem.SubItems.Add(_dataTable.Rows[i][j].ToString());
                }
            }
        }

        private int _DebugCount = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _DebugCount++;
            if(_DebugCount >= 10)
            {
                TextBox_QueryString.Visible = true;
            }
        }
    }
}
