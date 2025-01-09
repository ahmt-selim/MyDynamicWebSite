using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Entities;

namespace WebSite.DataAccess.Data
{
    public static class DataSeeding
    {//Development aşamasında uygulama başlatıldığında test verileri oluşturmak için kullanıyoruz.
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<WebSiteDbContext>();

            context.Database.Migrate();//Uygulama ilk çalıştığında veritabanını kontrol ederek yok ise oluşturma işlemi

            var skills = new List<MySkill>()
                    {
                        new MySkill {name="C#"},
                        new MySkill {name="Javascript"},
                        new MySkill {name="Sql"},
                        new MySkill {name="Python"},
                        new MySkill {name="C++"},
                        new MySkill {name="Html"},
                        new MySkill {name="Css"}
                    };
            

            if (context.Database.GetPendingMigrations().Count() == 0)//Bütün migrationlar uygulanmışsa yani bekleyen bir migration yoksa 
            {
                if (context.MySkills.Count() == 0)//Daha önceden ilgili movies tablosuna veri eklenmişse yeni test verilerini eklemiyor.
                {
                    context.MySkills.AddRange(skills);
                }
                context.SaveChanges();
            }
        }
    }
}
