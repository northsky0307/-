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
    public partial class user_no_limit_hang : Form
    {
        public user_no_limit_hang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //增加一条挂起访问记录 arraylist
            Hang hAng = new Hang();
            hAng.Add_hang(Static.targetnum,
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
           Convert.ToInt32(Static.PERSON_ROLLUP_3));
            Static.hang_index.Add(hAng);
            IOStream iOStream = new IOStream();
            iOStream.write_hang(hAng);
            System.Console.WriteLine(Static.hang_index.Count);
            user_no_rule error_tip = new user_no_rule();
            error_tip.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hang hAng = new Hang();
            hAng.Add_hang(Static.targetnum,
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
           Convert.ToInt32(Static.PERSON_ROLLUP_3));
            Static.hang_index.Add(hAng);
            IOStream iOStream = new IOStream();
            iOStream.write_hang(hAng);
            System.Console.WriteLine(Static.hang_index.Count);
            user_no_rule error_tip = new user_no_rule();
            error_tip.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
