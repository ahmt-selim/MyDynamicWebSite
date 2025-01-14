using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebSite.Web.Model;
using static System.Net.WebRequestMethods;

namespace WebSite.Web.Controllers
{
    
    public class HomeController : Controller
    {
        string domain = "https://localhost:44348/";//TEST
        //string domain = "https://ahmetselimkisa.com.tr/";
        public IActionResult Index()
        {
            int user_id = 1;
            JObject result = new JObject();
            JArray myinfoskills = new JArray();
            JArray skills = new JArray();
            var viewModel = new IndexPageViewModel();
            var myinfo = new myinfo();
            myinfo.name = "Ahmet Selim";
            myinfo.surname = "Kısa";
            myinfo.birthDay = DateTime.Today;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = domain + "api/myinfo/" + user_id;

                    HttpResponseMessage response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    result = JObject.Parse(responseBody);

                    url = domain + "api/myinfoskills/" + user_id;

                    HttpResponseMessage response2 = client.GetAsync(url).Result;
                    response2.EnsureSuccessStatusCode();
                    responseBody = response2.Content.ReadAsStringAsync().Result;
                    myinfoskills = JArray.Parse(responseBody);

                    url = domain + "api/myskill";

                    HttpResponseMessage response3 = client.GetAsync(url).Result;
                    response3.EnsureSuccessStatusCode();
                    responseBody = response3.Content.ReadAsStringAsync().Result;
                    skills = JArray.Parse(responseBody);

                }
                catch (AggregateException e)
                {
                    // Hata durumunda mesajı yazdırıyoruz.
                    Console.WriteLine($"Request error: {e.InnerException?.Message}");
                }
            }
            myinfo.name = result["name"].ToString();
            myinfo.surname = result["surname"].ToString();
            myinfo.city = result["city"].ToString();
            myinfo.id = int.Parse(result["id"].ToString());
            myinfo.birthDay = DateTime.Parse(result["birthDay"].ToString());
            myinfo.about = result["about"].ToString();
            myinfo.email = result["email"].ToString();
            myinfo.telephone = result["telephone"].ToString();

            List<string> skill_names= new List<string>();
            foreach (var item in myinfoskills)
            {
                var skill = skills.Where(x => x["id"].ToString() == item["skillId"].ToString()).FirstOrDefault();
                if (skill != null)
                {
                    skill_names.Add(skill["picture_name"].ToString() + ".png");
                }
            }
            viewModel.skills = skill_names;
            viewModel.myInfo = myinfo;
            return View(viewModel);
        }
    }
}
