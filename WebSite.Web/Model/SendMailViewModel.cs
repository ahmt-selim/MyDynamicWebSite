using Newtonsoft.Json.Linq;

namespace WebSite.Web.Model
{
    public class SendMailViewModel
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string indexPageViewModelJson { get; set; }
    }
}
