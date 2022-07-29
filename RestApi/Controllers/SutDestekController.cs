using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SutDestekController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("sutDestekListele")]
        public List<Repository.Models.SutDestek> GetAll()
        {
            var sutDesteks = _bitapDbContext.SutDesteks.ToList();
            return sutDesteks;
        }
        [HttpGet]
        [Route("TCSutDestek")]
        public List<Repository.Models.SutDestek> TCSutDestek(String TC)
        {
            List<Repository.Models.SutDestek> sutDesteks = _bitapDbContext.SutDesteks.Where(x => x.Tc.Equals(TC)).ToList();
            return sutDesteks;

        }
    }
}
