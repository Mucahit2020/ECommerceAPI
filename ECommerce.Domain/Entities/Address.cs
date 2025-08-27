﻿namespace ECommerce.Domain.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public Guid CustomerId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        // Navigation
        public ICollection<Order> ShippingOrders { get; set; }
        public ICollection<Order> BillingOrders { get; set; }
    }
}
