using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class PrimaryExamForm : Form
    {
        public PrimaryExamForm()
        {
            InitializeComponent();
        }

        int ExamSecond = 0;

        private void ExamScore()//评分
        {
            int Score = 0;
            if (this.Answer1.Text=="2000")
            {
                Score += 10;
            }
            if (this.Answer21A.Checked)
            {
                Score += 10;
            }
            if (this.Answer22C.Checked)
            {
                Score += 10;
            }
            if (this.Answer23.Text == "PasswordChar")
            {
                Score += 10;
            }
            if (this.Answer24.Text == "Text")
            {
                Score += 10;
            }
            if (this.Answer3A.Checked&&this.Answer3B.Checked&&this.Answer3C.Checked&&!this.Answer3D.Checked)
            {
                Score += 10;
            }
            this.Timer1.Enabled = false;//计时停止
            this.btnGrade.Enabled = false;//交卷锁定防止重复交卷
            this.TotalScore.Text = Score.ToString();//显示总得分
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            ExamScore();//评分
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ExamSecond<120)
            {
                ExamSecond++;
                this.ExamTime.Text = ExamSecond.ToString();//刷新计时值
                this.toolStripProgressBar1.Value = ExamSecond;//刷新进度条
            }
            else
            {
                ExamScore();//评分
            }
        }

        private void PrimaryExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this,
                "确定要关闭当前窗体吗?是,请单击确定按钮;否则,请单击取消按钮","提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                PrimaryExamForm SFrm = new PrimaryExamForm();
                SFrm.Close();
            }
            else
            {
                e.Cancel = true;   
            }
        }
    }
}
