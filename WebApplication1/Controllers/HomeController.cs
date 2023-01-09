using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyDataService.Models;
using Newtonsoft.Json;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
           List<Gubudik> listem =
                new List<Gubudik>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5126/store"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listem = JsonConvert.DeserializeObject<List<Gubudik>>(apiResponse);
                }
            }
            return View(listem);
        }

        public IActionResult Privacy()
        {
            return View();
        }

 
    }
}
