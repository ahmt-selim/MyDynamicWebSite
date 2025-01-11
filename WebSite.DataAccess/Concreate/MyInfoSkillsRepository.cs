using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebSite.DataAccess.Abstract;
using WebSite.Entities;

namespace WebSite.DataAccess.Concreate
{
    public class MyInfoSkillsRepository : IMyInfoSkillsRepository
    {
        public List<MyInfoSkills> CreateMyInfoSkills(List<MyInfoSkills> myInfoSkills)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                foreach (var item in myInfoSkills)
                {
                    webSiteDbContext.MyInfoSkills.Add(item);
                }
                webSiteDbContext.SaveChanges();
                return myInfoSkills;
            }
        }

        public void DeleteMyInfoSkills(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                MyInfoSkills deletedMyInfoSkills = GetMyInfoSkillById(id);
                webSiteDbContext.MyInfoSkills.Remove(deletedMyInfoSkills);
                webSiteDbContext.SaveChanges();
            }
        }
        private MyInfoSkills GetMyInfoSkillById(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MyInfoSkills.Find(id);
            }
        }
        public List<MyInfoSkills> GetAllMyInfoSkills()
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MyInfoSkills.ToList();
            }
        }

        public List<MyInfoSkills> GetMyInfoSkillsById(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MyInfoSkills.Where(x=>x.MyInfoId == id).ToList();
            }
        }

        public MyInfoSkills UpdateMyInfoSkills(MyInfoSkills myInfoSkills)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                webSiteDbContext.MyInfoSkills.Update(myInfoSkills);
                webSiteDbContext.SaveChanges();
                return myInfoSkills;
            }
        }
    }
}
