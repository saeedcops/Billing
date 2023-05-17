using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Product
{
    public class ProductListViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductImage { get; set; }
        public string BarCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal BuyingPrice { get; set; }
        public decimal sellingPrice { get; set; }
        public int MeasureUnitId { get; set; }
        public int BranchId { get; set; }
        public int CurrancyId { get; set; }
    }
}
