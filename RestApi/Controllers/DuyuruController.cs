using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuyuruController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("DuyuruListele")]
        public List<Repository.Models.Duyuru> DuyuruListele(string Tip)
        {
            List<Repository.Models.Duyuru> duyurus = _bitapDbContext.Duyurus.Where(x => x.Tip.Equals(Tip)).ToList();
            return duyurus;
        }
        [HttpPost]
        [Route("EvethayırUpdate")]
        public IActionResult AdUpdate(string GonderiNo, int Evet,int Hayır)
        {
            var duyuru = _bitapDbContext.Duyurus.Where(x => x.GonderNo.Equals(GonderiNo)).FirstOrDefault();
            duyuru.Evet = Evet;
            duyuru.Hayır = Hayır;
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
    }
}
