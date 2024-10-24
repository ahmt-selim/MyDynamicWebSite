using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Business.Abstract;
using WebSite.DataAccess.Abstract;
using WebSite.DataAccess.Concreate;
using WebSite.Entities;

namespace WebSite.Business.Concreate
{
    public class WebSiteManager : IWebSiteService
    {
        private IWebSiteRepository _webSiteRepository;
        public WebSiteManager()
        {
            _webSiteRepository = new WebSiteRepository();
        }
        public MyInfo CreateMyInfo(MyInfo myinfo)
        {
            return _webSiteRepository.CreateMyInfo(myinfo);
        }

        public void DeleteMyInfo(int id)
        {
            _webSiteRepository.DeleteMyInfo(id);
        }

        public List<MyInfo> GetAllMyInfos()
        {
            return _webSiteRepository.GetAllMyInfos();
        }

        public MyInfo GetMyInfoById(int id)
        {
            if (id > 0)
            {
                return _webSiteRepository.GetMyInfoById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public MyInfo UpdateMyInfo(MyInfo myinfo)
        {
            return _webSiteRepository.UpdateMyInfo(myinfo);
        }
    }
}
