using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rule_operation
    {
        /// <summary>
        /// 找到在规则内 返回action 否则返回字符串 hang
        /// </summary>
        /// <param name="TARGET_NAME"></param>    //resource 
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
        /// <returns></returns>
        public string Find(int TARGET_NAME = -1, int PERSON_BUSINESS_TITLE = -1, int PERSON_BUSINESS_TITLE_DETAIL = -1,
            int PERSON_COMPANY = -1, int PERSON_DEPTNAME = -1, int PERSON_JOB_CODE = -1, int PERSON_JOB_FAMILY = -1,
            int PERSON_LOCATION = -1, int PERSON_MGR_ID = -1, int PERSON_ROLLUP_1 = -1, int PERSON_ROLLUP_2 = -1, int PERSON_ROLLUP_3 = -1)
        {

            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                
                Rule rule = (Rule)Static.rule_index[i];
                if ((rule.TARGET_NAME == TARGET_NAME || rule.TARGET_NAME == -1) &&
                    (rule.PERSON_BUSINESS_TITLE == PERSON_BUSINESS_TITLE || rule.PERSON_BUSINESS_TITLE == -1) &&
                    (rule.PERSON_BUSINESS_TITLE_DETAIL == PERSON_BUSINESS_TITLE_DETAIL || rule.PERSON_BUSINESS_TITLE_DETAIL == -1) &&
                    (rule.PERSON_COMPANY == PERSON_COMPANY || rule.PERSON_COMPANY == -1) &&
                    (rule.PERSON_DEPTNAME == PERSON_DEPTNAME || rule.PERSON_DEPTNAME == -1) &&
                    (rule.PERSON_JOB_CODE == PERSON_JOB_CODE || rule.PERSON_JOB_CODE == -1) &&
                    (rule.PERSON_JOB_FAMILY == PERSON_JOB_FAMILY || rule.PERSON_JOB_FAMILY == -1) &&
                    (rule.PERSON_LOCATION == PERSON_LOCATION || rule.PERSON_LOCATION == -1) &&
                    (rule.PERSON_MGR_ID == PERSON_MGR_ID || rule.PERSON_MGR_ID == -1) &&
                    (rule.PERSON_ROLLUP_1 == PERSON_ROLLUP_1 || rule.PERSON_ROLLUP_1 == -1) &&
                    (rule.PERSON_ROLLUP_2 == PERSON_ROLLUP_2 || rule.PERSON_ROLLUP_2 == -1) &&
                    (rule.PERSON_ROLLUP_3 == PERSON_ROLLUP_3 || rule.PERSON_ROLLUP_3 == -1)
                   )
                {
                    return rule.ACTION == 0 ? "remove_access" : "add_access";
                }
            }
            int count = 0;
            for (int i = 0; i < Static.query_history_index.Count; i++)
            {

                Query_history query_History = (Query_history)Static.query_history_index[i];

                if (query_History.TARGET_NAME == TARGET_NAME)
                {
                    count++;
                }
            }
            if (count == 0) return "no_resource";
            return "hang";//没有搜到 挂起
        }

        public string search(int resNAME, int acTYPE, int userTYPE)
        {
            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                Rule rule = (Rule)Static.rule_index[i];
                if(resNAME == rule.PERSON_BUSINESS_TITLE/*资源名称*/&&acTYPE == rule.PERSON_JOB_CODE/*操作类型*/&&userTYPE == rule.PERSON_MGR_ID/*用户类型*/)
                {
                    return rule.ACTION == 0 ? "remove_access" : "add_access";
                }
            }
            return "NO"; //被挂起
        }

        public void add_rules(int userTYPE, int resNAME, int acTYPE, string result)
        {
            
        }
    }
}
