using System.Collections.Generic;

namespace WebSite.Web.Model
{
    public class IndexPageViewModel
    {
        public myinfo myInfo { get; set; }
        public List<string> skills { get; set; }
        public SendMailViewModel sendMail { get; set; }
    }
}
