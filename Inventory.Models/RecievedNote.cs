using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class RecievedNote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VendorNumber { get; set; }
        public string VendorInvoiceNumber { get; set; }
        public int ParchaseOrderId { get; set; }
        public int WarehouseId { get; set; }
        public bool IsFullRecieved { get; set; }

        public DateTimeOffset  GRNDate { get; set; }
    }
}
