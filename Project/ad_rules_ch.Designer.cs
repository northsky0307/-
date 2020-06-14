namespace Project
{
    partial class ad_rules_ch
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ACTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARGET_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(122, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "已有访问策略：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 67);
            this.label2.TabIndex = 5;
            this.label2.Text = "管理访问策略";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(84, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1700, 650);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(1600, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "返回";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(878, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "增加访问策略";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ad_rules_ch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.center;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ad_rules_ch";
            this.Text = "规则管理";
            this.Load += new System.EventHandler(this.ad_rules_ch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARGET_NAME;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}