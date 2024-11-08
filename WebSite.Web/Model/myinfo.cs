using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Web.Model
{
    public class myinfo
    {
        public int id { get; set; }
        [StringLength(225)]
        public string name { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string city { get; set; }
        public DateTime birthDay { get; set; }
    }
}
