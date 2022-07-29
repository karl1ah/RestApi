using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HakkımızdaController : ControllerBase
    {
        private Repository.bitapDbContext _bitapDbContext = new Repository.bitapDbContext();
        [HttpGet]
        [Route("HakkımızdaListele")]
        public List<Repository.Models.Hakkımızdum> GetAll()
        {
            var hakkımızda = _bitapDbContext.Hakkımızda.ToList();
            return hakkımızda;
        }
    }
}
