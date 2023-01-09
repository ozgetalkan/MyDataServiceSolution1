using MyDataService.Models;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        async Task yazdir()
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
            foreach (var item in listem)
            {
                Console.WriteLine(item.Title);
            };
        }
    }
}