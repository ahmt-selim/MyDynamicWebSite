using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Business.Abstract;
using WebSite.DataAccess.Abstract;
using WebSite.DataAccess.Concreate;
using WebSite.Entities;

namespace WebSite.Business.Concreate
{
    public class MyInfoSkillsManager : IMyInfoSkillsService
    {
        private IMyInfoSkillsRepository _myInfoSkillsRepository;
        public MyInfoSkillsManager()
        {
            _myInfoSkillsRepository = new MyInfoSkillsRepository();
        }
        public List<MyInfoSkills> CreateMyInfoSkills(List<MyInfoSkills> myInfoSkills)
        {
            return _myInfoSkillsRepository.CreateMyInfoSkills(myInfoSkills);
        }

        public void DeleteMyInfoSkills(int id)
        {
            _myInfoSkillsRepository.DeleteMyInfoSkills(id);
        }

        public List<MyInfoSkills> GetAllMyInfoSkills()
        {
            return _myInfoSkillsRepository.GetAllMyInfoSkills();
        }

        public List<MyInfoSkills> GetMyInfoSkillsById(int id)
        {
            if (id > 0)
            {
                return _myInfoSkillsRepository.GetMyInfoSkillsById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public MyInfoSkills UpdateMyInfoSkills(MyInfoSkills myInfoSkills)
        {
            return _myInfoSkillsRepository.UpdateMyInfoSkills(myInfoSkills);
        }
    }
}
