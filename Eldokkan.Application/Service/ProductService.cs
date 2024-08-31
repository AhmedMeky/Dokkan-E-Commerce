using AutoMapper;
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
    public class ProductService : IProductServices
    {
        IProductRepository iproductRepository;
        IMapper Mapper; 
        public ProductService(IProductRepository _iproductRepository , IMapper _Mapper) 
        {
            iproductRepository = _iproductRepository;
            Mapper = _Mapper;
        }

       public CreateProductDtos ADDProduct(CreateProductDtos product)
        {

            var prod = Mapper.Map<Product>(product);
            if(prod != null)
            {
                iproductRepository.Create(prod);
                return Mapper.Map<CreateProductDtos>(prod);
            }
            return null;
        }

        public List<GetAllProductDtos> GetPagination(int count, int PageNumber)
        {
            var productList = iproductRepository.GetAll().Skip(count*(PageNumber-1)).Take(count*PageNumber)
                .Select(p=>new GetAllProductDtos { Name = p.Name , UnitPrice =p.UnitPrice , CategoryID = p.CategoryID  }).ToList();
            return productList; 

        }

        public List<GetAllProductDtos> Get_All()
        {
            var productList = iproductRepository.GetAll().Select(p => new GetAllProductDtos { Name = p.Name, UnitPrice = p.UnitPrice, CategoryID = p.CategoryID }).ToList();
            return productList;

        }

        public GetAllProductDtos Search(string name ) // search on Elements to Get one Element
        {
            var productList = iproductRepository.Search(name);
            return Mapper.Map<GetAllProductDtos>(productList);

        }


        public int  All_product_sum()
        {
          return iproductRepository.GetAll().ToList().Count();

        }


    }
}
