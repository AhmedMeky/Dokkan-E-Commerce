using Eldokkan.Application.Contract;
using ELDOKKAN.Context;
using ELDOKKAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Infrastructure
{
    public class ProductRepository :GenericRepository<Product> , IProductRepository
    {
        private AppDbContext context;

        public ProductRepository(AppDbContext _context) : base(_context)
        {
            context = _context;
        }

       public  Product Search(string name)
        {
            return context.Products.FirstOrDefault(p => p.Name == name);
           
        }
    }
}
