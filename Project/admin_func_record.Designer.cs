namespace Project
{
    partial class admin_func_record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ACTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARGET_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUEST_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_BUSINESS_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_BUSINESS_TITLE_DETAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1PERSON_COMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_DEPTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_JOB_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_JOB_FAMILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_LOCATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_MGR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_ROLLUP_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_ROLLUP_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON_ROLLUP_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(757, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 67);
            this.label6.TabIndex = 6;
            this.label6.Text = "用户访问日志";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "被挂起",
            "一天内",
            "三天内",
            "一周内",
            "一个月内",
            "半年内"});
            this.comboBox1.Location = new System.Drawing.Point(491, 146);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 41);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(229, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "条件筛选：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project.Properties.Resources.center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 1033);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(1600, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "返回";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTION,
            this.TARGET_NAME,
            this.REQUEST_DATE,
            this.PERSON_BUSINESS_TITLE,
            this.PERSON_BUSINESS_TITLE_DETAIL,
            this.Column1PERSON_COMPANY,
            this.PERSON_DEPTNAME,
            this.PERSON_JOB_CODE,
            this.PERSON_JOB_FAMILY,
            this.PERSON_LOCATION,
            this.PERSON_MGR_ID,
            this.PERSON_ROLLUP_1,
            this.PERSON_ROLLUP_2,
            this.PERSON_ROLLUP_3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(137, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1668, 650);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ACTION
            // 
            this.ACTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ACTION.Frozen = true;
            this.ACTION.HeaderText = "权限";
            this.ACTION.MinimumWidth = 100;
            this.ACTION.Name = "ACTION";
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TARGET_NAME
            // 
            this.TARGET_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TARGET_NAME.Frozen = true;
            this.TARGET_NAME.HeaderText = "资源名称";
            this.TARGET_NAME.MinimumWidth = 100;
            this.TARGET_NAME.Name = "TARGET_NAME";
            // 
            // REQUEST_DATE
            // 
            this.REQUEST_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.REQUEST_DATE.Frozen = true;
            this.REQUEST_DATE.HeaderText = "访问时间";
            this.REQUEST_DATE.MinimumWidth = 125;
            this.REQUEST_DATE.Name = "REQUEST_DATE";
            this.REQUEST_DATE.ReadOnly = true;
            this.REQUEST_DATE.Width = 125;
            // 
            // PERSON_BUSINESS_TITLE
            // 
            this.PERSON_BUSINESS_TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_BUSINESS_TITLE.HeaderText = "商务头衔";
            this.PERSON_BUSINESS_TITLE.MinimumWidth = 100;
            this.PERSON_BUSINESS_TITLE.Name = "PERSON_BUSINESS_TITLE";
            // 
            // PERSON_BUSINESS_TITLE_DETAIL
            // 
            this.PERSON_BUSINESS_TITLE_DETAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_BUSINESS_TITLE_DETAIL.HeaderText = "头衔细节";
            this.PERSON_BUSINESS_TITLE_DETAIL.MinimumWidth = 100;
            this.PERSON_BUSINESS_TITLE_DETAIL.Name = "PERSON_BUSINESS_TITLE_DETAIL";
            // 
            // Column1PERSON_COMPANY
            // 
            this.Column1PERSON_COMPANY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1PERSON_COMPANY.HeaderText = "公司";
            this.Column1PERSON_COMPANY.MinimumWidth = 100;
            this.Column1PERSON_COMPANY.Name = "Column1PERSON_COMPANY";
            this.Column1PERSON_COMPANY.ReadOnly = true;
            // 
            // PERSON_DEPTNAME
            // 
            this.PERSON_DEPTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_DEPTNAME.HeaderText = "部门";
            this.PERSON_DEPTNAME.MinimumWidth = 100;
            this.PERSON_DEPTNAME.Name = "PERSON_DEPTNAME";
            this.PERSON_DEPTNAME.ReadOnly = true;
            // 
            // PERSON_JOB_CODE
            // 
            this.PERSON_JOB_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_JOB_CODE.HeaderText = "工作编号";
            this.PERSON_JOB_CODE.MinimumWidth = 100;
            this.PERSON_JOB_CODE.Name = "PERSON_JOB_CODE";
            this.PERSON_JOB_CODE.ReadOnly = true;
            // 
            // PERSON_JOB_FAMILY
            // 
            this.PERSON_JOB_FAMILY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_JOB_FAMILY.HeaderText = "工作小组";
            this.PERSON_JOB_FAMILY.MinimumWidth = 100;
            this.PERSON_JOB_FAMILY.Name = "PERSON_JOB_FAMILY";
            this.PERSON_JOB_FAMILY.ReadOnly = true;
            // 
            // PERSON_LOCATION
            // 
            this.PERSON_LOCATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_LOCATION.HeaderText = "所在地";
            this.PERSON_LOCATION.MinimumWidth = 100;
            this.PERSON_LOCATION.Name = "PERSON_LOCATION";
            this.PERSON_LOCATION.ReadOnly = true;
            // 
            // PERSON_MGR_ID
            // 
            this.PERSON_MGR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_MGR_ID.HeaderText = "设备编号";
            this.PERSON_MGR_ID.MinimumWidth = 100;
            this.PERSON_MGR_ID.Name = "PERSON_MGR_ID";
            this.PERSON_MGR_ID.ReadOnly = true;
            // 
            // PERSON_ROLLUP_1
            // 
            this.PERSON_ROLLUP_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_ROLLUP_1.HeaderText = "标识1";
            this.PERSON_ROLLUP_1.MinimumWidth = 100;
            this.PERSON_ROLLUP_1.Name = "PERSON_ROLLUP_1";
            this.PERSON_ROLLUP_1.ReadOnly = true;
            // 
            // PERSON_ROLLUP_2
            // 
            this.PERSON_ROLLUP_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSON_ROLLUP_2.HeaderText = "标识2";
            this.PERSON_ROLLUP_2.MinimumWidth = 100;
            this.PERSON_ROLLUP_2.Name = "PERSON_ROLLUP_2";
            this.PERSON_ROLLUP_2.ReadOnly = true;
            // 
            // PERSON_ROLLUP_3
            // 
            this.PERSON_ROLLUP_3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PERSON_ROLLUP_3.HeaderText = "标识3";
            this.PERSON_ROLLUP_3.MinimumWidth = 75;
            this.PERSON_ROLLUP_3.Name = "PERSON_ROLLUP_3";
            this.PERSON_ROLLUP_3.ReadOnly = true;
            // 
            // admin_func_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.center;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_func_record";
            this.Text = "用户访问记录";
            this.Load += new System.EventHandler(this.admin_func_record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARGET_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUEST_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_BUSINESS_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_BUSINESS_TITLE_DETAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1PERSON_COMPANY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_DEPTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_JOB_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_JOB_FAMILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_LOCATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_MGR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_ROLLUP_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_ROLLUP_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSON_ROLLUP_3;
        private System.Windows.Forms.Label label1;
    }
}