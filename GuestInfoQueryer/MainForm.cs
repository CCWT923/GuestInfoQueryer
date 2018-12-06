using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

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
        /// <summary>
        /// ping测试一个IP地址
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private bool PingTest(string ip)
        {
            PingReply pingReplay;
            Ping ping = new Ping();
            pingReplay = ping.Send(ip, 2000);
            if(pingReplay.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn_TestConnection_Click(object sender, EventArgs e)
        {
            Btn_TestConnection.Enabled = false;
            if(PingTest(TextBox_Server.Text))
            {
                string msg = "";
                SybaseQueryer queryer = new SybaseQueryer(TextBox_Server.Text, TextBox_Username.Text, TextBox_Password.Text);
                if (queryer.TestConnection(out msg))
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
            else
            {
                Lbl_TestResult.Text = "连接失败！";
                Lbl_TestResult.ForeColor = Color.Red;
            }

            Btn_TestConnection.Enabled = true;
        }

        private void Btn_Query_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            if(Panel_Home.Visible == false)
            {
                Btn_Home.PerformClick();
            }

            try
            {
                sybaseQueryer = new SybaseQueryer(_hostName, _userName, _password, _port, _database, _charset);
                sybaseQueryer.Connect();
                _dataTable = sybaseQueryer.Query(Util.EncodingString(TextBox_QueryString.Text,sybaseQueryer.Charset,Encoding.Default.HeaderName));
                FillListView();
                sybaseQueryer.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// 向ListView中填充数据
        /// </summary>
        private void FillListView()
        {
            int number = 0;
            listView1.BeginUpdate();
            listView1.Columns.Add("#");
            for(int i = 0; i < _dataTable.Columns.Count; i++)
            {
                listView1.Columns.Add(Util.EncodingString(_dataTable.Columns[i].ColumnName, Encoding.Default.HeaderName, sybaseQueryer.Charset));
            }
            ListViewItem mainItem;
            //string tmp = "";
            for(int i = 0; i < _dataTable.Rows.Count; i++)
            {
                mainItem = listView1.Items.Add((++number).ToString());
                for(int j = 0; j < _dataTable.Columns.Count; j++)
                {
                    mainItem.SubItems.Add(Util.EncodingString(_dataTable.Rows[i][j].ToString(), Encoding.Default.HeaderName, sybaseQueryer.Charset));
                }
            }
            listView1.EndUpdate();
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

        private void Btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maxsize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Btn_Maxsize.Image = Properties.Resources.Btn_Maxsized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Btn_Maxsize.Image = Properties.Resources.Btn_Maxsize_1;
            }
            
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("退出系统？","关闭",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                Btn_Maxsize.Image = Properties.Resources.Btn_Maxsized;
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                Btn_Maxsize.Image = Properties.Resources.Btn_Maxsize_1;
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            DataExportor dataExportor = new DataExportor("D:\\test.xlsx");
            dataExportor.Data = _dataTable;
            dataExportor.Export(1, 10000, DataExportor.FileType.Excel);
        }
    }
}
