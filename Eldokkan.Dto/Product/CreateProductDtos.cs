using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Dto.Product
{
    public class CreateProductDtos
    {
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

    }
}
