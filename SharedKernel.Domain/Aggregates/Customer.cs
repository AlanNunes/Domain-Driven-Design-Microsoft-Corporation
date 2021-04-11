using SharedKernel.Domain.ValueObjects;

namespace SharedKernel.Domain.Aggregates
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}
