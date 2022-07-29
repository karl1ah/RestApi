using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuyuruAltController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("DuyuruAltListele")]
        public List<Repository.Models.DuyuruAlt> GetAll()
        {
            var duyuruAlts = _bitapDbContext.DuyuruAlts.ToList();
            return duyuruAlts;
        }
        [HttpPut]
        [Route("DuyuruAltCreat")]
        public IActionResult DuyuruAltCreat(string GonderiNo, string IsletmeNo, int Sayi)
        {
            Repository.Models.DuyuruAlt duyuruAlt = new Repository.Models.DuyuruAlt();
            duyuruAlt.GonderiNo = GonderiNo;
            duyuruAlt.IsletmeNo = IsletmeNo;
            duyuruAlt.Sayi = Sayi;
            _bitapDbContext.DuyuruAlts.Add(duyuruAlt);
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
    }
}
