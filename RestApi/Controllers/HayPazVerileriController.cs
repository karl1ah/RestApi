using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HayPazVerileriController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("HayPazVerileriListele")]
        public List<Repository.Models.HayPazVerileri> GetAll()
        {
            var hayPazVerileris = _bitapDbContext.HayPazVerileris.ToList();
            return hayPazVerileris;
        }
        [HttpPost]
        [Route("HayPazVerileriUpdate")]
        public IActionResult HayPazVerileriUpdate(String Id, String Isi, String Nem, String Yagmur)
        {
            var hayPazVerileri = _bitapDbContext.HayPazVerileris.Where(x => x.Hpid.Equals(Id)).FirstOrDefault();
            hayPazVerileri.Isi = Isi;
            hayPazVerileri.Nem = Nem;
            hayPazVerileri.Bilinmeyen = Yagmur;
            _bitapDbContext.SaveChanges();
            return Ok();
        }
    }
}
