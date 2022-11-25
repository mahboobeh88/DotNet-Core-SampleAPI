using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sampleAPI.IServices;
using sampleAPI.Models.Requests.Products;


namespace sampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("/Products/")]
        [Authorize]
        public async Task<IActionResult> GetProductList([FromQuery]GetProductsListRequest request, [FromServices] IGetProductsListService _service)
        {
            var result = await _service.ExecuteAsync(request, null);
            if (result == null)
                return NoContent();
            return Ok(result);

        }
        [HttpGet]
        [Route("/Products/Search")]
        [Authorize]
        public async Task<IActionResult> Search([FromQuery]GetProductsListRequest request, [FromQuery]SearchProductRequest Searchrequest, [FromServices] IGetProductsListService _service)
        {
            var result = await _service.ExecuteAsync(request, Searchrequest);
            if (result == null)
                return NoContent();
            return Ok(result);
        }
    }
}