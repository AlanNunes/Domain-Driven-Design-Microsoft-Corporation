using SharedKernel.Domain.ValueObjects;

namespace SharedKernel.Domain.Aggregates
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Money Price { get; set; }
    }
}
