﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
