﻿
using System.ComponentModel.DataAnnotations;


namespace Inventory.ViewModel.Customer
{
    public class CustomerTypeListViewModel
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerTypeName { get; set; }
        public string Description { get; set; }
    }
}
