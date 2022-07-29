using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsletmeBilgileriController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("IsletmeBilgileriListele")]
        public List<Repository.Models.IsletmeBilgileri> GetAll()
        {
            var Isletme =_bitapDbContext.IsletmeBilgileris.ToList();
            return Isletme;
        }

        [HttpPost]
        [Route("SifreUpdate")]
        public IActionResult SifreUpdate(string IsletmeNo, String Sifre)
        {
            var ısletmeBilgileri = _bitapDbContext.IsletmeBilgileris.Where(x => x.IsletmeNo.Equals(IsletmeNo)).FirstOrDefault();
            ısletmeBilgileri.Sifre = Sifre;
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
        [HttpPost]
        [Route("BilgilerUpdate")]
        public IActionResult BilgilerUpdate(string IsletmeNo, String Evtel, String CepTel, String Resim, String Email)
        {
            var ısletmeBilgileri = _bitapDbContext.IsletmeBilgileris.Where(x => x.IsletmeNo.Equals(IsletmeNo)).FirstOrDefault();
            ısletmeBilgileri.EvTelefon = Evtel;
            ısletmeBilgileri.CepTelefon = CepTel;
            ısletmeBilgileri.Resim = Resim;
            ısletmeBilgileri.Email = Email;
            _bitapDbContext.SaveChanges();
            return Ok(200);
        }
        [HttpGet]
        [Route("Login")]
        public Repository.Models.IsletmeBilgileri login(String IsletmeNo ,String Sifre)
        {
            var ısletmeBilgileri = _bitapDbContext.IsletmeBilgileris.Where(x => 
            x.IsletmeNo.Equals(IsletmeNo)&&x.Sifre.Equals(Sifre)).FirstOrDefault(); 
            return ısletmeBilgileri;

        }

    }
}
