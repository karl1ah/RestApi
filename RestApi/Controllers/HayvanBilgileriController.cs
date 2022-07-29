using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Repository;
using RestApi.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HayvanBilgileriController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new bitapDbContext();

        [HttpGet]
        [Route("hayvanListele")]
        public List<Repository.Models.HayvanBilgileri> GetAll()
        {
            var hayvanBilgileris = _bitapDbContext.HayvanBilgileris.ToList();
            return hayvanBilgileris;
        }
        [HttpGet]
        [Route("IsletmeoHayvan")]
        public List<Repository.Models.HayvanBilgileri> GetHayvanBilgileris(String IsletmeNo)
        {
            List<Repository.Models.HayvanBilgileri> hayvanBilgileris1 = _bitapDbContext.HayvanBilgileris.Where(x=> x.IsletmeNo.Equals(IsletmeNo)).ToList();
            return hayvanBilgileris1;
            
        }
        [HttpPost]
        [Route("AdUpdate")]
        public IActionResult AdUpdate(string KulakNo,String Adi)
        {
            var hayvanBilgileris = _bitapDbContext.HayvanBilgileris.Where(x => x.KulakNo.Equals(KulakNo)).FirstOrDefault();
            hayvanBilgileris.Adi=Adi;
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
        [HttpPost]
        [Route("BuzağılamaTarihUpdate")]
        public IActionResult BuzağılamaTarihUpdate(string KulakNo, DateTime BuzağılamaTarih)
        {
            var hayvanBilgileris = _bitapDbContext.HayvanBilgileris.Where(x => x.KulakNo.Equals(KulakNo)).FirstOrDefault();
            hayvanBilgileris.BuzalamaTarihi = BuzağılamaTarih;
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
    }
}
