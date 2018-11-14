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
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Panel_ControlBox = new System.Windows.Forms.Panel();
            this.Btn_Minisize = new System.Windows.Forms.Button();
            this.Btn_MaxSize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dragControl1 = new DragControl.DragControl();
            this.Panel_Title.SuspendLayout();
            this.Panel_ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_Title.Controls.Add(this.Panel_ControlBox);
            this.Panel_Title.Controls.Add(this.label1);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(783, 42);
            this.Panel_Title.TabIndex = 0;
            // 
            // Panel_ControlBox
            // 
            this.Panel_ControlBox.Controls.Add(this.Btn_Minisize);
            this.Panel_ControlBox.Controls.Add(this.Btn_MaxSize);
            this.Panel_ControlBox.Controls.Add(this.Btn_Close);
            this.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_ControlBox.Location = new System.Drawing.Point(672, 0);
            this.Panel_ControlBox.Name = "Panel_ControlBox";
            this.Panel_ControlBox.Size = new System.Drawing.Size(111, 42);
            this.Panel_ControlBox.TabIndex = 1;
            // 
            // Btn_Minisize
            // 
            this.Btn_Minisize.FlatAppearance.BorderSize = 0;
            this.Btn_Minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minisize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Minisize.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Minisize.Location = new System.Drawing.Point(3, 0);
            this.Btn_Minisize.Name = "Btn_Minisize";
            this.Btn_Minisize.Size = new System.Drawing.Size(31, 42);
            this.Btn_Minisize.TabIndex = 3;
            this.Btn_Minisize.Text = "-";
            this.Btn_Minisize.UseVisualStyleBackColor = true;
            this.Btn_Minisize.Click += new System.EventHandler(this.Btn_Minisize_Click);
            // 
            // Btn_MaxSize
            // 
            this.Btn_MaxSize.FlatAppearance.BorderSize = 0;
            this.Btn_MaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MaxSize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_MaxSize.ForeColor = System.Drawing.Color.Snow;
            this.Btn_MaxSize.Location = new System.Drawing.Point(40, 0);
            this.Btn_MaxSize.Name = "Btn_MaxSize";
            this.Btn_MaxSize.Size = new System.Drawing.Size(31, 42);
            this.Btn_MaxSize.TabIndex = 4;
            this.Btn_MaxSize.Text = "□";
            this.Btn_MaxSize.UseVisualStyleBackColor = true;
            this.Btn_MaxSize.Click += new System.EventHandler(this.Btn_MaxSize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Close.Location = new System.Drawing.Point(76, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(31, 42);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "×";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest Info Queryer - By : W.T.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 449);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Title;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(783, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Info Queryer - By: W.T.";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.Panel_ControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_ControlBox;
        private System.Windows.Forms.Button Btn_Minisize;
        private System.Windows.Forms.Button Btn_MaxSize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DragControl.DragControl dragControl1;
    }
}

