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
        private IMySkillRepository _mySkillRepository;
        public MyInfoSkillsManager()
        {
            _mySkillRepository = new MySkillRepository();
        }
        public List<MySkill> CreateMySkill(List<MySkill> myskills)
        {
            return _mySkillRepository.CreateMySkill(myskills);
        }

        public void DeleteMySkill(int id)
        {
            _mySkillRepository.DeleteMySkill(id);
        }

        public List<MySkill> GetAllMySkills()
        {
            return _mySkillRepository.GetAllMySkills();
        }

        public MySkill GetMySkillById(int id)
        {
            if (id > 0)
            {
                return _mySkillRepository.GetMySkillById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public MySkill UpdateMySkill(MySkill myskill)
        {
            return _mySkillRepository.UpdateMySkill(myskill);
        }
    }
}
