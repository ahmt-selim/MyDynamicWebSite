using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebSite.Web.Model;
using static System.Net.WebRequestMethods;

namespace WebSite.Web.Controllers
{

    public class HomeController : Controller
    {
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }
        string domain = "https://localhost:44348/";//TEST
        //string domain = "https://ahmetselimkisa.com.tr/";
        IndexPageViewModel dd = new IndexPageViewModel();
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

                    myinfo.name = result["name"].ToString();
                    myinfo.surname = result["surname"].ToString();
                    myinfo.city = result["city"].ToString();
                    myinfo.id = int.Parse(result["id"].ToString());
                    myinfo.birthDay = DateTime.Parse(result["birthDay"].ToString());
                    myinfo.about = result["about"].ToString();
                    myinfo.email = result["email"].ToString();
                    myinfo.telephone = result["telephone"].ToString();
                }
                catch (Exception e)
                {
                    // Hata durumunda mesajı yazdırıyoruz.
                    Console.WriteLine($"Request error: {e.InnerException?.Message}");
                }
            }

            List<string> skill_names = new List<string>();
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
            dd = viewModel;
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SendMail(SendMailViewModel mail)
        {
            try
            {
                //var model = JsonConvert.DeserializeObject<IndexPageViewModel>(mail.indexPageViewModelJson.ToString());
                string name = mail.Name;
                string email_address = mail.Email;
                string message = mail.Message;

                string smtpServer = "ahmetselimkisa.com.tr";
                string fromAddress = "developer@ahmetselimkisa.com.tr"; // Gönderen e-posta adresi
                string password = "*****";
                string toAddress = "scaramouchee.12@gmail.com"; // Alıcı e-posta adresi
                string subject = mail.Subject + "-" + name;
                string body = $"Name: {name}\nEmail: {email_address}\nMessage: {message}";
                
                MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);
                mailMessage.From = new MailAddress(fromAddress);
                mailMessage.To.Add(toAddress);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;


                SmtpClient smtp = new SmtpClient(smtpServer, 587);
                smtp.Credentials = new NetworkCredential(fromAddress, password);
                smtp.EnableSsl = true; // STARTTLS kullanır
                smtp.Send(mailMessage);

                // Başarılı mesajı döndürme
                ViewBag.Message = "Mail sent successfully!";
                return RedirectToAction("Index", dd);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("SMTP Hatası: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.StatusCode);
                return View(mail);
            }
            catch (Exception ex)
            {
                return View(mail);
                throw;
            }
            
        }
        
        private readonly IWebHostEnvironment _env;
        public ActionResult DownloadPdf()
        {
            string filePath = Path.Combine(_env.ContentRootPath, "wwwroot", "files", "Ahmet Selim Kısa.pdf");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("PDF dosyası bulunamadı.");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            Response.Headers.Add("Content-Disposition", "inline; filename=Ahmet Selim Kısa.pdf");
            return File(fileBytes, "application/pdf");
        }
    }
}
