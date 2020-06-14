using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        public string LOGIN;
        public string PERSON_BUSINESS_TITLE;
        public string PERSON_BUSINESS_TITLE_DETAIL;
        public string PERSON_COMPANY;
        public string PERSON_DEPTNAME;
        public string PERSON_JOB_CODE;
        public string PERSON_JOB_FAMILY;
        public string PERSON_LOCATION;
        public string PERSON_MGR_ID;
        public string PERSON_ROLLUP_1;
        public string PERSON_ROLLUP_2;
        public string PERSON_ROLLUP_3;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="LOGIN"></param>
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
        public User(string LOGIN, string PERSON_BUSINESS_TITLE, string PERSON_BUSINESS_TITLE_DETAIL, string PERSON_COMPANY, string PERSON_DEPTNAME, string PERSON_JOB_CODE, string PERSON_JOB_FAMILY,
                             string PERSON_LOCATION, string PERSON_MGR_ID, string PERSON_ROLLUP_1, string PERSON_ROLLUP_2, string PERSON_ROLLUP_3) //构造函数
        {
            this.LOGIN = LOGIN;
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
