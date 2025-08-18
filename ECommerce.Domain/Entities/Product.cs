using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{

    public class Product
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = default!;
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string ImgUrl { get; private set; } = default!;

        private Product() { }

        public Product(string name, decimal price, int stock, string imgUrl)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ürün adı boş olamaz.");
            if (price <= 0)
                throw new ArgumentException("Fiyat sıfırdan büyük olmalı.");
            if (stock < 0)
                throw new ArgumentException("Stok negatif olamaz.");
            if (string.IsNullOrWhiteSpace(imgUrl))
                throw new ArgumentException("ImgUrl zorunludur.");

            if (!Uri.TryCreate(imgUrl, UriKind.RelativeOrAbsolute, out _))
                throw new ArgumentException("ImgUrl formatı geçersiz.");

            Name = name.Trim();
            Price = price;
            Stock = stock;
            ImgUrl = imgUrl.Trim();
        }

        public void DecreaseStock(int qty)
        {
            if (qty <= 0) throw new ArgumentException("qty > 0 olmalı");
            if (Stock - qty < 0) throw new InvalidOperationException("Yetersiz stok");
            Stock -= qty;
        }

        public void UpdateImgUrl(string imgUrl)
        {
            if (string.IsNullOrWhiteSpace(imgUrl))
                throw new ArgumentException("ImgUrl zorunludur.");
            if (!Uri.TryCreate(imgUrl, UriKind.RelativeOrAbsolute, out _))
                throw new ArgumentException("ImgUrl formatı geçersiz.");
            ImgUrl = imgUrl.Trim();
        }
    }

}

