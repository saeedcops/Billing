using Inventory.Models;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Product;
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
                yield return new CustomerTypeListViewModel
                {
                    CustomerTypeId = model.CustomerTypeId,
                    CustomerTypeName = model.CustomerTypeName,
                    Description = model.Description,
                };
            }
        }

        public static IEnumerable<CustomerListViewModel> ModelToVM(this IEnumerable<Inventory.Models.Customer> models)
        {
            foreach (var model in models)
            {
                yield return new CustomerListViewModel
                {
                    CustomerTypeId = model.CustomerTypeId,
                    Description = model.Description,
                    CustomerName = model.CustomerName,
                    Address = model.Address,
                    City = model.City,
                    ContactPerson = model.ContactPerson,
                    CustomerId = model.CustomerId,
                    Email = model.Email,
                    Phone = model.Phone,
                    State = model.State,
                    ZipCode = model.ZipCode
                
                };
            }
        }

        public static IEnumerable<BillListViewModel> ModelToVM(this IEnumerable<Inventory.Models.Bill> models)
        {
            foreach (var model in models)
            {
                yield return new BillListViewModel
                {
                   BillDate = model.BillDate,
                   BillDueDate = model.BillDueDate,
                   BillId = model.BillId,
                   BillName = model.BillName,
                   BillTypeId = model.BillTypeId,
                   GoodsRecievedId = model.GoodsRecievedId,
                   VendorDoNum = model.VendorDoNum,
                   VendorInvoiceNum = model.VendorInvoiceNum

                };
            }
        }

        public static IEnumerable<BillTypeListViewModel> ModelToVM(this IEnumerable<Inventory.Models.BillType> models)
        {
            foreach (var model in models)
            {
                yield return new BillTypeListViewModel
                {
                   BillTypeId = model.BillTypeId,
                   BillTypeName = model.BillTypeName,
                   Description  = model.Description

                };
            }
        }


        public static IEnumerable<ProductListViewModel> ModelToVM(this IEnumerable<Inventory.Models.Product> models)
        {
            foreach (var model in models)
            {
                yield return new ProductListViewModel
                {
                    Description = model.Description,
                    ProductId = model.ProductId,
                    BarCode = model.BarCode,
                    BranchId = model.BranchId,
                    BuyingPrice = model.BuyingPrice,
                    CreatedAt = model.CreatedAt,
                    CurrancyId = model.CurrancyId,
                    MeasureUnitId = model.MeasureUnitId,
                    ProductCode = model.ProductCode,
                    ProductImage = model.ProductImage,
                    ProductName = model.ProductName,
                    sellingPrice = model.sellingPrice,
                    UpdatedAt = model.UpdatedAt

                };
            }
        }

        public static IEnumerable<ProductTypeListViewModel> ModelToVM(this IEnumerable<Inventory.Models.ProductType> models)
        {
            foreach (var model in models)
            {
                yield return new ProductTypeListViewModel
                {
                    Description=model.Description,
                    ProductTypeId=model.ProductTypeId,
                    ProductTypeName=model.ProductTypeName,

                };
            }
        }
    }
}
