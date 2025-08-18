using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Products
{
    public interface IProductService
    {
        Task<Guid> CreateAsync(CreateProductRequest request, CancellationToken ct = default);
        Task<List<Product>> GetAllAsync(CancellationToken ct = default);
    }
}
