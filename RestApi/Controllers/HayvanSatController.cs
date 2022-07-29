using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HayvanSatController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("HayvanSatListele")]
        public List<Repository.Models.HayvanSat> GetAll()
        {
            var hayvanSats = _bitapDbContext.HayvanSats.ToList();
            return hayvanSats;
        }
        [HttpPut]
        [Route("HayvaSatCreat")]
        public IActionResult HayvaSatCreat(string Aciklama, string Tel, string Fiyat, string Cinsiyet, string Resim, string IsletmeNo, DateTime Tarih, string Yas)
        {
            Repository.Models.HayvanSat hayvanSat = new Repository.Models.HayvanSat();
            hayvanSat.Aciklama = Aciklama;
            hayvanSat.Tel      = Tel;   
            hayvanSat.Fiyat    = Fiyat;
            hayvanSat.Cinsiyet = Cinsiyet;
            hayvanSat.Resim    = Resim;
            hayvanSat.IsletmeNo= IsletmeNo;
            hayvanSat.Tarih = Tarih;
            hayvanSat.Yas      = Yas;
            _bitapDbContext.HayvanSats.Add(hayvanSat);
            _bitapDbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("HayvaSatDelete")]
        public IActionResult HayvaSatCreat(int Id)
        {
            var hayvanBilgileris = _bitapDbContext.HayvanSats.Where(x => x.SatisId.Equals(Id)).FirstOrDefault();
            _bitapDbContext.HayvanSats.Remove(hayvanBilgileris);
            _bitapDbContext.SaveChanges();
            return Ok();
        }
    }
}
