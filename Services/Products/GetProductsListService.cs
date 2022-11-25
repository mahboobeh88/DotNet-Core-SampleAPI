using Microsoft.EntityFrameworkCore;
using sampleAPI.IServices;
using sampleAPI.Models.Context;
using sampleAPI.Models.Requests.Products;
using sampleAPI.Models.Responces;
using sampleAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace sampleAPI.Services.Products
{
    public class GetProductsListService :IGetProductsListService
    {
        public readonly DataBaseContext _dbContext;
        public GetProductsListService(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResultProductsList> ExecuteAsync(GetProductsListRequest request , SearchProductRequest searchRequest)
        {
            int totalCount = 0;
            var productQuery =await _dbContext.Products.AsNoTracking().ToListAsync();

            if (productQuery.Count == 0)
                return null;

            if (searchRequest != null)
                productQuery = productQuery.Where(p => (!searchRequest.ProductColor.HasValue || p.Color == searchRequest.ProductColor.Value)
                                                 && (!searchRequest.ProductType.HasValue || p.Type ==searchRequest.ProductType.Value)).ToList();
          
            var product = productQuery.ToPaged(request.CurrentPage, request.PageSize, out totalCount).ToList();
            return new ResultProductsList()
            {
                ProductsList = product,
                TotalCount = totalCount
            };
        }
    }
}
