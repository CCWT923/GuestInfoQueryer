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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Panel_ControlBox = new System.Windows.Forms.Panel();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.dragControl1 = new DragControl.DragControl();
            this.dragControl2 = new DragControl.DragControl();
            this.mainResultList1 = new GuestInfoQueryer.MainResultList();
            this.Panel_CommandPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Main.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 626);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(196, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(392, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(588, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(784, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
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
            this.Panel_Main.Controls.Add(this.mainResultList1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(176, 50);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(982, 576);
            this.Panel_Main.TabIndex = 3;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Main;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Panel_CommandPanel;
            // 
            // mainResultList1
            // 
            this.mainResultList1.Location = new System.Drawing.Point(2, 0);
            this.mainResultList1.Name = "mainResultList1";
            this.mainResultList1.Size = new System.Drawing.Size(982, 576);
            this.mainResultList1.TabIndex = 0;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_ControlBox;
        private MainResultList mainResultList1;
    }
}

