using CarBook.Dto.BrandDtos;
using CarBook.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBook.Web.UI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var book_pick_date = TempData["book_pick_date"];
            var book_off_date = TempData["book_off_date"];
            var time_pick = TempData["time_pick"];
            var time_off = TempData["time_off"];
            var locationId = TempData["locationId"];

            ViewBag.book_pick_date = book_pick_date;
            ViewBag.book_off_date = book_off_date;
            ViewBag.time_pick = time_pick;
            ViewBag.time_off = time_off;
            ViewBag.locationId = locationId;
            id = int.Parse(locationId.ToString());
            //filterRentACarDto.LocationID = int.Parse(locationId.ToString());
            //filterRentACarDto.IsAvailable = true;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7262/api/RentACars?locationId={id}&isAvaible=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
