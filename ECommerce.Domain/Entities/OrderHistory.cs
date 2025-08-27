using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities
{
    public class OrderHistory
    {
        public Guid OrderHistoryId { get; set; }
        public Guid OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime ChangedDate { get; set; } = DateTime.UtcNow;
        public string ChangedBy { get; set; } = string.Empty;

        // Navigation
        public Order Order { get; set; }
    }
}
