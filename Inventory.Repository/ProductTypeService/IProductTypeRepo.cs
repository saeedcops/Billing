using Inventory.Repository.Paging;
using Inventory.ViewModel.Product;


namespace Inventory.Repository.ProductTypeService
{
    public interface IProductTypeRepo
    {
        Task<PaginatedList<ProductTypeListViewModel>> GetAll(int index, int size);
    }
}
