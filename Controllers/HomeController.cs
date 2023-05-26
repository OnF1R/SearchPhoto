using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SearchPhoto.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SearchPhoto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private const string ACCESS_KEY = "SJLcb8xTAsDOUNUSTHkGBHCMPYLKQofVz0sQaGpcesI";

        private const string BASE_LINK = "https://api.unsplash.com/";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> SearchPhotos(string query, int page = 1)
        {
            var photos = await GetSearchPhotos(query, page);
            photos.TotalPages = photos.Total / 30 + 1;
            return Json(photos);
        }

        [HttpGet]
        public async Task<JsonResult> RandomPhotos()
        {
            var photos = await GetRandomPhotos();
            return Json(photos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        private async Task<PhotoData[]> GetRandomPhotos()
        {
            string photosData = "";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(BASE_LINK + "photos/random/?client_id=" + ACCESS_KEY + "&count=30");
            HttpContent content = response.Content;
            if (response.IsSuccessStatusCode)
            {
                photosData = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<PhotoData[]>(photosData);
        }

        [HttpGet]
        private async Task<SearchPhotoData> GetSearchPhotos(string query, int page = 1)
        {
            string photosData = "";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(BASE_LINK + "search/photos/?page=" + page + "&per_page=30&client_id=" + ACCESS_KEY + "&query=" + query);
            HttpContent content = response.Content;
            if (response.IsSuccessStatusCode)
            {
                photosData = await response.Content.ReadAsStringAsync();
            }

            Debug.WriteLine(photosData);

            return JsonConvert.DeserializeObject<SearchPhotoData>(photosData);
        }
    }
}