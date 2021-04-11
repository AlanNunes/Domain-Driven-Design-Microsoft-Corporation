using SharedKernel.Domain.Aggregates;
using SharedKernel.Domain.Interfaces.Repositories;
using SharedKernel.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedKernel.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(MicrosoftCorporationContext context) : base(context)
        {
        }
    }
}
