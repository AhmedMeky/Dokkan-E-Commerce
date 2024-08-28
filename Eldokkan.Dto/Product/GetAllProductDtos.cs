using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Dto.Product
{
    public class GetAllProductDtos
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

    }
}
