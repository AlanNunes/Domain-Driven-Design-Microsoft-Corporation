using SharedKernel.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedKernel.Application.Interfaces
{
    public interface IProductAppService : IServiceAppBase<Product>
    {
    }
}
