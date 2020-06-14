using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rule
    {
        public int ACTION;
        public int TARGET_NAME;
        public int PERSON_BUSINESS_TITLE;
        public int PERSON_BUSINESS_TITLE_DETAIL;
        public int PERSON_COMPANY;
        public int PERSON_DEPTNAME;
        public int PERSON_JOB_CODE;
        public int PERSON_JOB_FAMILY;
        public int PERSON_LOCATION;
        public int PERSON_MGR_ID;
        public int PERSON_ROLLUP_1;
        public int PERSON_ROLLUP_2;
        public int PERSON_ROLLUP_3;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ACTION"></param>
        /// <param name="TARGET_NAME"></param>
        /// <param name="PERSON_BUSINESS_TITLE"></param>
        /// <param name="PERSON_BUSINESS_TITLE_DETAIL"></param>
        /// <param name="PERSON_COMPANY"></param>
        /// <param name="PERSON_DEPTNAME"></param>
        /// <param name="PERSON_JOB_CODE"></param>
        /// <param name="PERSON_JOB_FAMILY"></param>
        /// <param name="PERSON_LOCATION"></param>
        /// <param name="PERSON_MGR_ID"></param>
        /// <param name="PERSON_ROLLUP_1"></param>
        /// <param name="PERSON_ROLLUP_2"></param>
        /// <param name="PERSON_ROLLUP_3"></param>
        public Rule(int ACTION, int TARGET_NAME, int PERSON_BUSINESS_TITLE, int PERSON_BUSINESS_TITLE_DETAIL, int PERSON_COMPANY, int PERSON_DEPTNAME, int PERSON_JOB_CODE, int PERSON_JOB_FAMILY,
                             int PERSON_LOCATION, int PERSON_MGR_ID, int PERSON_ROLLUP_1, int PERSON_ROLLUP_2, int PERSON_ROLLUP_3) //构造函数
        {
            this.ACTION = ACTION;
            this.TARGET_NAME = TARGET_NAME;
            this.PERSON_BUSINESS_TITLE = PERSON_BUSINESS_TITLE;
            this.PERSON_BUSINESS_TITLE_DETAIL = PERSON_BUSINESS_TITLE_DETAIL;
            this.PERSON_COMPANY = PERSON_COMPANY;
            this.PERSON_DEPTNAME = PERSON_DEPTNAME;
            this.PERSON_JOB_CODE = PERSON_JOB_CODE;
            this.PERSON_JOB_FAMILY = PERSON_JOB_FAMILY;
            this.PERSON_LOCATION = PERSON_LOCATION;
            this.PERSON_MGR_ID = PERSON_MGR_ID;
            this.PERSON_ROLLUP_1 = PERSON_ROLLUP_1;
            this.PERSON_ROLLUP_2 = PERSON_ROLLUP_2;
            this.PERSON_ROLLUP_3 = PERSON_ROLLUP_3;
        }
    }
}
