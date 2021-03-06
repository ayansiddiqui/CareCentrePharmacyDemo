﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace caredemo.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        [Required]
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
