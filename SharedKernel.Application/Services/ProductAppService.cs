using SharedKernel.Application.Interfaces;
using SharedKernel.Domain.Aggregates;
using SharedKernel.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedKernel.Application.Services
{
    public class ProductAppService : ServiceAppBase<Product>, IProductAppService
    {
        private readonly IProductRepository productRepository;
        public ProductAppService(IProductRepository productRepository) : base(productRepository)
        {
            this.productRepository = productRepository;
        }
    }
}
