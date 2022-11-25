using sampleAPI.Models.Requests.Products;
using sampleAPI.Models.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.IServices
{
    public interface IGetProductsListService
    {
        Task<ResultProductsList> ExecuteAsync(GetProductsListRequest request, SearchProductRequest searchRequest);
    }
}
