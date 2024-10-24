using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess.Abstract
{
    public interface IWebSiteRepository
    {
        List<MyInfo> GetAllMyInfos();
        MyInfo GetMyInfoById(int id);
        MyInfo CreateMyInfo(MyInfo myinfo);
        MyInfo UpdateMyInfo(MyInfo myinfo);
        void DeleteMyInfo(int id);
    }
}
