using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project
{
    public partial class user_history : Form
    {
        public user_history()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
            ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数  9670应为用户名；
            for (int i = 0; i <query.Count ; i++ )
            {

                Query_history query_out_his = (Query_history)query[i];
                int index = this.dataGridView1.Rows.Add();
                
                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.REQUEST_DATE;
                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE;
                this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_COMPANY;
                this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_DEPTNAME;
                this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_CODE;
                this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_JOB_FAMILY;
                this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_LOCATION;
                this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_MGR_ID;
                this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_1;
                this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_2;
                this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.PERSON_ROLLUP_3;
                
                /*
                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.ACTION;  //授权结果
                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.TARGET_NAME;   //资源名称
                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.REQUEST_DATE;
                this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_BUSINESS_TITLE;
                this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_COMPANY;
                this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_DEPTNAME;
                this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_JOB_CODE;
                this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_JOB_FAMILY;
                this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_LOCATION;
                this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_MGR_ID;
                this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_1;
                this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.PERSON_ROLLUP_2;
                this.dataGridView1.Rows[index].Cells[14].Value = query_out_his.PERSON_ROLLUP_3;
                */
            }
            // System.Console.WriteLine(Static.query_history_index.Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //界面替换 点击查询历史界面中的返回按钮  回到查询界面
            user_query form = new user_query();
            form.Show();
            this.Dispose();
        }
        //关闭子窗口，同时结束父窗口
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ReadOnly = true; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void user_history_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];

                    int index = this.dataGridView1.Rows.Add();

                    this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                    this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                    this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                    this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                    this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                    this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                    this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                    this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                    this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                    this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                    this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                    this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                    this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间  
                }
            }
            if ((string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if(time_ <= 180) {

                        

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间  
                    }

                }
            }

            if ((string)comboBox1.SelectedItem == "十二年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 4380)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }


            if ((string)comboBox1.SelectedItem == "三个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 90.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "一个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 30.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "一周内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 7.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "今天")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 1.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "允许"&&(string)comboBox1.SelectedItem == "十二年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access"&& time_<= 4380)
                    {
                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            /*
            if ((string)comboBox2.SelectedItem == "允许"&&(string)comboBox1.SelectedItem == null)
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access")
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            */
            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" )
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }

            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" && time_ <= 180.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "三个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" && time_ <= 90.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "一个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" && time_ <= 30.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "一周内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" && time_ <= 7.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "允许" && (string)comboBox1.SelectedItem == "今天")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "add_access" && time_ <= 1.0)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            /*
            if ((string)comboBox2.SelectedItem == "拒绝"&&(string)comboBox1.SelectedItem == null)
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access")
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            */
            if ((string)comboBox2.SelectedItem == "拒绝"&&(string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access")
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "十二年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <= 4380)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <= 180)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "三个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <=90.0)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "一个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <= 30.0)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "一周内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <= 7.0)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝" && (string)comboBox1.SelectedItem == "今天")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "remove_access" && time_ <= 1.0)
                    {


                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                    }

                }
            }
            /*
            if ((string)comboBox2.SelectedItem == "挂起"&&(string)comboBox1.SelectedItem == null)
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;

                    int index = this.dataGridView1.Rows.Add();

                    //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                    this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                    this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                    this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                    this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                    this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                    this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                    this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                    this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                    this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                    this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                    this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                    this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间 
                }
            }
            */

            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;

                    int index = this.dataGridView1.Rows.Add();

                    //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                    this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                    this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                    this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                    this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                    this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                    this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                    this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                    this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                    this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                    this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                    this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                    this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "十二年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 4380)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 180.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "三个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 90.0)
                    {
                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "一个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 30.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "一周内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 7.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
            if ((string)comboBox2.SelectedItem == "挂起" && (string)comboBox1.SelectedItem == "今天")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_hang_history(
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE),
                   Convert.ToInt32(Static.PERSON_BUSINESS_TITLE_DETAIL),
                   Convert.ToInt32(Static.PERSON_COMPANY),
                   Convert.ToInt32(Static.PERSON_DEPTNAME),
                   Convert.ToInt32(Static.PERSON_JOB_CODE),
                   Convert.ToInt32(Static.PERSON_JOB_FAMILY),
                   Convert.ToInt32(Static.PERSON_LOCATION),
                   Convert.ToInt32(Static.PERSON_MGR_ID),
                   Convert.ToInt32(Static.PERSON_ROLLUP_1),
                   Convert.ToInt32(Static.PERSON_ROLLUP_2),
                   Convert.ToInt32(Static.PERSON_ROLLUP_3)); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Hang query_out_his = (Hang)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 1.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.ACTION;  //授权结果
                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称
                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;
                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                        this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_COMPANY;
                        this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_DEPTNAME;
                        this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_JOB_CODE;
                        this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_JOB_FAMILY;
                        this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_LOCATION;
                        this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_MGR_ID;
                        this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_ROLLUP_1;
                        this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_2;
                        this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;
                        this.dataGridView1.Rows[index].Cells[13].Value = query_out_his.REQUEST_DATE;  //时间
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            user_query form = new user_query();
            form.Show();
            this.Dispose();
        }
    }
}
