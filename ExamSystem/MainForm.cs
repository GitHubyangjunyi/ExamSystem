using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ExamSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//应用程序采取非线程安全方式所以要禁用此异常,关于为何禁用此异常原因在下面
        }

        private Thread thread_counter1 = null;//这两个线程对象用于线程计数器
        private Thread thread_counter2 = null;
        private Thread thread_lock1 = null;//这两个线程对象用于Lock测试
        private Thread thread_lock2 = null;
        private Thread thread_monitor1 = null;//这两个线程对象用于Monitor类测试
        private Thread thread_monitor2 = null;
        private Thread thread_mutex1 = null;//这两个线程对象用于Mutex类测试
        private Thread thread_mutex2 = null;
        private Mutex mutex1 = new Mutex();//直接实例化Mutex对象
        private Thread thread_produce = null;//这两个线程对象用于生产和装运线程对象
        private Thread thread_convey = null;
        static object product = new object();//创建一个互斥体对象令牌
        int iMaxProduct = 10;//最大生产数
        int iNewProduct = 0;//待装数量
        int iConvey = 0;//已装运数量
        bool blStopProduce = false;//停止生产和装运标记
        
        private void StartPowerShell1_Click(object sender, EventArgs e)
        {
            Process1.Start();
        }

        private void StartPowerShell2_Click(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe");
            if (finfo.Exists)
            {
                Process prcsPowerShell = new Process();//实例化一个Process类并启动一个独立进程
                prcsPowerShell.StartInfo.FileName = finfo.FullName;//指定启动的程序文件
                prcsPowerShell.Start();
            }
            else
            {
                MessageBox.Show("文件"+ finfo.FullName+"不存在");
            }
        }

        private void StopPowerShell_Click(object sender, EventArgs e)
        {
            Process[] cp;//创建一个Process组件的数组
            cp = Process.GetProcessesByName("Windows PowerShell");//将数组与指定名称的所有进程相关联
            foreach (Process item in cp)//遍历当前启动程序并查找包含指定名称的进程
            {
                item.Close();//终止当前进程关闭窗体
            }
        }
        
        private void Counter1()
        {
            while (true)
            {
                int i;
                for (i = 0; i < 1000; i++)
                {
                    CountertBox1.Text = i.ToString();
                }
                Thread.Sleep(3000);//线程休眠3秒
            }
        }

        private void Counter2()
        {
            while (true)
            {
                int j;
                for (j = 0; j < 1000; j++)
                {
                    CountertBox2.Text = j.ToString();
                }
                Thread.Sleep(3000);//线程休眠3秒
            }
        }

        private void ShowChar(char ch)
        {
            //使用lock将代码区标记为一个临界区,确保当一个线程位于代码临界区时,另一线程不进入该临界区
            //如果其他线程试图进入该临界区时,它将一直等待,直到该对象被释放
            //其执行过程是先获得给定对象的互斥锁然后执行相应语句,任务完成后再释放该锁
            //通常应避免锁定public类型的对象,否则实例将超出代码的控制范围
            //最佳做法是定义private对象来锁定,或定义private static对象变量来保护所有实例的共有数据
            lock (this)
            {
                ShowCharRichBox1.Text += ch;
            }
            //ShowCharRichBox.Text += ch;
            //不进行lock结果不一样
        }

        private void Thread_lock1_ShowChar()
        {
            while (true)
            {
                ShowChar('A');
                Thread.Sleep(300);//A任务的线程休眠时间只有X任务的一半
            }
        }

        private void Thread_lock2_ShowChar()
        {
            while (true)
            {
                ShowChar('X');
                Thread.Sleep(600);
            }
        }

        private void Thread_monitor1_ShowChar()
        {
            while (true)
            {
                //Monitor.Enter(this.ShowCharRichBox2);
                //try
                //{
                //    ShowCharRichBox2.Text += "B";
                //}
                //catch (Exception)
                //{
                //    Monitor.Exit(this.ShowCharRichBox2);
                //}
                //Monitor.Exit(this.ShowCharRichBox2);//也可以锁定局部资源ShowCharRichBox2
                Monitor.Enter(this);//在指定对象上获取排他锁
                try
                {
                    ShowCharRichBox2.Text += "B";
                    Monitor.Exit(this);//这句必须有不然调试生成显示不出来,放这竟然也可以
                    //Monitor.Enter(this);//这句不注释掉会使ShowCharRichBox1和2不按预期工作
                    //注意是ShowCharRichBox1和2不按预期工作
                }
                catch (Exception)
                {
                    Monitor.Exit(this);//释放指定对象上的排他锁
                }
                Thread.Sleep(300);
            }
        }

        private void Thread_monitor2_ShowChar()
        {
            while (true)
            {
                //Monitor.Enter(this.ShowCharRichBox2);
                //try
                //{
                //    ShowCharRichBox2.Text += "Y";
                //}
                //catch (Exception)
                //{
                //    Monitor.Exit(this.ShowCharRichBox2);
                //}
                //Monitor.Exit(this.ShowCharRichBox2);//也可以锁定局部资源到ShowCharRichBox2
                Monitor.Enter(this);//在指定对象上获取排他锁
                try
                {
                    ShowCharRichBox2.Text += "Y";
                    //Monitor.Enter(this);//这句放这调试生成显示不出来
                }
                catch (Exception)
                {
                    Monitor.Exit(this);//释放指定对象上的排他锁
                }
                Monitor.Exit(this);//这句必须有不然调试生成显示不出来,这句放catch后是书上的
                Thread.Sleep(600);
            }
        }

        private void Thread_mutex1_ShowChar()
        {
            while (true)
            {
                //mutex1.WaitOne();
                //try
                //{
                //    ShowCharRichBox3.Text += "C";
                //    //mutex1.WaitOne();
                //}
                //catch (Exception)
                //{
                //    mutex1.ReleaseMutex();
                //}
                //mutex1.ReleaseMutex();
                mutex1.WaitOne();//这个方法用来捕获互斥对象
                try
                {
                    ShowCharRichBox3.Text += "C";
                    mutex1.ReleaseMutex(); //这句注释掉调试生成还会显示出来,但是ShowCharRichBox3只会显示C,放这竟然也可以
                    //mutex1.WaitOne();//这句不注释掉会使ShowCharRichBox3只会显示C并在某些情况下不停止线程就关闭窗体会抛出异常
                }
                catch (Exception)
                {
                    mutex1.ReleaseMutex();//这个方法用来释放被捕获的对象
                }
                Thread.Sleep(300);
                //在使用方法上,Mutex与Monitor类似,但是由于Mutex不具备Wait()和Pulse()以及PulseALL()的方法
                //因此不能实现类似Monitor的唤醒功能
                //另外由于互斥体Mutex属于内核对象,进行线程同步时,线程须在用户模式与内核模式之间切换
                //所有需要互操作转换较消耗资源,效率较低
                //不过Mutex有个优点,Mutex是跨进程的,可以在同一台机器甚至远程机器上使用同一个互斥体
            }
        }

        private void Thread_mutex2_ShowChar()
        {
            while (true)
            {
                //mutex1.WaitOne();
                //try
                //{
                //    ShowCharRichBox3.Text += "Z";
                //    //mutex1.WaitOne();
                //    //
                //}
                //catch (Exception)
                //{
                //    mutex1.ReleaseMutex();
                //}
                //mutex1.ReleaseMutex();
                mutex1.WaitOne();//这个方法用来捕获互斥对象
                try
                {
                    ShowCharRichBox3.Text += "Z";
                }
                catch (Exception)
                {
                    mutex1.ReleaseMutex();
                }
                mutex1.ReleaseMutex();//这个方法用来释放被捕获的对象,这句放catch后是书上的
                Thread.Sleep(600);
                //在使用方法上,Mutex与Monitor类似,但是由于Mutex不具备Wait()和Pulse()以及PulseALL()的方法
                //因此不能实现类似Monitor的唤醒功能
                //另外由于互斥体Mutex属于内核对象,进行线程同步时,线程须在用户模式与内核模式之间切换
                //所有需要互操作转换较消耗资源,效率较低
                //不过Mutex有个优点,Mutex是跨进程的,可以在同一台机器甚至远程机器上使用同一个互斥体
            }
        }

        private void Produce()//生产线程调用的方法
        {
            while (!blStopProduce)
            {
                lock (product)
                {
                    for (int i = 1; i <= iMaxProduct; i++)
                    {
                        //这个for不会一次执行到条件不成立为止,执行一次就保存当前线程状态然后释放锁定的对象
                        //锁定的对象product释放后就可以给其他线程使用
                        this.Production.Items.Add(i.ToString());
                        iNewProduct++;
                        this.Lable_Convey.Text = iNewProduct.ToString();
                        if (i == iMaxProduct)
                        {
                            this.Production.Items.Add("生产结束");
                            blStopProduce = true;
                        }
                        Thread.Sleep(1000);
                        Monitor.Pulse(product);
                        Monitor.Wait(product);
                        //可以尝试把上面两句注释掉在运行,程序将不按预期
                        //或者放到for语句外面,那将会导致程序将不按预期
                        //Monitor提供了与lock类似的功能,通过向单个线程授予对象锁来控制对该对象的访问
                        //与lock相比,lock的代码块就相当于Monitor的Ente()和Exit()方法的封装
                        //lock更简洁,但是Monitor能更好控制同步块
                        //因为在Monitor中可以通过Pulse()和PulseALL()方法向一个或多个等待线程发送信号
                        //该信号通知等待线程锁定对象的状态已更改,并且锁的所有者准备释放该锁
                        //等待线程被放置在对象的就绪队列中以便可以最后接收该锁
                        //一旦线程拥有了锁就可以检查对象的新状态已查看是否达到所需状态
                        //Wait()方法则释放对象上的锁以便允许其他线程锁定和访问该对象
                    }
                    //Monitor.Pulse(product);
                    //Monitor.Wait(product);
                }
            }
        }

        private void Fuction_Convey()//装运线程调用的方法
        {
            while (true)
            {
                lock (product)
                {
                    iConvey = iConvey + iNewProduct;
                    this.Convey.Items.Add(iConvey.ToString());
                    iNewProduct--;
                    this.Lable_Convey.Text = iNewProduct.ToString();
                    if (blStopProduce)
                    {
                        this.Convey.Items.Add("装运完成");
                    }
                    Thread.Sleep(1000);
                    Monitor.Pulse(product);
                    Monitor.Wait(product);
                    //可以尝试把上面两句注释掉在运行,程序将不按预期
                    //或者放到for语句外面,那将会导致程序将不按预期
                    //Monitor提供了与lock类似的功能,通过向单个线程授予对象锁来控制对该对象的访问
                    //与lock相比,lock的代码块就相当于Monitor的Ente()和Exit()方法的封装
                    //lock更简洁,但是Monitor能更好控制同步块
                    //因为在Monitor中可以通过Pulse()和PulseALL()方法向一个或多个等待线程发送信号
                    //该信号通知等待线程锁定对象的状态已更改,并且锁的所有者准备释放该锁
                    //等待线程被放置在对象的就绪队列中以便可以最后接收该锁
                    //一旦线程拥有了锁就可以检查对象的新状态已查看是否达到所需状态
                    //Wait()方法则释放对象上的锁以便允许其他线程锁定和访问该对象
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)//停止所有线程按钮的单击事件
        {
            thread_counter1.Abort();
            thread_counter2.Abort();
            thread_lock1.Abort();
            thread_lock2.Abort();
            thread_monitor1.Abort();
            thread_monitor2.Abort();
            thread_mutex1.Abort();
            thread_mutex2.Abort();
            thread_produce.Abort();
            thread_convey.Abort();
            this.ShowCharRichBox1.Text = "";
            this.ShowCharRichBox2.Text = "";
            this.ShowCharRichBox3.Text = "";
            this.Production.Items.Clear();
            this.Production.Items.Add("0");
            this.Convey.Items.Clear();
            this.Convey.Items.Add("0");
            this.Lable_Convey.Text = "0";
            iNewProduct = 0;//待装数量
            iConvey = 0;//装运数量统计
            blStopProduce = false;
            Stop.Enabled = false;
            Restart.Enabled = true;
        }

        private void Restart_Click(object sender, EventArgs e)//重启所有线程按钮的单击事件
        {
            thread_counter1 = new Thread(new ThreadStart(Counter1));
            thread_counter2 = new Thread(new ThreadStart(Counter2));
            thread_counter1.Start();
            thread_counter2.Start();
            thread_lock1 = new Thread(new ThreadStart(Thread_lock1_ShowChar));
            thread_lock2 = new Thread(new ThreadStart(Thread_lock2_ShowChar));
            thread_lock1.Start();
            thread_lock2.Start();
            thread_monitor1 = new Thread(new ThreadStart(Thread_monitor1_ShowChar));
            thread_monitor2 = new Thread(new ThreadStart(Thread_monitor2_ShowChar));
            thread_monitor1.Start();
            thread_monitor2.Start();
            thread_mutex1 = new Thread(new ThreadStart(Thread_mutex1_ShowChar));
            thread_mutex2 = new Thread(new ThreadStart(Thread_mutex2_ShowChar));
            thread_mutex1.Start();
            thread_mutex2.Start();
            thread_produce = new Thread(new ThreadStart(Produce));
            thread_convey = new Thread(new ThreadStart(Fuction_Convey));
            thread_produce.Start();
            thread_convey.Start();
            Stop.Enabled = true;
            Restart.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)//窗体一加载启动所有线程
        {
            this.Restart.Enabled = false;
            thread_counter1 = new Thread(new ThreadStart(Counter1));
            thread_counter2 = new Thread(new ThreadStart(Counter2));
            thread_counter1.Start();
            thread_counter2.Start();
            thread_lock1 = new Thread(new ThreadStart(Thread_lock1_ShowChar));
            thread_lock2 = new Thread(new ThreadStart(Thread_lock2_ShowChar));
            thread_lock1.Start();
            thread_lock2.Start();
            thread_monitor1 = new Thread(new ThreadStart(Thread_monitor1_ShowChar));
            thread_monitor2 = new Thread(new ThreadStart(Thread_monitor2_ShowChar));
            thread_monitor1.Start();
            thread_monitor2.Start();
            thread_mutex1 = new Thread(new ThreadStart(Thread_mutex1_ShowChar));
            thread_mutex2 = new Thread(new ThreadStart(Thread_mutex2_ShowChar));
            thread_mutex1.Start();
            thread_mutex2.Start();
            thread_produce = new Thread(new ThreadStart(Produce));
            thread_convey = new Thread(new ThreadStart(Fuction_Convey));
            thread_produce.Start();
            thread_convey.Start();
            //在C#中使用Thread类创建线程时,只需提供线程入口即可
            //线程入口是由ThreadStart代理delegate提供的
            //可以把ThreadStart理解成一个指针,指向线程要执行的函数
            //线程启动时执行ThreadStart说指向的函数
            //休眠线程Sleep()
            //挂起线程Suspend()方法用来挂起线程,如果线程已经被挂起,此方法不起作用
            //回复线程Resume()方法用来继续执行线程,如果线程未被挂起,此方法不起作用
            //终止线程Interrupt()方法用来终止处于Wait/Sleep或Join状态的线程
            //阻塞线程Join()方法用来阻塞调用线程,直到线程终止为止
            //线程从创建开始一定处于某种状态,当线程被创建时处于Unstart状态,Start方法将其变成Running状态
            //一旦线程被终止或销毁,线程将处于Stopped状态,此时线程不复存在
            //线程还有一个Background状态,表明线程处于后台还是前台
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//关闭窗体时终止所有线程,否则程序还将处于调试状态
        {
            if (thread_counter1!=null)
            {
                thread_counter1.Abort();
            }
            if (thread_counter2 != null)
            {
                thread_counter2.Abort();
            }
            if (thread_lock1 != null)
            {
                thread_lock1.Abort();
            }
            if (thread_lock2 != null)
            {
                thread_lock2.Abort();
            }
            if (thread_monitor1 != null)
            {
                thread_monitor1.Abort();
            }
            if (thread_monitor2 != null)
            {
                thread_monitor2.Abort();
            }
            if (thread_mutex1 != null)
            {
                thread_mutex1.Abort();
            }
            if (thread_mutex2 != null)
            {
                thread_mutex2.Abort();
            }
            if (thread_produce != null)
            {
                thread_produce.Abort();
            }
            if (thread_convey != null)
            {
                thread_convey.Abort();
            }
        }
        
        private void 初级自测试题PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimaryExamForm PFrm = new PrimaryExamForm();//实例化PrimaryExamForm
            PFrm.Show();//调用Show()方法显示窗体
        }
        
        private void ToolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            String sltltem = this.toolStripComboBox1.Text;//组合框选项
            switch (sltltem)
            {
                case ("初级自测试题"):
                    PrimaryExamForm PFrm = new PrimaryExamForm();//实例化PrimaryExamForm
                    PFrm.Show();//调用Show()方法显示窗体
                    break;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于系统AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutFrm = new AboutBox1();
            AboutFrm.ShowDialog();//模态方式打开窗体
        }

        private void OpenADO_Click(object sender, EventArgs e)
        {
            ADO ado = new ADO();
            ado.Show();
        }

        private void OpenPCD_Click(object sender, EventArgs e)
        {
            PCD pcd = new PCD();
            pcd.Show();
        }

        private void OpenADO2_Click(object sender, EventArgs e)
        {
            ADO2 ado2 = new ADO2();
            ado2.Show();
        }
    }
}
//访问Windows窗体控件本质上不是线程安全的,如果由两个或多个线程同时操作某一控件时
//可能会使控件进入一种不一致的状态,还可能出现争用和死锁
//在C#中也可以采用非线程安全的方法访问窗体控件,.NET Framework有助于在以非线程安全方式访问窗体控件时发现问题
//在调试器中运行程序时,如果在创建某控件的线程之外的其他线程试图直接调用该控件,调试器就会引发InvalidOperationException异常
//警告对控件的调用不是线程安全的,所以在此应用程序一开始就禁用了CheckForIllegalCrossThreadCalls异常