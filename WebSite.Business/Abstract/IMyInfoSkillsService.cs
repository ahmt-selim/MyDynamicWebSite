using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.Business.Abstract
{
    public interface IMyInfoSkillsService
    {
        List<MySkill> GetAllMySkills();
        MySkill GetMySkillById(int id);
        List<MySkill> CreateMySkill(List<MySkill> mySkills);
        MySkill UpdateMySkill(MySkill mySkill);
        void DeleteMySkill(int id);
    }
}
