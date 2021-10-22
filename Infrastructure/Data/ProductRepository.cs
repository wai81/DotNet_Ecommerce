using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }

        Task<Product> IProductRepository.GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<Product>> IProductRepository.GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}