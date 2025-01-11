using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.Business.Abstract
{
    public interface IMyInfoSkillsService
    {
        List<MyInfoSkills> GetAllMyInfoSkills();
        List<MyInfoSkills> GetMyInfoSkillsById(int id);
        List<MyInfoSkills> CreateMyInfoSkills(List<MyInfoSkills> myInfoSkills);
        MyInfoSkills UpdateMyInfoSkills(MyInfoSkills myInfoSkills);
        void DeleteMyInfoSkills(int id);
    }
}
