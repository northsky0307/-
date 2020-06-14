using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ad_add_rules : Form
    {
        public ad_add_rules()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            System.Console.WriteLine(this.Width);
            System.Console.WriteLine(this.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_rules_ch form = new ad_rules_ch();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //单击按钮后添加规则  根据textbox1-4  
            //若想在规则列表中看到返回再进
            Rule rule = new Rule(Convert.ToInt32(textBox1.Text.Trim()),
                Convert.ToInt32(textBox2.Text.Trim()),
                Convert.ToInt32(textBox3.Text.Trim()),
                Convert.ToInt32(textBox4.Text.Trim()),
                Convert.ToInt32(textBox5.Text.Trim()),
                Convert.ToInt32(textBox6.Text.Trim()),
                Convert.ToInt32(textBox7.Text.Trim()),
                Convert.ToInt32(textBox8.Text.Trim()),
                Convert.ToInt32(textBox9.Text.Trim()),
                Convert.ToInt32(textBox10.Text.Trim()),
                Convert.ToInt32(textBox11.Text.Trim()),
                Convert.ToInt32(textBox12.Text.Trim()),
                Convert.ToInt32(textBox13.Text.Trim())
                );

            IOStream iOStream = new IOStream();
            Static.rule_index.Add(rule);
            iOStream.write_rule(rule);
            ad_ch_success ad_Ch_Success = new ad_ch_success();
            ad_Ch_Success.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_add_rules_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rule rule = new Rule(Convert.ToInt32(textBox1.Text.Trim()),
                Convert.ToInt32(textBox2.Text.Trim()),
                Convert.ToInt32(textBox3.Text.Trim()),
                Convert.ToInt32(textBox4.Text.Trim()),
                Convert.ToInt32(textBox5.Text.Trim()),
                Convert.ToInt32(textBox6.Text.Trim()),
                Convert.ToInt32(textBox7.Text.Trim()),
                Convert.ToInt32(textBox8.Text.Trim()),
                Convert.ToInt32(textBox9.Text.Trim()),
                Convert.ToInt32(textBox10.Text.Trim()),
                Convert.ToInt32(textBox11.Text.Trim()),
                Convert.ToInt32(textBox12.Text.Trim()),
                Convert.ToInt32(textBox13.Text.Trim())
                );

            IOStream iOStream = new IOStream();
            Static.rule_index.Add(rule);
            iOStream.write_rule(rule);
            ad_ch_success ad_Ch_Success = new ad_ch_success();
            ad_Ch_Success.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ad_rules_ch form = new ad_rules_ch();
            form.Show();
            this.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
