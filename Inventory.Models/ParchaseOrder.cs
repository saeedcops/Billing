using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ParchaseOrder
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int VendorId { get; set; }
        public int CurrencyId { get; set; }
        public DateTimeOffset DateOfOrder { get; set; }
        public DateTimeOffset DateOfDelivery { get; set; }
        public int ParchaseTypeId { get; set; }
        public string Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public ICollection<ParchaseOrderLine> ParchaseOrderLines { get; set; } = new HashSet<ParchaseOrderLine>();
    }
}
