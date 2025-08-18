using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Products
{
    public sealed record CreateProductRequest(Guid id, string Name, decimal Price, int Stock, string ImgUrl);

}
