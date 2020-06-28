/*******************************************************************************************
 *Copyright (c) 2020  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:MultiHeaderOfDataGridWpfApp.ViewModel
 *文件名:MainViewModel
 *版本号:V1.0.0.0
 *唯一标识:b34be98d-4ccb-407e-8b14-27835079fb9b
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2020/6/27 9:36:54

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2020/6/27 9:36:54
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GalaSoft.MvvmLight;
using MultiHeaderOfDataGridWpfApp.Model;

namespace MultiHeaderOfDataGridWpfApp.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        private ObservableCollection<UserInformation> _userInformations;

        public ObservableCollection<UserInformation> UserInformations
        {
            get { return _userInformations; }
            set { Set(ref _userInformations, value); }
        }
        public MainViewModel()
        {
            Title = Guid.NewGuid().ToString();
            UserInformations = new ObservableCollection<UserInformation>(new List<UserInformation>()
            {
                new UserInformation()
                {
                    UserName = "Bob",Age = 32,Province = "山东",City = "济南",County = "天桥",Motto = "会当云绝顶，\r\n一览众山小。"
                },
                new UserInformation()
                {
                    UserName = "Bob",Age = 32,Province = "山东",City = "济南",County = "天桥",Motto = "会当云绝顶，\r\n一览众山小。"
                },
                new UserInformation()
                {
                    UserName = "Bob",Age = 32,Province = "山东",City = "济南",County = "天桥",Motto = "会当云绝顶，\r\n一览众山小。"
                }
            });
        }
    }
}
