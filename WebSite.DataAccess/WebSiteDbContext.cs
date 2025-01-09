using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess
{
    public class WebSiteDbContext:DbContext
    {
        public WebSiteDbContext(DbContextOptions<WebSiteDbContext> options) : base(options)
        {

        }

        public WebSiteDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER2019; Database=MyInfoDb; uid=ahmetselimdb; pwd=paJGtUtr11irk5*?;");
            optionsBuilder.UseSqlServer("Server=MENGUALP; Database=MyInfoDb; Trusted_Connection=True;");
        }

        public DbSet<MyInfo> MyInfos { get; set; }
        public DbSet<MySkill> MySkills { get; set; }
        public DbSet<MyEducationInfo> MyEducationInfos { get; set; }
        public DbSet<MyHobi> MyHobies { get; set; }
        public DbSet<MyInfoSkills> MyInfoSkills { get; set; }

    }
}
