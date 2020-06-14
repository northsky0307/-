using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    public static class Static
    {
        //public static string name;
        public static ArrayList rule_index = new ArrayList(); //规则
        public static ArrayList query_history_index = new ArrayList(); //访问历史
        public static ArrayList hang_index = new ArrayList();//挂起访问
        public static ArrayList user_index = new ArrayList();//用户信息

        public static int targetnum;

        public static string PERSON_BUSINESS_TITLE;
        public static string PERSON_BUSINESS_TITLE_DETAIL;
        public static string PERSON_COMPANY;
        public static string PERSON_DEPTNAME;
        public static string PERSON_JOB_CODE;
        public static string PERSON_JOB_FAMILY;
        public static string PERSON_LOCATION;
        public static string PERSON_MGR_ID;
        public static string PERSON_ROLLUP_1;
        public static string PERSON_ROLLUP_2;
        public static string PERSON_ROLLUP_3;
    }
}
