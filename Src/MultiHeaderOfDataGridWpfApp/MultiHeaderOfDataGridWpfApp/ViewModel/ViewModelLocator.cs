/*******************************************************************************************
 *Copyright (c) 2020  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:MultiHeaderOfDataGridWpfApp.ViewModel
 *文件名:ViewModelLocator
 *版本号:V1.0.0.0
 *唯一标识:c3af9d70-08bf-4881-ade3-880acb59f4ea
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2020/6/27 9:35:26

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2020/6/27 9:35:26
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Ioc;

namespace MultiHeaderOfDataGridWpfApp.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>(true);
        }

        public MainViewModel MainViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }
    }
}
