using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IletisimController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("IletisimListele")]
        public List<Repository.Models.Iletisim> GetAll()
        {
            var ıletisims = _bitapDbContext.Iletisims.ToList();
            return ıletisims;
        }
        [HttpGet]
        [Route("AciklamaIletısım")]
        public List<Repository.Models.Iletisim> AciklamaIletısım(String Aciklama)
        {
            List<Repository.Models.Iletisim> ıletisims = _bitapDbContext.Iletisims.Where(x => x.Aciklama.Equals(Aciklama)).ToList();
            return ıletisims;

        }
    }
}
