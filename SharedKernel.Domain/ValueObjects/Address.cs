namespace SharedKernel.Domain.ValueObjects
{
    public class Address : ValueObject<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        protected override bool EqualsCore(Address other)
        {
            return Street == other.Street &&
                City == other.City &&
                Country == other.Country &&
                ZipCode == other.ZipCode;
        }

        protected override int GetHashCodeCore()
        {
            return new { Street, City, Country, ZipCode }.GetHashCode();
        }
    }
}
