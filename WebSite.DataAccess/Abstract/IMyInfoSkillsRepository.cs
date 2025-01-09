using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess.Abstract
{
    public interface IMyInfoSkillsRepository
    {
        List<MySkill> GetAllMySkills();
        MySkill GetMySkillById(int id);
        List<MySkill> CreateMySkill(List<MySkill> mySkills);
        MySkill UpdateMySkill(MySkill mySkill);
        void DeleteMySkill(int id);
    }
}
