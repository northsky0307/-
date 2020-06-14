using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ad_rule_fptree : Form
    {
        public ad_rule_fptree()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\fp.exe";
            first_use first_Use = new first_use();
            Process p = Process.Start(path);
            p.WaitForExit();//关键，等待外部程序退出后才能往下执行
            Static.rule_index.Clear();

            //ad_ch_success form = new ad_ch_success();
            IOStream iO = new IOStream();
            iO.Get_rule();
            this.dataGridView1.Rows.Clear();
            //Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类

            for (int i = Static.rule_index.Count - 1; i >= 40 ; i--)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];
                if(query_out_his.ACTION == 1 )
                {
                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.ACTION;  //授权结果
                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.TARGET_NAME;   //资源名称
                //this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.REQUEST_DATE;
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

                }

            }

            accept_change form = new accept_change();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query_history query_History;
            Rule rule;
            string ACTION;
            IOStream iOStream = new IOStream();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 0)
                {
                    ACTION = "add_access";
                }
                else
                {

                    ACTION = "remove_access";
                }
                Hang hang = new Hang
                (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),
                 Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
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
                 
                 DateTime.Now);



                rule = new Rule(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), hang.TARGET_NAME, hang.PERSON_BUSINESS_TITLE, hang.PERSON_BUSINESS_TITLE_DETAIL, hang.PERSON_COMPANY, hang.PERSON_DEPTNAME, hang.PERSON_JOB_CODE, hang.PERSON_JOB_FAMILY,
                             hang.PERSON_LOCATION, hang.PERSON_MGR_ID, hang.PERSON_ROLLUP_1, hang.PERSON_ROLLUP_2, hang.PERSON_ROLLUP_3); //构造函数
                Static.rule_index.Add(rule);
                iOStream.write_rule(rule);
            }

            this.dataGridView1.Rows.Clear();
            ad_ch_success form = new ad_ch_success();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
