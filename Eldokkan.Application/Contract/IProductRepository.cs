using ELDOKKAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Application.Contract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Product Search(string name); 
    }
}
