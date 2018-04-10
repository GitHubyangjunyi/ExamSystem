using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamSystem
{
    public partial class ADO : Form
    {
        public ADO()
        {
            InitializeComponent();
        }
        
        static string strcon = "Password=123456;Persist Security Info=True;User ID=test;Initial Catalog=test;Data Source=.";
        SqlConnection sqlcon = new SqlConnection(strcon);

        private void ADO_Load(object sender, EventArgs e)
        {
            CommonDataView();//窗体加载时初始化并显示数据表原始数据
        }

        private void CommonDataView()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                ("select username as 用户名,pwd as 密码,name as 真实姓名 from EmailUsers", sqlcon);
            DataSet dataSet = new DataSet();//创建数据集
            try
            {
                sqlDataAdapter.Fill(dataSet, "tablename");
                DataGridView1.DataSource = dataSet.Tables[0];//将数据集绑定到DataGridView1
                //ComboBox_SelectUsername.DisplayMember = "username";//将数据集绑定到ComboBox_SelectUsername并指定列表中要显示的数据表的具体字段
                //ComboBox_SelectUsername.ValueMember = "username";//指定最终实际存储的数据表的具体字段
                //ComboBox_SelectUsername.DataSource = dataSet.Tables[0].DefaultView;//绑定数据源
            }
            catch (SystemException ex)
            {
                MessageBox.Show("错误:" + ex.Message, "错误提示", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            finally
            {
                if (sqlcon.State==ConnectionState.Open)
                {
                    sqlcon.Close();
                    sqlcon.Dispose();
                }
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)//增加按钮事件
        {
            sqlcon.Open();
            SqlCommand insertCommand = new SqlCommand
                (String.Format("insert into EmailUsers values('{0}','{1}','{2}')",
                ComboBox_SelectUsername.Text,TextBox_Pwd.Text,TextBox_Name.Text),sqlcon);
            insertCommand.ExecuteNonQuery();
            sqlcon.Close();
            CommonDataView();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)//删除按钮事件
        {
            sqlcon.Open();
            SqlCommand deleteCommand = new SqlCommand
                (String.Format("delete from EmailUsers where username='{0}'",
                ComboBox_SelectUsername.Text),sqlcon);
            deleteCommand.ExecuteNonQuery();
            sqlcon.Close();
            CommonDataView();
        }

        private void Btn_Update_Click(object sender, EventArgs e)//修改按钮事件
        {
            sqlcon.Open();
            SqlCommand updatetCommand = new SqlCommand
                (String.Format("update EmailUsers set pwd='{0}',name='{1}' where username='{2}'",
                TextBox_Pwd.Text, TextBox_Name.Text,ComboBox_SelectUsername.Text),sqlcon);
            updatetCommand.ExecuteNonQuery();
            sqlcon.Close();
            CommonDataView();
        }

        private void Btn_Select_Click(object sender, EventArgs e)//查询按钮事件
        {
            sqlcon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                (String.Format("select username as 用户名,pwd as 密码,name as 真实姓名 from EmailUsers where username like '%{0}%'",
                ComboBox_SelectUsername.Text),sqlcon);
            DataSet dataSet = new DataSet();//创建数据集
            sqlDataAdapter.Fill(dataSet, "tablename");
            DataGridView1.DataSource = dataSet.Tables[0];//将数据集绑定到DataGridView1
            sqlcon.Close();
        }

        private Boolean DBUpdate()//将DataGridView1的数据更新到数据库的方法
        {
            string strsql = "select username as 用户名,pwd as 密码,name as 姓名 from EmailUsers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql,sqlcon);
            DataTable dataTableUpdate = new DataTable();//新建一个用于将DataGridView1数据操作更新到数据库的内存表
            sqlDataAdapter.Fill(dataTableUpdate);
            dataTableUpdate.Rows.Clear();//初始化的数据清除剩下表结构以存放更新后的DataGridView1数据
            DataTable dataTableShow = new DataTable();//新建一个内存表将更新后的DataGridView1数据逐条读取并更新内存表
            dataTableShow = (DataTable)DataGridView1.DataSource;
            for (int i = 0; i < dataTableShow.Rows.Count; i++)
            {
                dataTableUpdate.ImportRow(dataTableShow.Rows[i]);
            }
            try
            {
                sqlcon.Open();
                //使对DataSet所作的更改与关联的SQL Server数据库相协调
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                //通过sqlDataAdapter将更新后的DataGridView1数据(即已经复制的dataTableUpdate)更新到数据库
                //自己加的,没有解决问题sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
                sqlDataAdapter.Update(dataTableUpdate);
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败:"+ex.Message.ToString(),"提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            dataTableUpdate.AcceptChanges();
            return true;
        }

        private bool DataGridViewExportToExcel(DataGridView dgvete,bool ishowexcel)//导出Excel,未实现
        {
            if (dgvete.Rows.Count==0)
            {
                return false;
            }
            //Excel.Application excel = new Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //excel.Visible = isShowExcel;
            //for (int i = 0; i < dgvete.ColumnsCount; i++)
            //{
            //    excel.Cell[1, i + 1] = dgvete.Columns[i].HeaderText;
            //}
            //for (int i = 0; i < dgvete.RowCount-1; i++)
            //{
            //    for (int j = 0; j < dgvete.ColumnsCount; j++)
            //    {
            //        excel.Cell[i + 2, j + 1] = dgvete[j, i].Value.ToString();
            //    }
            //}
            //以上代码注释掉有错误未排除
            return true;
            //这一函数未实现所以导出为Excel文件未实现
            //需要引用Com选项卡下的Interop.Excel.dll
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)//导出Excel,未实现
        {

        }

        private void BtnSort_Click(object sender, EventArgs e)//视图排序事件
        {
            //创建数据集
            string strsql = "select username as 用户名,pwd as 密码,name as 姓名 from EmailUsers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet,"tablename");
            //创建视图
            DataView dataView = dataSet.Tables["tablename"].DefaultView;
            //排序选项判断
            if (RadioButtonUsername.Checked)
            {
                dataView.Sort = "用户名";
            }
            else if (RadioButtonPwd.Checked)
            {
                dataView.Sort = "密码";
            }
            else
            {
                dataView.Sort = "姓名";
            }
            //开始排序
            DataGridView1.DataSource = dataView;
            BtnEditData.Text = "编辑数据";//提示按钮的状态为编辑数据
        }

        private void BtnFilter_Click(object sender, EventArgs e)//视图筛选事件
        {
            //创建数据集
            string strsql = "select username as 用户名,pwd as 密码,name as 姓名 from EmailUsers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "tablename");
            //创建视图
            DataView dataView = dataSet.Tables["tablename"].DefaultView;
            //筛选选项判断
            if (RadioButtonUsername.Checked)
            {
                dataView.RowFilter = "用户名 like '%"+ ComboBox_SelectUsername.Text+"%'";
            }
            else if (RadioButtonPwd.Checked)
            {
                dataView.RowFilter = "密码 like '%" + TextBox_Pwd.Text + "%'";
            }
            else
            {
                dataView.RowFilter = "姓名 like '%" + TextBox_Name.Text + "%'";
            }
            //开始筛选
            dataView.RowStateFilter = DataViewRowState.CurrentRows;
            DataGridView1.DataSource = dataView;
            BtnEditData.Text = "保存数据";//转为保存数据状态
        }

        private void BtnEditData_Click(object sender, EventArgs e)//保存数据操作到数据库事件
        {
            //这一事件函数的功能说明
            //运行当前窗体,对DataGridView1控件中的数据直接进行添加删除或修改操作
            //然后单击保存数据按钮,就可以将当前的数据状态更新到数据库中
            //之后按钮文本变为"编辑数据",为继续编辑做准备
            if (BtnEditData.Text == "保存数据")
            {
                if (DBUpdate())
                {
                    MessageBox.Show("数据据操作成功!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                BtnEditData.Text = "编辑数据";
            }
            else
            {
                //刷新DataGridView1的数据显示,以便对其进行数据编辑
                CommonDataView();
                BtnEditData.Text = "保存数据";//提示按钮状态为保存数据
            }
        }
    }
}

//EmailUsers表的结构
//username  pwd  name
//且必须设置一个主键,否则会出现以下异常信息
//对于不返回任何键列信息的 SelectCommand，不支持 UpdateCommand 的动态 SQL 生成
//设置主键后出现违反并发性异常