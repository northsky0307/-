using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Project
{
    class User_operation //使用者信息数据库
    {
       
        

        public bool Query(string name) ///正常返回密码， 异常返回-1
        {
            for(int i = 0; i < Static.user_index.Count; i ++)
            {
                User user = (User)Static.user_index[i];
                if(user.LOGIN == name)
                {
                    Static.PERSON_BUSINESS_TITLE = user.PERSON_BUSINESS_TITLE;
                    Static.PERSON_BUSINESS_TITLE_DETAIL = user.PERSON_BUSINESS_TITLE_DETAIL;
                    Static.PERSON_COMPANY = user.PERSON_COMPANY;
                    Static.PERSON_DEPTNAME = user.PERSON_DEPTNAME;
                    Static.PERSON_JOB_CODE = user.PERSON_JOB_CODE;
                    Static.PERSON_JOB_FAMILY = user.PERSON_JOB_FAMILY;
                    Static.PERSON_LOCATION = user.PERSON_LOCATION;
                    Static.PERSON_MGR_ID = user.PERSON_MGR_ID;
                    Static.PERSON_ROLLUP_1 = user.PERSON_ROLLUP_1;
                    Static.PERSON_ROLLUP_2 = user.PERSON_ROLLUP_2;
                    Static.PERSON_ROLLUP_3 = user.PERSON_ROLLUP_3;
                    return true;
                }
            }
            return false;
        }
    }
}
