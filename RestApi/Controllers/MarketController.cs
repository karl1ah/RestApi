using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("MarketListele")]
        public List<Repository.Models.Market> GetAll()
        {
            var markets = _bitapDbContext.Markets.ToList();
            return markets;
        }
    }
}
