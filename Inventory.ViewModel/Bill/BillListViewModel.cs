using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bill
{
    public class BillListViewModel
    {
        public int BillId { get; set; }
        public int GoodsRecievedId { get; set; }
        public string BillName { get; set; }
        public string VendorDoNum { get; set; }
        public string VendorInvoiceNum { get; set; }
        public DateTimeOffset BillDate { get; set; }
        public DateTimeOffset BillDueDate { get; set; }
        public int BillTypeId { get; set; }
    }
}
