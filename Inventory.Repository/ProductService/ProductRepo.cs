using Inventory.Repository.Paging;
using Inventory.ViewModel.Mapping;
using Inventory.ViewModel.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductService
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<ProductListViewModel>> GetAll(int index, int size)
        {
            var customerTypeList = _context.Products;
            var vm = customerTypeList.ModelToVM().AsQueryable();

            return await PaginatedList<ProductListViewModel>.CreateAsync(vm, index, size);
        }
    }
}
