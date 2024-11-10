using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.DataAccess.Abstract;
using WebSite.Entities;

namespace WebSite.DataAccess.Concreate
{
    public class MySkillRepository : IMySkillRepository
    {
        public List<MySkill> CreateMySkill(List<MySkill> myskills)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                foreach (var item in myskills)
                {
                    webSiteDbContext.MySkills.Add(item);
                }
                webSiteDbContext.SaveChanges();
                return myskills;
            }
        }

        public void DeleteMySkill(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                var deletedMySkill = GetMySkillById(id);
                webSiteDbContext.MySkills.Remove(deletedMySkill);
                webSiteDbContext.SaveChanges();
            }
        }

        public List<MySkill> GetAllMySkills()
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MySkills.ToList();
            }
        }

        public MySkill GetMySkillById(int id)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                return webSiteDbContext.MySkills.Find(id);
            }
        }

        public MySkill UpdateMySkill(MySkill myskill)
        {
            using (var webSiteDbContext = new WebSiteDbContext())
            {
                webSiteDbContext.MySkills.Update(myskill);
                webSiteDbContext.SaveChanges();
                return myskill;
            }
        }
    }
}
