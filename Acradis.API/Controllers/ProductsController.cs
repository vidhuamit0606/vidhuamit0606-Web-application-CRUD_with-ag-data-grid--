using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acradis.API.Services;
using Acradis.API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Acradis.API.Filters;

namespace Acradis.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductsRepository _productsRepository;
        public ProductsController(IProductsRepository productsRepository,
            IMapper mapper)
        {
            _productsRepository = productsRepository ??
                throw new ArgumentNullException(nameof(productsRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpPost]
        [ProductResultFilter]
        public async Task<IActionResult> CreateBook(ProductForCreation bookForCreation)
        {
            var productEntity = _mapper.Map<Entities.Product>(bookForCreation);
            _productsRepository.AddProduct(productEntity);

            await _productsRepository.SaveChangesAsync();

            // Fetch (refetch) the  from the data store
            await _productsRepository.GetProductAsync(productEntity.Id);


            return CreatedAtRoute(
                "GetProduct",
                new { id = productEntity.Id },
                 productEntity);
        }

        [HttpGet]
        [ProductsResultFilter]
        public IActionResult GetProducts()
        {
            var productEntities =  _productsRepository.GetProducts();
            return Ok(productEntities);
        }

        [HttpGet]
        [Route("{id}" ,Name= "GetProduct")]
        public async Task<IActionResult> GetProductAsync(Guid id)
        {
            var productEntity = await _productsRepository.GetProductAsync(id);
            if (productEntity == null)
            {
                return NotFound();
            }

            return Ok(productEntity);
        }

        [HttpDelete]
        [ProductResultFilter]
        [Route("{id}", Name = "DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var productEntity = await _productsRepository.GetProductAsync(id);
            if (productEntity == null)
            {
                return NotFound();
            }
            _productsRepository.DeleteProductAsync(productEntity);
            await _productsRepository.SaveChangesAsync();

            return Ok();
        }


    }
}