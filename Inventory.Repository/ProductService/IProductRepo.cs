using Inventory.Repository.Paging;
using Inventory.ViewModel.Product;


namespace Inventory.Repository.ProductService
{
    public interface IProductRepo
    {
        Task<PaginatedList<ProductListViewModel>> GetAll(int index, int size);
    }
}
