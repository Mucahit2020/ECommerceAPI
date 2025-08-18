using ECommerce.Domain.Entities.Abstractions;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Products
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IUnitOfWork _uow;

        public ProductService(IProductRepository repo, IUnitOfWork uow)
        {
            _repo = repo; _uow = uow;
        }

        public async Task<Guid> CreateAsync(CreateProductRequest request, CancellationToken ct = default)
        {
            // Kural domain ctor'unda çalışır (ImgUrl dahil)
            var product = new Product(request.Name, request.Price, request.Stock, request.ImgUrl);

            await _repo.AddAsync(product, ct);
            await _uow.SaveChangesAsync(ct);

            return product.Id;
        }

        public Task<List<Product>> GetAllAsync(CancellationToken ct = default)
            => _repo.GetAllAsync(ct);
    }
}
