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
        private EldokkanContext context;

        public ProductRepository(EldokkanContext _context) : base(_context)
        {

        }
    }
}
