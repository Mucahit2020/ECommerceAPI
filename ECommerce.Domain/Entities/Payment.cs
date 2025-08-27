using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid OrderId { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? TransactionId { get; set; }

        // Navigation
        public Order Order { get; set; }
    }
}
