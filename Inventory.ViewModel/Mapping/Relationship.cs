using Inventory.Models;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Mapping
{
    public static class Relationship
    {
        public static IEnumerable<CustomerTypeListViewModel> ModelToVM(this IEnumerable<CustomerType> models)
        {
            foreach (var model in models)
            {
                yield return model;
            }
        }
    }
}
