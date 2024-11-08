using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebSite.Web.Model;

namespace WebSite.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            JObject result = new JObject();
            var myinfo = new myinfo();
            myinfo.name = "Ahmet Selim";
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        string url = "https://ahmetselimkisa.com.tr/api/website/1";

            //        HttpResponseMessage response = client.GetAsync(url).Result;
            //        response.EnsureSuccessStatusCode();
            //        string responseBody = response.Content.ReadAsStringAsync().Result;
            //        result = JObject.Parse(responseBody);
            //    }
            //    catch (AggregateException e)
            //    {
            //        // Hata durumunda mesajı yazdırıyoruz.
            //        Console.WriteLine($"Request error: {e.InnerException?.Message}");
            //    }
            //}
            //myinfo.name = result["name"].ToString();
            //myinfo.surname = result["surname"].ToString();
            //myinfo.city = result["city"].ToString();
            //myinfo.id = int.Parse(result["id"].ToString());
            //myinfo.birthDay = DateTime.Parse(result["birthDay"].ToString());
            return View(myinfo);
        }
    }
}
