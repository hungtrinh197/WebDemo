﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDemo.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        public int GroupID { set; get; }
        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }

    }
}
