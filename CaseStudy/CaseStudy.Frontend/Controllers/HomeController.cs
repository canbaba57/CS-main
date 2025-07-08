using CaseStudy.Frontend.Models;
using CaseStudy.Frontent.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;

namespace CaseStudy.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5012/api/products");

            if(responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ProductResponseModel>>(jsonData);
                foreach(ProductResponseModel product in result)
                {
                    var responseMessage2 = await client.GetAsync($"http://localhost:5012/api/products/price/{product.Id}");

                    if (responseMessage2.IsSuccessStatusCode)
                    {
                        var priceString = await responseMessage2.Content.ReadAsStringAsync();

                        var parsed = Convert.ToDecimal(priceString, CultureInfo.InvariantCulture);

                        product.price = Math.Round(parsed, 2);

                    }
                }
                return View(result);

            }
            return View(null);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
