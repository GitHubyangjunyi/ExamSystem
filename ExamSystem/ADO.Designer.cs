namespace ExamSystem
{
    partial class ADO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Pwd = new System.Windows.Forms.TextBox();
            this.ComboBox_SelectUsername = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.RadioButtonName = new System.Windows.Forms.RadioButton();
            this.RadioButtonPwd = new System.Windows.Forms.RadioButton();
            this.RadioButtonUsername = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.BtnEditData = new System.Windows.Forms.Button();
            this.BtnUserNumberCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(3, 1);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(400, 250);
            this.DataGridView1.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextBox_Name);
            this.GroupBox1.Controls.Add(this.TextBox_Pwd);
            this.GroupBox1.Controls.Add(this.ComboBox_SelectUsername);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Location = new System.Drawing.Point(443, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(300, 150);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "字段信息:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(85, 113);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(120, 21);
            this.TextBox_Name.TabIndex = 3;
            // 
            // TextBox_Pwd
            // 
            this.TextBox_Pwd.Location = new System.Drawing.Point(85, 59);
            this.TextBox_Pwd.Name = "TextBox_Pwd";
            this.TextBox_Pwd.Size = new System.Drawing.Size(120, 21);
            this.TextBox_Pwd.TabIndex = 2;
            // 
            // ComboBox_SelectUsername
            // 
            this.ComboBox_SelectUsername.FormattingEnabled = true;
            this.ComboBox_SelectUsername.Location = new System.Drawing.Point(85, 14);
            this.ComboBox_SelectUsername.Name = "ComboBox_SelectUsername";
            this.ComboBox_SelectUsername.Size = new System.Drawing.Size(120, 20);
            this.ComboBox_SelectUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:\r\n\r\n\r\n\r\n密码:\r\n\r\n\r\n\r\n姓名:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Btn_Select);
            this.GroupBox2.Controls.Add(this.Btn_Update);
            this.GroupBox2.Controls.Add(this.Btn_Delete);
            this.GroupBox2.Controls.Add(this.button2);
            this.GroupBox2.Controls.Add(this.Btn_Insert);
            this.GroupBox2.Location = new System.Drawing.Point(443, 168);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(300, 75);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "数据操作:";
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(223, 20);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(60, 45);
            this.Btn_Select.TabIndex = 4;
            this.Btn_Select.Text = "查询";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(154, 20);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(60, 45);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "修改";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(85, 20);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(60, 45);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(16, 20);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(60, 45);
            this.Btn_Insert.TabIndex = 0;
            this.Btn_Insert.Text = "增加";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("宋体", 10F);
            this.L1.Location = new System.Drawing.Point(1, 266);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(14, 14);
            this.L1.TabIndex = 3;
            this.L1.Text = "s";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.BtnFilter);
            this.GroupBox3.Controls.Add(this.BtnSort);
            this.GroupBox3.Controls.Add(this.RadioButtonName);
            this.GroupBox3.Controls.Add(this.RadioButtonPwd);
            this.GroupBox3.Controls.Add(this.RadioButtonUsername);
            this.GroupBox3.Location = new System.Drawing.Point(443, 399);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(300, 150);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "记录排序:";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(167, 101);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 23);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "筛选";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(167, 29);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "排序";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // RadioButtonName
            // 
            this.RadioButtonName.AutoSize = true;
            this.RadioButtonName.Location = new System.Drawing.Point(16, 108);
            this.RadioButtonName.Name = "RadioButtonName";
            this.RadioButtonName.Size = new System.Drawing.Size(71, 16);
            this.RadioButtonName.TabIndex = 2;
            this.RadioButtonName.TabStop = true;
            this.RadioButtonName.Text = "真实姓名";
            this.RadioButtonName.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPwd
            // 
            this.RadioButtonPwd.AutoSize = true;
            this.RadioButtonPwd.Location = new System.Drawing.Point(16, 68);
            this.RadioButtonPwd.Name = "RadioButtonPwd";
            this.RadioButtonPwd.Size = new System.Drawing.Size(47, 16);
            this.RadioButtonPwd.TabIndex = 1;
            this.RadioButtonPwd.TabStop = true;
            this.RadioButtonPwd.Text = "密码";
            this.RadioButtonPwd.UseVisualStyleBackColor = true;
            // 
            // RadioButtonUsername
            // 
            this.RadioButtonUsername.AutoSize = true;
            this.RadioButtonUsername.Location = new System.Drawing.Point(16, 29);
            this.RadioButtonUsername.Name = "RadioButtonUsername";
            this.RadioButtonUsername.Size = new System.Drawing.Size(59, 16);
            this.RadioButtonUsername.TabIndex = 0;
            this.RadioButtonUsername.TabStop = true;
            this.RadioButtonUsername.Text = "用户名";
            this.RadioButtonUsername.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.BtnExportToExcel);
            this.GroupBox4.Controls.Add(this.BtnEditData);
            this.GroupBox4.Location = new System.Drawing.Point(12, 449);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(200, 100);
            this.GroupBox4.TabIndex = 5;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "数据编辑/导出:";
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.Location = new System.Drawing.Point(107, 22);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(75, 35);
            this.BtnExportToExcel.TabIndex = 1;
            this.BtnExportToExcel.Text = "导出为Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = true;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            // 
            // BtnEditData
            // 
            this.BtnEditData.Location = new System.Drawing.Point(6, 22);
            this.BtnEditData.Name = "BtnEditData";
            this.BtnEditData.Size = new System.Drawing.Size(75, 35);
            this.BtnEditData.TabIndex = 0;
            this.BtnEditData.Text = "编辑数据\r\n";
            this.BtnEditData.UseVisualStyleBackColor = true;
            this.BtnEditData.Click += new System.EventHandler(this.BtnEditData_Click);
            // 
            // BtnUserNumberCount
            // 
            this.BtnUserNumberCount.Location = new System.Drawing.Point(273, 471);
            this.BtnUserNumberCount.Name = "BtnUserNumberCount";
            this.BtnUserNumberCount.Size = new System.Drawing.Size(90, 35);
            this.BtnUserNumberCount.TabIndex = 6;
            this.BtnUserNumberCount.Text = "用户数量统计LINQ";
            this.BtnUserNumberCount.UseVisualStyleBackColor = true;
            // 
            // ADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnUserNumberCount);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "ADO";
            this.Text = "ADO.NET数据库访问";
            this.Load += new System.EventHandler(this.ADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_Pwd;
        private System.Windows.Forms.ComboBox ComboBox_SelectUsername;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.Button BtnExportToExcel;
        private System.Windows.Forms.Button BtnEditData;
        private System.Windows.Forms.RadioButton RadioButtonName;
        private System.Windows.Forms.RadioButton RadioButtonPwd;
        private System.Windows.Forms.RadioButton RadioButtonUsername;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnUserNumberCount;
    }
}