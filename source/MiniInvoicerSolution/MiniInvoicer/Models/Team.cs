﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInvoicer.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [ForeignKey("DepartmentID")]
        public int DepartmentID { get; set; }

        [ForeignKey("EmployeeID")]
        public int LeaderID { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}