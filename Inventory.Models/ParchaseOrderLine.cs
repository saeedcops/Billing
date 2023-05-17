using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ParchaseOrderLine
    {
        public int Id { get; set; }
        public int ParchaseOrderId { get; set; }
        public ParchaseOrder ParchaseOrder { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double SubTotal { get; set; }
        public double TaxAmount { get; set; }
        public double TaxPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public double Total { get; set; }
    }
}
