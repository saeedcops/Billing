using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class PaymentRecieve
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Name { get; set; }
        public double PaymentAmount { get; set; }
        public bool IsFullPayment { get; set; } = true;
        public DateTimeOffset DateOfPayment { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
