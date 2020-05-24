using Sync.WebApi.Entities;
using Sync.WebApi.Models;
using Sync.WebApi.Repository;

namespace Sync.WebApi.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        
        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductEntity Create(ProductModel productModel)
        {
            ProductEntity entity = new ProductEntity
            {
                ProductId = productModel.Id,
                Name = productModel.Name,
                Price = productModel.Price,
                Stock = productModel.Stock
            };

            return  _productRepository.Save(entity);
        }
    }
}