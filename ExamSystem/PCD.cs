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
    public partial class PCD : Form
    {
        public PCD()
        {
            InitializeComponent();
        }

        string constr = "Password=123456;Persist Security Info=True;User ID=test;Initial Catalog=test;Data Source=.";

        private void ComboBox_Province_DropDown(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection
            {
                ConnectionString = constr
            };
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = sqlConnection,
                CommandText = "select name from T where fid=0"
            };
            SqlDataReader dataReader;
            dataReader = sqlCommand.ExecuteReader();
            ComboBox_Province.Items.Clear();
            while (dataReader.Read())
            {
                ComboBox_Province.Items.Add(dataReader.GetString(0));
            }
        }

        private void ComboBox_City_DropDown(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection
            {
                ConnectionString = constr
            };
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = sqlConnection,
                CommandText = String.Format("select name from T where fid=(select id from T where name='{0}')", ComboBox_Province.Text)

            };
            SqlDataReader dataReader;
            dataReader = sqlCommand.ExecuteReader();
            ComboBox_City.Items.Clear();
            while (dataReader.Read())
            {
                ComboBox_City.Items.Add(dataReader.GetString(0));
            }
        }

        private void ComboBox_District_DropDown(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection
            {
                ConnectionString = constr
            };
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = sqlConnection,
                CommandText = String.Format("select name from T where fid=(select id from T where name='{0}')", ComboBox_City.Text)

            };
            SqlDataReader dataReader;
            dataReader = sqlCommand.ExecuteReader();
            ComboBox_District.Items.Clear();
            while (dataReader.Read())
            {
                ComboBox_District.Items.Add(dataReader.GetString(0));
            }
        }

        private void ComboBox_Province_TextChanged(object sender, EventArgs e)
        {
            ComboBox_City.Text = "";
            ComboBox_District.Text = "";
        }

        private void ComboBox_City_TextChanged(object sender, EventArgs e)
        {
            ComboBox_District.Text = "";
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            String details = string.Format("{0}{1}{2}{3}", ComboBox_Province.Text, ComboBox_City.Text, ComboBox_District.Text, TextBox_Details.Text);
            MessageBox.Show(details + "\n");
        }

        private void PCD_Load(object sender, EventArgs e)
        {

        }
    }
}
//以下是SQL语句实现
//--以下是插入省
//insert into T(id, name, fid) values(01,'北京市',0);
//insert into T(id, name, fid) values(03,'河北省',0);
//insert into T(id, name, fid) values(02,'天津市',0);
//insert into T(id, name, fid) values(04,'山西省',0);
//insert into T(id, name, fid) values(05,'内蒙古自治区',0);
//insert into T(id, name, fid) values(06,'辽宁省',0);
//insert into T(id, name, fid) values(07,'吉林省',0);
//insert into T(id, name, fid) values(08,'黑龙江省',0);
//insert into T(id, name, fid) values(09,'上海市',0);
//insert into T(id, name, fid) values(10,'江苏省',0);
//insert into T(id, name, fid) values(11,'浙江省',0);
//insert into T(id, name, fid) values(12,'安徽省',0);
//insert into T(id, name, fid) values(13,'福建省',0);
//insert into T(id, name, fid) values(14,'江西省',0);
//insert into T(id, name, fid) values(15,'山东省',0);
//insert into T(id, name, fid) values(16,'河南省',0);
//insert into T(id, name, fid) values(17,'湖北省',0);
//insert into T(id, name, fid) values(18,'湖南省',0);
//insert into T(id, name, fid) values(19,'广东省',0);
//insert into T(id, name, fid) values(20,'广西壮族自治区',0);
//insert into T(id, name, fid) values(21,'海南省',0);
//insert into T(id, name, fid) values(22,'重庆市',0);
//insert into T(id, name, fid) values(23,'四川省',0);
//insert into T(id, name, fid) values(24,'贵州省',0);
//insert into T(id, name, fid) values(25,'云南省',0);
//insert into T(id, name, fid) values(26,'西藏自治区',0);
//insert into T(id, name, fid) values(27,'陕西省',0);
//insert into T(id, name, fid) values(28,'甘肃省',0);
//insert into T(id, name, fid) values(29,'青海省',0);
//insert into T(id, name, fid) values(30,'宁夏回族自治区',0);
//insert into T(id, name, fid) values(31,'新疆维吾尔自治区',0);
//insert into T(id, name, fid) values(32,'台湾省',0);
//insert into T(id, name, fid) values(33,'香港特别行政区',0);
//insert into T(id, name, fid) values(34,'澳门特别行政区',0);

//--以下是插入福建省的市
//insert into T(id, name, fid) values(1301,'福州市',13);
//insert into T(id, name, fid) values(1302,'泉州市',13);
//insert into T(id, name, fid) values(1303,'厦门市',13);
//insert into T(id, name, fid) values(1304,'漳州市',13);

//--以下是插入泉州市的区
//insert into T(id, name, fid) values(130201,'鲤城区',1302);
//insert into T(id, name, fid) values(130202,'丰泽区',1302);
//insert into T(id, name, fid) values(130203,'洛江区',1302);
//insert into T(id, name, fid) values(130205,'晋江市',1302);
//insert into T(id, name, fid) values(130204,'泉港区',1302);
//insert into T(id, name, fid) values(130206,'石狮市',1302);
//insert into T(id, name, fid) values(130207,'南安市',1302);
//insert into T(id, name, fid) values(130208,'惠安县',1302);
//insert into T(id, name, fid) values(130209,'安溪县',1302);
//insert into T(id, name, fid) values(130210,'永春县',1302);
//insert into T(id, name, fid) values(130211,'德化县',1302);
//insert into T(id, name, fid) values(130212,'金门县',1302);
//--到此结束

//select* from T
//select* from T where id=01
//select name from T where fid = (select id from T where name='福建省')