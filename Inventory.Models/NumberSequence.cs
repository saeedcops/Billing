﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class NumberSequence
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Module { get; set; }

        public string Prefix { get; set; }
        public int LastNumber { get; set; }
    }
}
