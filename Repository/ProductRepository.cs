using MongoDB.Driver;
using Sync.WebApi.Config;
using Sync.WebApi.Entities;

namespace Sync.WebApi.Repository
{
    public class ProductRepository
    {
        private readonly SyncApiDbContext _context;
        private readonly IMongoCollection<ProductEntity> _productContext;
        
        public ProductRepository(SyncApiDbContext context)
        {
            _context = context;
            _productContext = _context.products;
        }

        public ProductEntity Save(ProductEntity productEntity)
        {
            _productContext.InsertOne(productEntity);

            return productEntity;
        }
    }
}