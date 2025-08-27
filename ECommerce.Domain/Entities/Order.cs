using ECommerce.Domain.Enums;
using System.Net;

namespace ECommerce.Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        // Ödeme
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime? PaidDate { get; set; }
        public string? TransactionId { get; set; }

        // Adresler
        public Guid ShippingAddressId { get; set; }
        public Guid BillingAddressId { get; set; }
        public string? ShippingMethod { get; set; }
        public string? TrackingNumber { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? DeliveredDate { get; set; }

        // Tutar Bilgileri
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal GrandTotal { get; set; }

        // Diğer
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public ICollection<OrderHistory> History { get; set; } = new List<OrderHistory>();
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}
