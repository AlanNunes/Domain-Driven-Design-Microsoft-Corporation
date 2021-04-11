using SharedKernel.Domain.Aggregates;

namespace Sales.Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
