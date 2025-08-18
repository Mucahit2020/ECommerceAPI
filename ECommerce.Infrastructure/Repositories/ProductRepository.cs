using ECommerce.Domain.Entities;
using ECommerce.Domain.Entities.Abstractions;
using ECommerce.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _db;
        public ProductRepository(AppDbContext db) => _db = db;

        public async Task AddAsync(Product product, CancellationToken ct = default)
            => await _db.Products.AddAsync(product, ct);

        public Task<Product?> GetByIdAsync(Guid id, CancellationToken ct = default)
            => _db.Products.FirstOrDefaultAsync(p => p.Id == id, ct);

        public Task<List<Product>> GetAllAsync(CancellationToken ct = default)
            => _db.Products.AsNoTracking().ToListAsync(ct);
    }
}
