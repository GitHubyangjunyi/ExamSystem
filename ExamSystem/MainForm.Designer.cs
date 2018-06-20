namespace ExamSystem
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.题型选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初级自测试题PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级别自测试题PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级自测试题HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.StartPowerShell1 = new System.Windows.Forms.Button();
            this.StartPowerShell2 = new System.Windows.Forms.Button();
            this.StopPowerShell = new System.Windows.Forms.Button();
            this.Process1 = new System.Diagnostics.Process();
            this.L = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountertBox1 = new System.Windows.Forms.TextBox();
            this.CountertBox2 = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.ShowCharRichBox1 = new System.Windows.Forms.RichTextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.Lable_Convey = new System.Windows.Forms.Label();
            this.Production = new System.Windows.Forms.ListBox();
            this.Convey = new System.Windows.Forms.ListBox();
            this.ShowCharRichBox2 = new System.Windows.Forms.RichTextBox();
            this.ShowCharRichBox3 = new System.Windows.Forms.RichTextBox();
            this.OpenADO = new System.Windows.Forms.Button();
            this.OpenPCD = new System.Windows.Forms.Button();
            this.OpenGDIDemo = new System.Windows.Forms.Button();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.题型选择ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(784, 25);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 题型选择ToolStripMenuItem
            // 
            this.题型选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初级自测试题PToolStripMenuItem,
            this.中级别自测试题PToolStripMenuItem,
            this.高级自测试题HToolStripMenuItem});
            this.题型选择ToolStripMenuItem.Name = "题型选择ToolStripMenuItem";
            this.题型选择ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.题型选择ToolStripMenuItem.Text = "题型选择(&T)";
            // 
            // 初级自测试题PToolStripMenuItem
            // 
            this.初级自测试题PToolStripMenuItem.Name = "初级自测试题PToolStripMenuItem";
            this.初级自测试题PToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.初级自测试题PToolStripMenuItem.Text = "初级自测试题(&P)";
            this.初级自测试题PToolStripMenuItem.Click += new System.EventHandler(this.初级自测试题PToolStripMenuItem_Click);
            // 
            // 中级别自测试题PToolStripMenuItem
            // 
            this.中级别自测试题PToolStripMenuItem.Name = "中级别自测试题PToolStripMenuItem";
            this.中级别自测试题PToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.中级别自测试题PToolStripMenuItem.Text = "中级自测试题(&S)";
            // 
            // 高级自测试题HToolStripMenuItem
            // 
            this.高级自测试题HToolStripMenuItem.Name = "高级自测试题HToolStripMenuItem";
            this.高级自测试题HToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.高级自测试题HToolStripMenuItem.Text = "高级自测试题(&A)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于系统AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于系统AToolStripMenuItem
            // 
            this.关于系统AToolStripMenuItem.Name = "关于系统AToolStripMenuItem";
            this.关于系统AToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.关于系统AToolStripMenuItem.Text = "关于系统(&A)";
            this.关于系统AToolStripMenuItem.Click += new System.EventHandler(this.关于系统AToolStripMenuItem_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(784, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "退出系统";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "初级自测试题",
            "中级自测试题",
            "高级自测试题"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Text = "打开考试窗体";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.ToolStripComboBox1_TextChanged);
            // 
            // StartPowerShell1
            // 
            this.StartPowerShell1.Location = new System.Drawing.Point(12, 53);
            this.StartPowerShell1.Name = "StartPowerShell1";
            this.StartPowerShell1.Size = new System.Drawing.Size(150, 50);
            this.StartPowerShell1.TabIndex = 2;
            this.StartPowerShell1.Text = "启动Windows PowerShell方法一";
            this.StartPowerShell1.UseVisualStyleBackColor = true;
            this.StartPowerShell1.Click += new System.EventHandler(this.StartPowerShell1_Click);
            // 
            // StartPowerShell2
            // 
            this.StartPowerShell2.Location = new System.Drawing.Point(12, 109);
            this.StartPowerShell2.Name = "StartPowerShell2";
            this.StartPowerShell2.Size = new System.Drawing.Size(150, 50);
            this.StartPowerShell2.TabIndex = 2;
            this.StartPowerShell2.Text = "启动Windows PowerShell方法二";
            this.StartPowerShell2.UseVisualStyleBackColor = true;
            this.StartPowerShell2.Click += new System.EventHandler(this.StartPowerShell2_Click);
            // 
            // StopPowerShell
            // 
            this.StopPowerShell.Location = new System.Drawing.Point(14, 165);
            this.StopPowerShell.Name = "StopPowerShell";
            this.StopPowerShell.Size = new System.Drawing.Size(150, 50);
            this.StopPowerShell.TabIndex = 2;
            this.StopPowerShell.Text = "Windows PowerShell关闭";
            this.StopPowerShell.UseVisualStyleBackColor = true;
            this.StopPowerShell.Click += new System.EventHandler(this.StopPowerShell_Click);
            // 
            // Process1
            // 
            this.Process1.StartInfo.Domain = "";
            this.Process1.StartInfo.FileName = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
            this.Process1.StartInfo.LoadUserProfile = false;
            this.Process1.StartInfo.Password = null;
            this.Process1.StartInfo.StandardErrorEncoding = null;
            this.Process1.StartInfo.StandardOutputEncoding = null;
            this.Process1.StartInfo.UserName = "";
            this.Process1.SynchronizingObject = this;
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(164, 53);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(605, 60);
            this.L.TabIndex = 3;
            this.L.Text = resources.GetString("L.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "线程一的计数值:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "线程二的计数值:";
            // 
            // CountertBox1
            // 
            this.CountertBox1.Location = new System.Drawing.Point(113, 215);
            this.CountertBox1.Name = "CountertBox1";
            this.CountertBox1.Size = new System.Drawing.Size(50, 21);
            this.CountertBox1.TabIndex = 5;
            // 
            // CountertBox2
            // 
            this.CountertBox2.Location = new System.Drawing.Point(113, 250);
            this.CountertBox2.Name = "CountertBox2";
            this.CountertBox2.Size = new System.Drawing.Size(50, 21);
            this.CountertBox2.TabIndex = 5;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 277);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 50);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "终止所有线程\r\n单击后两个数值未必相等";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(118, 277);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(100, 50);
            this.Restart.TabIndex = 7;
            this.Restart.Text = "重启所有线程\r\n重新实例化线程对象并启动";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // ShowCharRichBox1
            // 
            this.ShowCharRichBox1.Location = new System.Drawing.Point(170, 121);
            this.ShowCharRichBox1.Name = "ShowCharRichBox1";
            this.ShowCharRichBox1.Size = new System.Drawing.Size(100, 100);
            this.ShowCharRichBox1.TabIndex = 8;
            this.ShowCharRichBox1.Text = "";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(501, 109);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(245, 12);
            this.L1.TabIndex = 9;
            this.L1.Text = "生产数量        待装数量        已装数量";
            // 
            // Lable_Convey
            // 
            this.Lable_Convey.AutoSize = true;
            this.Lable_Convey.Location = new System.Drawing.Point(603, 128);
            this.Lable_Convey.Name = "Lable_Convey";
            this.Lable_Convey.Size = new System.Drawing.Size(11, 12);
            this.Lable_Convey.TabIndex = 11;
            this.Lable_Convey.Text = "0";
            // 
            // Production
            // 
            this.Production.FormattingEnabled = true;
            this.Production.ItemHeight = 12;
            this.Production.Location = new System.Drawing.Point(503, 128);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(60, 196);
            this.Production.TabIndex = 12;
            // 
            // Convey
            // 
            this.Convey.FormattingEnabled = true;
            this.Convey.ItemHeight = 12;
            this.Convey.Location = new System.Drawing.Point(686, 128);
            this.Convey.Name = "Convey";
            this.Convey.Size = new System.Drawing.Size(60, 196);
            this.Convey.TabIndex = 12;
            // 
            // ShowCharRichBox2
            // 
            this.ShowCharRichBox2.Location = new System.Drawing.Point(276, 121);
            this.ShowCharRichBox2.Name = "ShowCharRichBox2";
            this.ShowCharRichBox2.Size = new System.Drawing.Size(100, 100);
            this.ShowCharRichBox2.TabIndex = 13;
            this.ShowCharRichBox2.Text = "";
            // 
            // ShowCharRichBox3
            // 
            this.ShowCharRichBox3.Location = new System.Drawing.Point(382, 121);
            this.ShowCharRichBox3.Name = "ShowCharRichBox3";
            this.ShowCharRichBox3.Size = new System.Drawing.Size(100, 100);
            this.ShowCharRichBox3.TabIndex = 14;
            this.ShowCharRichBox3.Text = "";
            // 
            // OpenADO
            // 
            this.OpenADO.Location = new System.Drawing.Point(14, 330);
            this.OpenADO.Name = "OpenADO";
            this.OpenADO.Size = new System.Drawing.Size(100, 50);
            this.OpenADO.TabIndex = 15;
            this.OpenADO.Text = "打开ADO窗体";
            this.OpenADO.UseVisualStyleBackColor = true;
            this.OpenADO.Click += new System.EventHandler(this.OpenADO_Click);
            // 
            // OpenPCD
            // 
            this.OpenPCD.Location = new System.Drawing.Point(14, 383);
            this.OpenPCD.Name = "OpenPCD";
            this.OpenPCD.Size = new System.Drawing.Size(100, 50);
            this.OpenPCD.TabIndex = 16;
            this.OpenPCD.Text = "打开省市区\r\n选择窗体";
            this.OpenPCD.UseVisualStyleBackColor = true;
            this.OpenPCD.Click += new System.EventHandler(this.OpenPCD_Click);
            // 
            // OpenGDIDemo
            // 
            this.OpenGDIDemo.Location = new System.Drawing.Point(14, 439);
            this.OpenGDIDemo.Name = "OpenGDIDemo";
            this.OpenGDIDemo.Size = new System.Drawing.Size(100, 50);
            this.OpenGDIDemo.TabIndex = 17;
            this.OpenGDIDemo.Text = "打开GDI";
            this.OpenGDIDemo.UseVisualStyleBackColor = true;
            this.OpenGDIDemo.Click += new System.EventHandler(this.OpenGDIDemo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OpenGDIDemo);
            this.Controls.Add(this.OpenPCD);
            this.Controls.Add(this.OpenADO);
            this.Controls.Add(this.ShowCharRichBox3);
            this.Controls.Add(this.ShowCharRichBox2);
            this.Controls.Add(this.Convey);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.Lable_Convey);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.ShowCharRichBox1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.CountertBox2);
            this.Controls.Add(this.CountertBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L);
            this.Controls.Add(this.StopPowerShell);
            this.Controls.Add(this.StartPowerShell2);
            this.Controls.Add(this.StartPowerShell1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 题型选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初级自测试题PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级别自测试题PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级自测试题HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于系统AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button StartPowerShell1;
        private System.Windows.Forms.Button StartPowerShell2;
        private System.Windows.Forms.Button StopPowerShell;
        private System.Diagnostics.Process Process1;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox CountertBox2;
        private System.Windows.Forms.TextBox CountertBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.RichTextBox ShowCharRichBox1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label Lable_Convey;
        private System.Windows.Forms.ListBox Convey;
        private System.Windows.Forms.ListBox Production;
        private System.Windows.Forms.RichTextBox ShowCharRichBox2;
        private System.Windows.Forms.RichTextBox ShowCharRichBox3;
        private System.Windows.Forms.Button OpenADO;
        private System.Windows.Forms.Button OpenPCD;
        private System.Windows.Forms.Button OpenGDIDemo;
    }
}

