using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Business.Abstract;
using WebSite.DataAccess.Abstract;
using WebSite.DataAccess.Concreate;
using WebSite.Entities;

namespace WebSite.Business.Concreate
{
    public class MyInfoManager : IMyInfoService
    {
        private IMyInfoRepository _myInfoRepository;
        public MyInfoManager()
        {
            _myInfoRepository = new MyInfoRepository();
        }
        public MyInfo CreateMyInfo(MyInfo myinfo)
        {
            return _myInfoRepository.CreateMyInfo(myinfo);
        }

        public void DeleteMyInfo(int id)
        {
            _myInfoRepository.DeleteMyInfo(id);
        }

        public List<MyInfo> GetAllMyInfos()
        {
            return _myInfoRepository.GetAllMyInfos();
        }

        public MyInfo GetMyInfoById(int id)
        {
            if (id > 0)
            {
                return _myInfoRepository.GetMyInfoById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public MyInfo UpdateMyInfo(MyInfo myinfo)
        {
            return _myInfoRepository.UpdateMyInfo(myinfo);
        }
    }
}
