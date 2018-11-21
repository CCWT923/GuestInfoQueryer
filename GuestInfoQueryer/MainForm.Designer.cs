namespace GuestInfoQueryer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel_CommandPanel = new System.Windows.Forms.Panel();
            this.Panel_SideDecoration = new System.Windows.Forms.Panel();
            this.Btn_About = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Panel_TopDecoration = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Query = new System.Windows.Forms.Button();
            this.Panel_ControlBox = new System.Windows.Forms.Panel();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_About = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_BuildDate = new System.Windows.Forms.Label();
            this.Lbl_Author = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_AboutApp = new System.Windows.Forms.Label();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.Lbl_TestResult = new System.Windows.Forms.Label();
            this.Btn_TestConnection = new System.Windows.Forms.Button();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.Lbl_Server = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Database = new System.Windows.Forms.Label();
            this.Lbl_Port = new System.Windows.Forms.Label();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.TextBox_Server = new System.Windows.Forms.TextBox();
            this.TextBox_Database = new System.Windows.Forms.TextBox();
            this.Panel_Home = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dragControl1 = new DragControl.DragControl();
            this.dragControl2 = new DragControl.DragControl();
            this.Panel_CommandPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.Panel_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Settings.SuspendLayout();
            this.Panel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_CommandPanel
            // 
            this.Panel_CommandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Panel_CommandPanel.Controls.Add(this.Panel_SideDecoration);
            this.Panel_CommandPanel.Controls.Add(this.Btn_About);
            this.Panel_CommandPanel.Controls.Add(this.Btn_Settings);
            this.Panel_CommandPanel.Controls.Add(this.Btn_Home);
            this.Panel_CommandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_CommandPanel.Location = new System.Drawing.Point(0, 0);
            this.Panel_CommandPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_CommandPanel.Name = "Panel_CommandPanel";
            this.Panel_CommandPanel.Size = new System.Drawing.Size(176, 686);
            this.Panel_CommandPanel.TabIndex = 0;
            // 
            // Panel_SideDecoration
            // 
            this.Panel_SideDecoration.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_SideDecoration.Location = new System.Drawing.Point(0, 72);
            this.Panel_SideDecoration.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_SideDecoration.Name = "Panel_SideDecoration";
            this.Panel_SideDecoration.Size = new System.Drawing.Size(10, 42);
            this.Panel_SideDecoration.TabIndex = 0;
            // 
            // Btn_About
            // 
            this.Btn_About.FlatAppearance.BorderSize = 0;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_About.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_About.ForeColor = System.Drawing.Color.White;
            this.Btn_About.Image = ((System.Drawing.Image)(resources.GetObject("Btn_About.Image")));
            this.Btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_About.Location = new System.Drawing.Point(10, 163);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(162, 42);
            this.Btn_About.TabIndex = 0;
            this.Btn_About.Text = "关于(&A)";
            this.Btn_About.UseVisualStyleBackColor = true;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Settings.ForeColor = System.Drawing.Color.White;
            this.Btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Settings.Image")));
            this.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Settings.Location = new System.Drawing.Point(10, 117);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(162, 42);
            this.Btn_Settings.TabIndex = 0;
            this.Btn_Settings.Text = "设置(&S)";
            this.Btn_Settings.UseVisualStyleBackColor = true;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Home.ForeColor = System.Drawing.Color.White;
            this.Btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Image")));
            this.Btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Home.Location = new System.Drawing.Point(10, 72);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(162, 42);
            this.Btn_Home.TabIndex = 0;
            this.Btn_Home.Text = "主页(&H)";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Panel_TopDecoration
            // 
            this.Panel_TopDecoration.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_TopDecoration.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopDecoration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Panel_TopDecoration.Location = new System.Drawing.Point(176, 0);
            this.Panel_TopDecoration.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_TopDecoration.Name = "Panel_TopDecoration";
            this.Panel_TopDecoration.Size = new System.Drawing.Size(982, 15);
            this.Panel_TopDecoration.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Query, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 626);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(172)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(784, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 60);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(196)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(588, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 60);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(221)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(392, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 60);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(196, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_Query
            // 
            this.Btn_Query.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Query.FlatAppearance.BorderSize = 0;
            this.Btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Query.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Query.ForeColor = System.Drawing.Color.White;
            this.Btn_Query.Location = new System.Drawing.Point(0, 0);
            this.Btn_Query.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Query.Name = "Btn_Query";
            this.Btn_Query.Size = new System.Drawing.Size(196, 60);
            this.Btn_Query.TabIndex = 0;
            this.Btn_Query.Text = "查询";
            this.Btn_Query.UseVisualStyleBackColor = false;
            this.Btn_Query.Click += new System.EventHandler(this.Btn_Query_Click);
            // 
            // Panel_ControlBox
            // 
            this.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_ControlBox.Location = new System.Drawing.Point(176, 15);
            this.Panel_ControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ControlBox.Name = "Panel_ControlBox";
            this.Panel_ControlBox.Size = new System.Drawing.Size(982, 35);
            this.Panel_ControlBox.TabIndex = 3;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.Panel_About);
            this.Panel_Main.Controls.Add(this.Panel_Settings);
            this.Panel_Main.Controls.Add(this.Panel_Home);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(176, 50);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(982, 576);
            this.Panel_Main.TabIndex = 3;
            // 
            // Panel_About
            // 
            this.Panel_About.BackColor = System.Drawing.Color.White;
            this.Panel_About.Controls.Add(this.label1);
            this.Panel_About.Controls.Add(this.Lbl_BuildDate);
            this.Panel_About.Controls.Add(this.Lbl_Author);
            this.Panel_About.Controls.Add(this.pictureBox1);
            this.Panel_About.Controls.Add(this.Lbl_AboutApp);
            this.Panel_About.Location = new System.Drawing.Point(889, 22);
            this.Panel_About.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_About.Name = "Panel_About";
            this.Panel_About.Size = new System.Drawing.Size(59, 390);
            this.Panel_About.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(420, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "微信扫一扫支持我：";
            // 
            // Lbl_BuildDate
            // 
            this.Lbl_BuildDate.AutoSize = true;
            this.Lbl_BuildDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_BuildDate.Location = new System.Drawing.Point(420, 194);
            this.Lbl_BuildDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_BuildDate.Name = "Lbl_BuildDate";
            this.Lbl_BuildDate.Size = new System.Drawing.Size(130, 21);
            this.Lbl_BuildDate.TabIndex = 2;
            this.Lbl_BuildDate.Text = "2018年11月20日";
            // 
            // Lbl_Author
            // 
            this.Lbl_Author.AutoSize = true;
            this.Lbl_Author.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Author.Location = new System.Drawing.Point(452, 157);
            this.Lbl_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Author.Name = "Lbl_Author";
            this.Lbl_Author.Size = new System.Drawing.Size(46, 24);
            this.Lbl_Author.TabIndex = 1;
            this.Lbl_Author.Text = "W.T.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuestInfoQueryer.Properties.Resources.zsm;
            this.pictureBox1.Location = new System.Drawing.Point(373, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_AboutApp
            // 
            this.Lbl_AboutApp.AutoSize = true;
            this.Lbl_AboutApp.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AboutApp.Location = new System.Drawing.Point(408, 91);
            this.Lbl_AboutApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AboutApp.Name = "Lbl_AboutApp";
            this.Lbl_AboutApp.Size = new System.Drawing.Size(150, 35);
            this.Lbl_AboutApp.TabIndex = 0;
            this.Lbl_AboutApp.Text = "关于此程序";
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.Lbl_TestResult);
            this.Panel_Settings.Controls.Add(this.Btn_TestConnection);
            this.Panel_Settings.Controls.Add(this.TextBox_Username);
            this.Panel_Settings.Controls.Add(this.TextBox_Port);
            this.Panel_Settings.Controls.Add(this.Lbl_Server);
            this.Panel_Settings.Controls.Add(this.TextBox_Password);
            this.Panel_Settings.Controls.Add(this.Lbl_Password);
            this.Panel_Settings.Controls.Add(this.Lbl_Database);
            this.Panel_Settings.Controls.Add(this.Lbl_Port);
            this.Panel_Settings.Controls.Add(this.Lbl_Username);
            this.Panel_Settings.Controls.Add(this.TextBox_Server);
            this.Panel_Settings.Controls.Add(this.TextBox_Database);
            this.Panel_Settings.Location = new System.Drawing.Point(127, 22);
            this.Panel_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(265, 181);
            this.Panel_Settings.TabIndex = 1;
            // 
            // Lbl_TestResult
            // 
            this.Lbl_TestResult.AutoSize = true;
            this.Lbl_TestResult.Location = new System.Drawing.Point(326, 212);
            this.Lbl_TestResult.Name = "Lbl_TestResult";
            this.Lbl_TestResult.Size = new System.Drawing.Size(0, 12);
            this.Lbl_TestResult.TabIndex = 6;
            // 
            // Btn_TestConnection
            // 
            this.Btn_TestConnection.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_TestConnection.FlatAppearance.BorderSize = 0;
            this.Btn_TestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TestConnection.ForeColor = System.Drawing.Color.White;
            this.Btn_TestConnection.Location = new System.Drawing.Point(173, 203);
            this.Btn_TestConnection.Name = "Btn_TestConnection";
            this.Btn_TestConnection.Size = new System.Drawing.Size(105, 37);
            this.Btn_TestConnection.TabIndex = 5;
            this.Btn_TestConnection.Text = "测试连接";
            this.Btn_TestConnection.UseVisualStyleBackColor = false;
            this.Btn_TestConnection.Click += new System.EventHandler(this.Btn_TestConnection_Click);
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Username.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Username.Location = new System.Drawing.Point(173, 113);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(141, 27);
            this.TextBox_Username.TabIndex = 4;
            this.TextBox_Username.Text = "sa";
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Port.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Port.Location = new System.Drawing.Point(173, 154);
            this.TextBox_Port.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(141, 27);
            this.TextBox_Port.TabIndex = 4;
            this.TextBox_Port.Text = "5000";
            // 
            // Lbl_Server
            // 
            this.Lbl_Server.AutoSize = true;
            this.Lbl_Server.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Server.Location = new System.Drawing.Point(71, 74);
            this.Lbl_Server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Server.Name = "Lbl_Server";
            this.Lbl_Server.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Server.TabIndex = 3;
            this.Lbl_Server.Text = "服务器地址：";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Password.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Password.Location = new System.Drawing.Point(503, 113);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(141, 27);
            this.TextBox_Password.TabIndex = 4;
            this.TextBox_Password.Text = "null";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Password.Location = new System.Drawing.Point(401, 116);
            this.Lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "密码：";
            // 
            // Lbl_Database
            // 
            this.Lbl_Database.AutoSize = true;
            this.Lbl_Database.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Database.Location = new System.Drawing.Point(401, 74);
            this.Lbl_Database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Database.Name = "Lbl_Database";
            this.Lbl_Database.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Database.TabIndex = 3;
            this.Lbl_Database.Text = "数据库名称：";
            // 
            // Lbl_Port
            // 
            this.Lbl_Port.AutoSize = true;
            this.Lbl_Port.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Port.Location = new System.Drawing.Point(71, 156);
            this.Lbl_Port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Port.Name = "Lbl_Port";
            this.Lbl_Port.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Port.TabIndex = 3;
            this.Lbl_Port.Text = "端口：";
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Username.Location = new System.Drawing.Point(71, 116);
            this.Lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Username.TabIndex = 3;
            this.Lbl_Username.Text = "用户名：";
            // 
            // TextBox_Server
            // 
            this.TextBox_Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Server.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Server.Location = new System.Drawing.Point(173, 71);
            this.TextBox_Server.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Server.Name = "TextBox_Server";
            this.TextBox_Server.Size = new System.Drawing.Size(141, 27);
            this.TextBox_Server.TabIndex = 4;
            this.TextBox_Server.Text = "150.0.1.100";
            // 
            // TextBox_Database
            // 
            this.TextBox_Database.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Database.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Database.Location = new System.Drawing.Point(503, 74);
            this.TextBox_Database.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Database.Name = "TextBox_Database";
            this.TextBox_Database.Size = new System.Drawing.Size(141, 27);
            this.TextBox_Database.TabIndex = 4;
            this.TextBox_Database.Text = "foxhis";
            // 
            // Panel_Home
            // 
            this.Panel_Home.Controls.Add(this.listView1);
            this.Panel_Home.Location = new System.Drawing.Point(15, 85);
            this.Panel_Home.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Home.Name = "Panel_Home";
            this.Panel_Home.Size = new System.Drawing.Size(54, 62);
            this.Panel_Home.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(54, 62);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 457;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 501;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Main;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Panel_CommandPanel;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1158, 686);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_ControlBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panel_TopDecoration);
            this.Controls.Add(this.Panel_CommandPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Info Queryer - By: W.T.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel_CommandPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_About.ResumeLayout(false);
            this.Panel_About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.Panel_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_CommandPanel;
        private DragControl.DragControl dragControl1;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Panel Panel_TopDecoration;
        private System.Windows.Forms.Panel Panel_SideDecoration;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Button Btn_Settings;
        private DragControl.DragControl dragControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Query;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_ControlBox;
        private System.Windows.Forms.Panel Panel_About;
        private System.Windows.Forms.Label Lbl_AboutApp;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.Panel Panel_Home;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox TextBox_Database;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox TextBox_Server;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.Label Lbl_Database;
        private System.Windows.Forms.Label Lbl_Server;
        private System.Windows.Forms.Label Lbl_BuildDate;
        private System.Windows.Forms.Label Lbl_Author;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label Lbl_Port;
        private System.Windows.Forms.Label Lbl_TestResult;
        private System.Windows.Forms.Button Btn_TestConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

