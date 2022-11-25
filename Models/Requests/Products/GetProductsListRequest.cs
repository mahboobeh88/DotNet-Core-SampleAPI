using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Models.Requests.Products
{
    public class GetProductsListRequest
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
