﻿using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private readonly ApplicationDbContext _context;

        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<BillTypeListViewModel>> GetAll(int index, int size)
        {
            var customerTypeList = _context.BillTypes;
            var vm = customerTypeList.ModelToVM().AsQueryable();

            return await PaginatedList<BillTypeListViewModel>.CreateAsync(vm, index, size);
        }
    }
}
