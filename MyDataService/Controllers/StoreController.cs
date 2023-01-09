using Microsoft.AspNetCore.Mvc;
using MyDataService.Models;

namespace MyDataService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : Controller
    {
        [HttpGet(Name = "GetALbums")]
        public IEnumerable<Album> Index()
        {
            ChinookContext cnt = new ChinookContext();
            return cnt.Albums;
        }
    }
}
