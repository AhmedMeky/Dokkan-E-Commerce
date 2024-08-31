
using AutoMapper;
using Eldokkan.Dto.Product;
using ELDOKKAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Application.Mapper
{
    public class AutoMapperPro : Profile
    {
        public AutoMapperPro()
        {

            CreateMap<CreateProductDtos, Product>().ReverseMap();
            CreateMap<GetAllProductDtos, Product>().ReverseMap();
        }

    }
}
