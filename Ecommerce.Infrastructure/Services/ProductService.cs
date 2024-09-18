using Ecommerce.Application.Interfaces.Repositories;
using Ecommerce.Application.Interfaces.Services;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _repo;

        public ProductService(IGenericRepository<Product> repo)
        {
            _repo = repo;
        }
    }
}
