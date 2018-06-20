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
    public partial class GDIDemo : Form
    {
        public GDIDemo()
        {
            InitializeComponent();
        }

        Color blue = Color.FromArgb(0, 0, 255);
        Color red = Color.Red;
        static Point startpoi = new Point(100, 100);
        static Point endpoi = new Point(200, 200);
        static Size size = new Size(150, 300);
        Rectangle rectangle = new Rectangle(startpoi, size);
        Rectangle rct = new Rectangle(10, 20, 150, 300);
        Pen penone = new Pen(Color.Red, 5);
        SolidBrush solidBrushone = new SolidBrush(Color.Blue);

        private void GDIDemo_Load(object sender, EventArgs e)
        {

        }

        private void GDIDemo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //1.该事件包含了当前窗体或控件的Graphics对象,在为窗体或控件编写绘图代码时一般使用此方法来获得图形对象的引用
            Graphics h = this.CreateGraphics();//2.调用窗体或控件的CreateGraphics获得对Graphics对象的引用
            //3.调用Graphics类的FromImage静态方法,从继承自图像的任何对象创建Graphics对象,常用于更改已经存在的图像
            //Bitmap bitmap = new Bitmap(@"C:\");
            //Graphics gb = Graphics.FromImage(bitmap);
            //或者
            //Image img = Image.FromFile(@"C:\");
            //Graphics gi = Graphics.FromImage(img);
            g.DrawLine(penone, startpoi, endpoi);
            Point[] points = { new Point(210, 20), new Point(160, 130), new Point(260, 130) };
            Point[] pointsx = { new Point(70, 20), new Point(20, 130), new Point(120, 130) };
            g.FillPolygon(solidBrushone, points);
            g.DrawPolygon(penone, pointsx);
        }
    }
}
// _____________________________GDI+体系结构___________________________________
//|  ____________________________________________________    _______________   |
//| |                      Microsoft.NET框架             |  |   Win32(C++)  |  |
//| |____________________________________________________|  |_______________|  |
//|  ________________________________________________________________________  |
//| |                               GDI+引擎                                 | |
//| |    __________    _________      _________                              | |
//| |   | 二维矢量 |  |   图像  |    |   文本  |                             | |
//| |   |   图形   |  |         |    |         |                             | |
//| |    ----------    ---------      ---------                              | |
//| |    __________    ________   ________                                   | |
//| |   |   GDI+   |  |   GDL  | | DirectX|                                  | |
//| |   |          |  |        | |        |                                  | |
//| |    ----------    --------   --------                                   | |
//| |________________________________________________________________________| |
//|                                                                            |
//|  ________________________________________________________________________  |
//| |                              底层驱动程序                              | |
//| |________________________________________________________________________| |
//|____________________________________________________________________________|