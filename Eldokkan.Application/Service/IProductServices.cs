using Eldokkan.Application.Contract;
using Eldokkan.Dto.Product;
using ELDOKKAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Application.Service
{
    public interface IProductServices
    {
        public CreateProductDtos ADDProduct(CreateProductDtos product);
        public List<GetAllProductDtos> GetPagination(int count , int PageNumber);
        public int All_product_sum();

        public GetAllProductDtos Search(string name);

        public List<GetAllProductDtos> Get_All();
        
    }
}
