using Inventory.Repository.Paging;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerService
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<CustomerListViewModel>> GetAll(int index, int size)
        {
            var customerTypeList = _context.Customers;
            var vm = customerTypeList.ModelToVM().AsQueryable();

            return await PaginatedList<CustomerListViewModel>.CreateAsync(vm, index, size);
        }
    }
}
