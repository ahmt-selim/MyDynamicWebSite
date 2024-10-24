using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebSite.Entities
{
    public class MyInfo
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(225)]
        public string name { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthDay { get; set; }
    }
}
