using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingCharge { get; set; }
        public decimal Total { get; set; }
        public decimal GrandTotal { get; set; }
        public string PromoCode { get; set; }
        public string Description { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus Status { get; set; }
    }
}

namespace Inventory.Models
{
    public enum OrderType
    {
        PurchaseOrder,CustomerOrder
    }
}

namespace Inventory.Models
{
    public enum OrderStatus
    {
        CheckOut,Failed,Paid,Shipped,Delivered,Returned,Complete
    }
}