using Inventory.Repository.Paging;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductTypeService
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private readonly ApplicationDbContext _context;

        public ProductTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<ProductTypeListViewModel>> GetAll(int index, int size)
        {
            var customerTypeList = _context.ProductTypes;
            var vm = customerTypeList.ModelToVM().AsQueryable();

            return await PaginatedList<ProductTypeListViewModel>.CreateAsync(vm, index, size);
        }
    }
}
