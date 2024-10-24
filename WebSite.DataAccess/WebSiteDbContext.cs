using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess
{
    public class WebSiteDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MSSQLSERVER2019; Database=MyInfoDb; uid=ahmetselimdb; pwd=Tgmg37?48;");
        }

        public DbSet<MyInfo> MyInfos { get; set; }
        public DbSet<MyCompetence> MyCompetences { get; set; }
        public DbSet<MyEducationInfo> MyEducationInfos { get; set; }
        public DbSet<MyHobi> MyHobies { get; set; }

    }
}
