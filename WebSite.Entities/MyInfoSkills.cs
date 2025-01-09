using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebSite.Entities
{
    public class MyInfoSkills
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int MyInfoId { get; set; }
        public int SkillId { get; set; }
    }
}
