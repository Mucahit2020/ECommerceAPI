namespace ECommerce.Domain.Enums
{
    public enum OrderStatus
    {
        Pending,      // Beklemede
        Paid,         // Ödeme alındı
        Shipped,      // Kargoya verildi
        Completed,    // Teslim edildi
        Canceled,     // İptal
        Refunded      // İade
    }
}
