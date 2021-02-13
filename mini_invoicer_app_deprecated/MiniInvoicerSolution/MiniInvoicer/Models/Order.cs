﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInvoicer.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        
        [ForeignKey("UserID")]
        public int SalesRepresentativeID { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("CompanyID")]
        public int VendorID { get; set; }
        public Company Vendor { get; set; }

        [ForeignKey("CompanyID")]
        public int CustomerID { get; set; }
        public Company Buyer { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Value { get; set; }
        public DateTime DateCreated { get; set; }
    }
}