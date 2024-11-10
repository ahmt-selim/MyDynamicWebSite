using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.Business.Abstract
{
    public interface IMyInfoService
    {
        List<MyInfo> GetAllMyInfos();
        MyInfo GetMyInfoById(int id);
        MyInfo CreateMyInfo(MyInfo myinfo);
        MyInfo UpdateMyInfo(MyInfo myinfo);
        void DeleteMyInfo(int id);
    }
}
