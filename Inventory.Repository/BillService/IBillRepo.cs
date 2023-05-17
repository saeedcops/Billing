﻿using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillService
{
    public interface IBillRepo
    {
        Task<PaginatedList<BillListViewModel>> GetAll(int index, int size);
    }
}
