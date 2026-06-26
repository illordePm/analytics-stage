using analytics_backend.Data;
using analytics_backend.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace analytics_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet(Name = "GetList")]
        public ActionResult<List<ShopResponse>> Get()
        {
            var tutto = _appDbContext.Shops.ToList();

            List<ShopResponse> response = tutto.Select(shop => new ShopResponse
            {
                ShopId = shop.Id, 
                Code = shop.Code,
                Name = shop.Name
            }).ToList();


            return Ok(response);
        }
    }
}
