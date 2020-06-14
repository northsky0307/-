using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Project
{
    class HelloWord
    {
        public static void Main()
        {
            //Form1 用户窗口1  Form2  登陆界面
            //窗口2的引用

            IOStream my_iostream = new IOStream(); //csv 读写

            string filepath = "..\\..\\rule.csv";
            if (!File.Exists(filepath)) //没有规则文件 通过关联规则生成规则文件
            {
                //string path = System.Environment.CurrentDirectory;当前工作路径

                string path = "..\\..\\fp.exe";
                first_use first_Use = new first_use();
                Process p = Process.Start(path);
                Application.Run(first_Use);
                p.WaitForExit();//关键，等待外部程序退出后才能往下执行
                //first_Use.Dispose();
                
            }
            my_iostream.Get_hang(); //读取挂起
            my_iostream.Get_rule(); //读取规则
            my_iostream.Get_query(); // 读取访问记录
            my_iostream.Get_user();
            Sign_in sign_In = new Sign_in();
            Application.Run(sign_In);
        }
    }
}