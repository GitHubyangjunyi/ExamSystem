namespace ExamSystem
{
    partial class PCD
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
            this.TextBox_Details = new System.Windows.Forms.TextBox();
            this.ComboBox_District = new System.Windows.Forms.ComboBox();
            this.ComboBox_City = new System.Windows.Forms.ComboBox();
            this.ComboBox_Province = new System.Windows.Forms.ComboBox();
            this.L4 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.ShowDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Details
            // 
            this.TextBox_Details.Location = new System.Drawing.Point(115, 204);
            this.TextBox_Details.Name = "TextBox_Details";
            this.TextBox_Details.Size = new System.Drawing.Size(121, 21);
            this.TextBox_Details.TabIndex = 17;
            // 
            // ComboBox_District
            // 
            this.ComboBox_District.FormattingEnabled = true;
            this.ComboBox_District.Location = new System.Drawing.Point(112, 130);
            this.ComboBox_District.Name = "ComboBox_District";
            this.ComboBox_District.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_District.TabIndex = 7;
            this.ComboBox_District.DropDown += new System.EventHandler(this.ComboBox_District_DropDown);
            // 
            // ComboBox_City
            // 
            this.ComboBox_City.FormattingEnabled = true;
            this.ComboBox_City.Location = new System.Drawing.Point(112, 88);
            this.ComboBox_City.Name = "ComboBox_City";
            this.ComboBox_City.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_City.TabIndex = 6;
            this.ComboBox_City.DropDown += new System.EventHandler(this.ComboBox_City_DropDown);
            this.ComboBox_City.TextChanged += new System.EventHandler(this.ComboBox_City_TextChanged);
            // 
            // ComboBox_Province
            // 
            this.ComboBox_Province.FormattingEnabled = true;
            this.ComboBox_Province.Location = new System.Drawing.Point(112, 45);
            this.ComboBox_Province.Name = "ComboBox_Province";
            this.ComboBox_Province.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_Province.TabIndex = 5;
            this.ComboBox_Province.DropDown += new System.EventHandler(this.ComboBox_Province_DropDown);
            this.ComboBox_Province.TextChanged += new System.EventHandler(this.ComboBox_Province_TextChanged);
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("宋体", 15.75F);
            this.L4.Location = new System.Drawing.Point(15, 204);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(94, 21);
            this.L4.TabIndex = 13;
            this.L4.Text = "详细信息";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("宋体", 15.75F);
            this.L3.Location = new System.Drawing.Point(41, 115);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(31, 21);
            this.L3.TabIndex = 12;
            this.L3.Text = "区";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("宋体", 15.75F);
            this.L2.Location = new System.Drawing.Point(41, 72);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(31, 21);
            this.L2.TabIndex = 11;
            this.L2.Text = "市";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.L1.Location = new System.Drawing.Point(41, 29);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(31, 21);
            this.L1.TabIndex = 10;
            this.L1.Text = "省";
            // 
            // ShowDetails
            // 
            this.ShowDetails.Location = new System.Drawing.Point(158, 287);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(100, 45);
            this.ShowDetails.TabIndex = 0;
            this.ShowDetails.UseVisualStyleBackColor = true;
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // PCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.TextBox_Details);
            this.Controls.Add(this.ComboBox_District);
            this.Controls.Add(this.ComboBox_City);
            this.Controls.Add(this.ComboBox_Province);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.ShowDetails);
            this.Name = "PCD";
            this.Text = "PCD";
            this.Load += new System.EventHandler(this.PCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Details;
        private System.Windows.Forms.ComboBox ComboBox_District;
        private System.Windows.Forms.ComboBox ComboBox_City;
        private System.Windows.Forms.ComboBox ComboBox_Province;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Button ShowDetails;
    }
}