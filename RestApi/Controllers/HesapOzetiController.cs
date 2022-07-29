using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HesapOzetiController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("HesapOzeetiListele")] 
        public List<Repository.Models.HesapOzeti> GetAll()
        {
            var Hesap = _bitapDbContext.HesapOzetis.ToList();
            return Hesap;
        }
        [HttpGet]
        [Route("TCHesapOzeti")]
        public List<Repository.Models.HesapOzeti> TCHesapOzeti(String TC)
        {
            List<Repository.Models.HesapOzeti> hesapOzetis = _bitapDbContext.HesapOzetis.Where(x => x.Tc.Equals(TC)).ToList();
            return hesapOzetis;

        }
    }
}
