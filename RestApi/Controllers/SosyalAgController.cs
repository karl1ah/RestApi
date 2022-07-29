using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SosyalAgController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("SosyalAgListele")]
        public List<Repository.Models.SosyalAg> GetAll()
        {
            var sosyalAgs = _bitapDbContext.SosyalAgs.ToList();
            return sosyalAgs;
        }
        [HttpPut]
        [Route("SosyalAgCreat")]
        public IActionResult SosyalAgCreat(string Aciklama, string Resim, string IsletmeNo, DateTime Tarih)
        {
            Repository.Models.SosyalAg sosyalAg = new Repository.Models.SosyalAg();
            sosyalAg.Aciklama = Aciklama;
            sosyalAg.IsletmeNo = IsletmeNo; 
            sosyalAg.Resim = Resim;
            sosyalAg.Tarih = Tarih;
            _bitapDbContext.SosyalAgs.Add(sosyalAg);
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
    }
}
