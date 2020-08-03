using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Acradis.API.Contexts;
using Acradis.API.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Acradis.API.Services
{
    public class ProductsRepository : IProductsRepository, IDisposable
    {
        private ProductsContext _context;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ProductsRepository> _logger;
       // private CancellationTokenSource _cancellationTokenSource;


        public ProductsRepository(ProductsContext context,
            IHttpClientFactory httpClientFactory,
            ILogger<ProductsRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _httpClientFactory = httpClientFactory ??
                throw new ArgumentNullException(nameof(httpClientFactory));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
            //throw new NotImplementedException();
        }

        public void AddProduct(Product productToAdd)
        {
            if(productToAdd == null)
            {
                throw new ArgumentNullException(nameof(productToAdd));
            }

            _context.Add(productToAdd);
            
        }



        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            
            throw new NotImplementedException();
        }

        public Product GetProduct(Guid id)
        {
            return  _context.Products
                     .FirstOrDefault(p => p.Id == id);
            

        }
        public async Task<Product> GetProductAsync(Guid id)
        {
            return await _context.Products
                  
                     .FirstOrDefaultAsync(p => p.Id == id);
           

        }

        public void DeleteProductAsync(Product item)
        {
             _context.Products.Remove(item);
           
           }

        public Task<IEnumerable<Entities.Product>> GetProductsAsync(IEnumerable<Guid> productIds)
        {
           // return _context.Products.Where(p => productIds.Contains(p.Id)).ToList() ;
            throw new NotImplementedException();
        }


        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
           
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_context != null)
                    {
                        _context.Dispose();
                        _context = null;
                    }

                }
                
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ProductsRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        




        #endregion
    }
}
