/*******************************************************************************************
 *Copyright (c) 2020  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:MultiHeaderOfDataGridWpfApp.Model
 *文件名:UserInformation
 *版本号:V1.0.0.0
 *唯一标识:435c34a8-7250-4f76-a014-d64d0c2baee4
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2020/6/27 9:54:39

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2020/6/27 9:54:39
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiHeaderOfDataGridWpfApp.Model
{
    public class UserInformation
    {
        public string UserName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int Age { get; set; }
        public string Motto { get; set; }

    }
}
