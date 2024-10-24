using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.DataAccess.Abstract;
using WebSite.Entities;

namespace WebSite.DataAccess.Concreate
{
    public class WebSiteRepository : IWebSiteRepository
    {
        public MyInfo CreateMyInfo(MyInfo myinfo)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                webSiteDbContext.MyInfos.Add(myinfo);
                webSiteDbContext.SaveChanges();
                return myinfo;
            }
        }

        public void DeleteMyInfo(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                var deletedMyInfo = GetMyInfoById(id);
                webSiteDbContext.MyInfos.Remove(deletedMyInfo);
                webSiteDbContext.SaveChanges();
            }
        }

        public List<MyInfo> GetAllMyInfos()
        {
            using (var webSiteDbContext =new WebSiteDbContext())
            {
                return webSiteDbContext.MyInfos.ToList();
            }
        }

        public MyInfo GetMyInfoById(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MyInfos.Find(id);
            }
        }

        public MyInfo UpdateMyInfo(MyInfo myinfo)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                webSiteDbContext.MyInfos.Update(myinfo);
                webSiteDbContext.SaveChanges();
                return myinfo;
            }
        }
    }
}
