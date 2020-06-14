using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ad_rules_hang : Form
    {
        public ad_rules_hang()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dataGridView1.Rows.Clear();
            Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类

            for (int i = 0; i < Static.hang_index.Count; i++)
            {
                Hang query_out_his = (Hang)Static.hang_index[i];
                TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                double time_ = time_dis.TotalDays;

                int index = this.dataGridView1.Rows.Add();

                //this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.ACTION;  //授权结果
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
            }


            //DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            //btnMDF.Name = "btnMDF";
            //btnMDF.HeaderText = "修改";
            //btnMDF.DefaultCellStyle.NullValue = "修改";
            //btnMDF.Width = 61;
            //dataGridView1.Columns.Add(btnMDF);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


         private void ad_rules_join_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Query_history query_History;
            Rule rule;
            string ACTION;
            IOStream iOStream = new IOStream();
            for (int i = 0; i < dataGridView1.Rows.Count; i ++)
            {
                if(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value )== 0)
                {
                    ACTION = "add_access";
                }
                else
                {

                    ACTION = "remove_access";
                }
                Hang hang = new Hang
                (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[12].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[14].Value),
                 Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value));


                query_History = new Query_history(ACTION, hang.TARGET_NAME, hang.PERSON_BUSINESS_TITLE, hang.PERSON_BUSINESS_TITLE_DETAIL, hang.PERSON_COMPANY, hang.PERSON_DEPTNAME, hang.PERSON_JOB_CODE, hang.PERSON_JOB_FAMILY,
                             hang.PERSON_LOCATION, hang.PERSON_MGR_ID, hang.PERSON_ROLLUP_1, hang.PERSON_ROLLUP_2, hang.PERSON_ROLLUP_3, hang.REQUEST_DATE); //构造函数
                Static.query_history_index.Add(query_History);
                iOStream.write_query(query_History);

                rule = new Rule(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), hang.TARGET_NAME, hang.PERSON_BUSINESS_TITLE, hang.PERSON_BUSINESS_TITLE_DETAIL, hang.PERSON_COMPANY, hang.PERSON_DEPTNAME, hang.PERSON_JOB_CODE, hang.PERSON_JOB_FAMILY,
                             hang.PERSON_LOCATION, hang.PERSON_MGR_ID, hang.PERSON_ROLLUP_1, hang.PERSON_ROLLUP_2, hang.PERSON_ROLLUP_3); //构造函数
                Static.rule_index.Add(rule);
                iOStream.write_rule(rule);
            }

            this.dataGridView1.Rows.Clear();
            ad_ch_success form = new ad_ch_success();
            form.Show();
        }
        
        

        private void button5_Click_1(object sender, EventArgs e)
        {
            accept_change form = new accept_change();
            string filepath = "..\\..\\hang.csv";
            if (File.Exists(filepath))
            {
                string path = "..\\..\\ss.exe";
                Process p = Process.Start(path);
                p.WaitForExit();//关键，等待外部程序退出后才能往下执行
            }
            else
            {
                form.Show();
                return;
            }
            string file_path = "..\\..\\result.csv";

            StreamReader mysr = new StreamReader(file_path, System.Text.Encoding.Default);
            string str; //文件行
            string[] now_string; //每一列

            Query_history_operation query_History_Operation = new Query_history_operation();
            Rule_operation rule_Operation = new Rule_operation();
            Hang hang;
            Query_history query_History;
            Rule rule;
            string ACTION;
            IOStream iOStream = new IOStream();

            int i = 0;

            this.dataGridView1.Rows.Clear(); //清空列表
            while ((str = mysr.ReadLine()) != null)
            {

                now_string = str.Split(',');
                int act = Convert.ToInt32(now_string[0]);
                if (act == 1)
                {
                    ACTION = "add_access";

                    Hang query_out_his = (Hang)Static.hang_index[i];

                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[1].Value = ACTION;  //授权结果
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

                }
                else
                {
                    ACTION = "remove_access";
                    hang = (Hang)Static.hang_index[i];
                    query_History = new Query_history(ACTION, hang.TARGET_NAME, hang.PERSON_BUSINESS_TITLE, hang.PERSON_BUSINESS_TITLE_DETAIL, hang.PERSON_COMPANY, hang.PERSON_DEPTNAME, hang.PERSON_JOB_CODE, hang.PERSON_JOB_FAMILY,
                                 hang.PERSON_LOCATION, hang.PERSON_MGR_ID, hang.PERSON_ROLLUP_1, hang.PERSON_ROLLUP_2, hang.PERSON_ROLLUP_3, hang.REQUEST_DATE); //构造函数
                    Static.query_history_index.Add(query_History);
                    iOStream.write_query(query_History);

                    rule = new Rule(act, hang.TARGET_NAME, hang.PERSON_BUSINESS_TITLE, hang.PERSON_BUSINESS_TITLE_DETAIL, hang.PERSON_COMPANY, hang.PERSON_DEPTNAME, hang.PERSON_JOB_CODE, hang.PERSON_JOB_FAMILY,
                                 hang.PERSON_LOCATION, hang.PERSON_MGR_ID, hang.PERSON_ROLLUP_1, hang.PERSON_ROLLUP_2, hang.PERSON_ROLLUP_3); //构造函数
                    Static.rule_index.Add(rule);
                    iOStream.write_rule(rule);
                }
                i++;
            }
            mysr.Close();
            //this.dataGridView1.Rows.Clear();
            iOStream.clear_hang();
            //ad_ch_success form = new ad_ch_success();
            //accept_change form = new accept_change();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }
    }
}
