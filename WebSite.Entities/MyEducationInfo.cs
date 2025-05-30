﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebSite.Entities
{
    public class MyEducationInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(225)]
        public string schoolName { get; set; }

        [StringLength(50)]
        public string schoolcity { get; set; }
        public int MyInfoId { get; set; }
    }
}
