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
                        new MySkill {name="C#",picture_name="csharp"},
                        new MySkill {name="Javascript", picture_name="js"},
                        new MySkill {name="Sql Lite",picture_name="sqllite"},
                        new MySkill {name="Python",picture_name="python"},
                        new MySkill {name="C++",picture_name="cpp"},
                        new MySkill {name="Html",picture_name="html"},
                        new MySkill {name="Css",picture_name="css"},
                        new MySkill {name=".Net",picture_name="dotnet"}
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
