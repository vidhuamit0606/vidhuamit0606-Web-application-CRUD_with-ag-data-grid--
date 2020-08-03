using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acradis.API.Services
{
    public interface IProductsRepository
    {
        IEnumerable<Entities.Product> GetProducts();
        Task<IEnumerable<Entities.Product>> GetProductsAsync();

        Task<Entities.Product> GetProductAsync(Guid id);
        Task<IEnumerable<Entities.Product>> GetProductsAsync(IEnumerable<Guid> bookIds);
        void AddProduct(Entities.Product productToAdd);

        Entities.Product GetProduct(Guid id);

        void DeleteProductAsync(Entities.Product item);

        Task<bool> SaveChangesAsync();


    }
}
