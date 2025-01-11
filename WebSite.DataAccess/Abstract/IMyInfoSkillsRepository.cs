using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess.Abstract
{
    public interface IMyInfoSkillsRepository
    {
        List<MyInfoSkills> GetAllMyInfoSkills();
        List<MyInfoSkills> GetMyInfoSkillsById(int id);
        List<MyInfoSkills> CreateMyInfoSkills(List<MyInfoSkills> myInfoSkills);
        MyInfoSkills UpdateMyInfoSkills(MyInfoSkills myInfoSkills);
        void DeleteMyInfoSkills(int id);
    }
}
