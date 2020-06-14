using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Project
{
    public partial class ad_rules_ch : Form
    {
        public ad_rules_ch()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];


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

            }

            DataGridViewButtonColumn btnDELETE = new DataGridViewButtonColumn();
            btnDELETE.Name = "btnDELETE";
            btnDELETE.HeaderText = "删除";
            btnDELETE.DefaultCellStyle.NullValue = "删除";
            btnDELETE.Width = 61;
            dataGridView1.Columns.Add(btnDELETE);

            DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            btnMDF.Name = "btnMDF";
            btnMDF.HeaderText = "修改";
            btnMDF.DefaultCellStyle.NullValue = "修改";
            btnMDF.Width = 61;
            dataGridView1.Columns.Add(btnMDF);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_add_rules add_Rules = new ad_add_rules();
            add_Rules.Show();
            this.Dispose();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnMDF" && e.RowIndex >= 0)  //单击修改
            {
                Rule rule = new Rule(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value));

                Static.rule_index.RemoveAt(e.RowIndex);
                Static.rule_index.Add(rule);
                IOStream iOStream = new IOStream();
                string filepath = "..\\..\\rule.csv"; // 文件路径
                FileStream fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                for (int i = 0; i < Static.rule_index.Count; i++)
                {
                    Rule now = (Rule)Static.rule_index[i];
                    iOStream.write_rule(now);
                }

                ad_ch_success form = new ad_ch_success();
                form.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDELETE" && e.RowIndex >= 0)  //单击删除
            {
                IOStream iOStream = new IOStream();
                string filepath = "..\\..\\rule.csv"; // 文件路径
                FileStream fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                int index = -1;
                for (int i = 0; i < Static.rule_index.Count; i++)
                {
                    Rule now = (Rule)Static.rule_index[i];
                    if (now.ACTION == (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value &&
                    now.TARGET_NAME == (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value &&
                    now.PERSON_BUSINESS_TITLE == (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value &&
                    now.PERSON_BUSINESS_TITLE_DETAIL == (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value &&
                    now.PERSON_COMPANY == (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value &&
                    now.PERSON_DEPTNAME == (int)dataGridView1.Rows[e.RowIndex].Cells[5].Value &&
                    now.PERSON_JOB_CODE == (int)dataGridView1.Rows[e.RowIndex].Cells[6].Value &&
                    now.PERSON_JOB_FAMILY == (int)dataGridView1.Rows[e.RowIndex].Cells[7].Value &&
                    now.PERSON_LOCATION == (int)dataGridView1.Rows[e.RowIndex].Cells[8].Value &&
                    now.PERSON_MGR_ID == (int)dataGridView1.Rows[e.RowIndex].Cells[9].Value &&
                    now.PERSON_ROLLUP_1 == (int)dataGridView1.Rows[e.RowIndex].Cells[10].Value &&
                    now.PERSON_ROLLUP_2 == (int)dataGridView1.Rows[e.RowIndex].Cells[11].Value &&
                    now.PERSON_ROLLUP_3 == (int)dataGridView1.Rows[e.RowIndex].Cells[12].Value)
                    {
                        index = i;
                    }
                    else
                    {
                        iOStream.write_rule(now);
                    }
                }
                if (index != -1)
                    Static.rule_index.RemoveAt(index);
                else
                    System.Console.WriteLine("NOT FOUND");

                ad_ch_success form = new ad_ch_success();
                form.Show();
            }


            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];


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

            }
            
        }

        private void ad_rules_ch_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ad_add_rules add_Rules = new ad_add_rules();
            add_Rules.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnMDF" && e.RowIndex >= 0)  //单击修改
            {
                Rule rule = new Rule(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value),
                   Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value),
                 Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value));

                Static.rule_index.RemoveAt(e.RowIndex);
                Static.rule_index.Add(rule);
                IOStream iOStream = new IOStream();
                string filepath = "..\\..\\rule.csv"; // 文件路径
                FileStream fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                for (int i = 0; i < Static.rule_index.Count; i++)
                {
                    Rule now = (Rule)Static.rule_index[i];
                    iOStream.write_rule(now);
                }

                ad_ch_success form = new ad_ch_success();
                form.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDELETE" && e.RowIndex >= 0)  //单击删除
            {
                IOStream iOStream = new IOStream();
                string filepath = "..\\..\\rule.csv"; // 文件路径
                FileStream fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                int index = -1;
                for (int i = 0; i < Static.rule_index.Count; i++)
                {
                    Rule now = (Rule)Static.rule_index[i];
                    if (now.ACTION == (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value &&
                    now.TARGET_NAME == (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value &&
                    now.PERSON_BUSINESS_TITLE == (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value &&
                    now.PERSON_BUSINESS_TITLE_DETAIL == (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value &&
                    now.PERSON_COMPANY == (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value &&
                    now.PERSON_DEPTNAME == (int)dataGridView1.Rows[e.RowIndex].Cells[5].Value &&
                    now.PERSON_JOB_CODE == (int)dataGridView1.Rows[e.RowIndex].Cells[6].Value &&
                    now.PERSON_JOB_FAMILY == (int)dataGridView1.Rows[e.RowIndex].Cells[7].Value &&
                    now.PERSON_LOCATION == (int)dataGridView1.Rows[e.RowIndex].Cells[8].Value &&
                    now.PERSON_MGR_ID == (int)dataGridView1.Rows[e.RowIndex].Cells[9].Value &&
                    now.PERSON_ROLLUP_1 == (int)dataGridView1.Rows[e.RowIndex].Cells[10].Value &&
                    now.PERSON_ROLLUP_2 == (int)dataGridView1.Rows[e.RowIndex].Cells[11].Value &&
                    now.PERSON_ROLLUP_3 == (int)dataGridView1.Rows[e.RowIndex].Cells[12].Value)
                    {
                        index = i;
                    }
                    else
                    {
                        iOStream.write_rule(now);
                    }
                }
                if (index != -1)
                    Static.rule_index.RemoveAt(index);
                else
                    System.Console.WriteLine("NOT FOUND");

                ad_ch_success form = new ad_ch_success();
                form.Show();
            }


            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];


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

            }

        }
    }
}
