using System.Collections.Generic;
using System.Linq;

namespace SharedKernel.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
