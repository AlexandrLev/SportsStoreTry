using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product{Name="Football", Price=25},
            new Product{Name="Board for surfing", Price=179},
            new Product{Name="Shoes for running ", Price=95}
        }.AsQueryable<Product>();
    }
}
