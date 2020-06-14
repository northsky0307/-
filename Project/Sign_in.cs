using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{


    public partial class Sign_in : Form
    {
        private User_operation user_Datebase = new User_operation();
        public Sign_in()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            //changeSize();
            //InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ID = textBox1.Text.Trim();
           
            if (ID == "admin")
            {
                admin_func_choose form = new admin_func_choose();
                form.Show();
                this.Hide();
                System.Console.WriteLine("type : admin");
            }
            else
            {
                User_operation user_Operation = new User_operation();

                if (user_Operation.Query(ID))
                {
                    //界面替换
                    user_query form = new user_query();
                    form.Show();
                    this.Hide();
                    System.Console.WriteLine("type : user");

                }
                else
                {
                    //用户不存在
                    error_no_exist form = new error_no_exist();
                    form.Show();

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //点击退出
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        void changeSize()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲DoubleBuffer

            
            this.FormBorderStyle = FormBorderStyle.None;
            

          // projectUrl = Path.GetDirectoryName(Application.ExecutablePath);
              
            this.WindowState = FormWindowState.Maximized;
            x = (float)1920.0 / this.Width;
            y = (float)1080.0 / this.Height;
            //x = 1920;
            //y = 1080;
            setTag(this);
            //System.Console.WriteLine(x);
            //System.Console.WriteLine(y);
            setControls(x, y, this); 
        }

        #region 控件大小随窗体大小等比例缩放
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
                
            }
        }
        //设置双缓冲区、解决闪屏问题
        public static void SetDouble(Control cc)
        {

            cc.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
                         System.Reflection.BindingFlags.NonPublic).SetValue(cc, true, null);

        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                ////获取控件的Tag属性值，并分割后存储字符串数组
                SetDouble(this);
                SetDouble(con);
               System.Console.WriteLine(con.Tag);
                if (con.Tag != null)
                {

                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    System.Console.WriteLine(con.Font);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }


            }
        }

        //在窗体的的时间中添加Resize事件
        private void Login_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
        #endregion
    }
}
