using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarvedRock.Api.Data.Entities;

namespace CarvedRock.Api.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
