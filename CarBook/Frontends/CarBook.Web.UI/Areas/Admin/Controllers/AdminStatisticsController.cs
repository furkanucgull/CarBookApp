using CarBook.Dto.AuthorDtos;
using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region Statistic1
            var responseMessage = await client.GetAsync("https://localhost:7262/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int v1 = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v = values.CarCount;
                ViewBag.v1 = v1;
            }
            #endregion
            #region Statistic2
            var responseMessage2 = await client.GetAsync("https://localhost:7262/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.LocationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }
            #endregion
            #region Statistic3
            var responseMessage3 = await client.GetAsync("https://localhost:7262/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.authorCount = values3.AuthorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }
            #endregion
            #region Statistic4
            var responseMessage4 = await client.GetAsync("https://localhost:7262/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.BlogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }
            #endregion
            #region Statistic5
            var responseMessage5 = await client.GetAsync("https://localhost:7262/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.brandCount = values5.BrandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion
            #region Statistic6
            //ToDo: weekly ve daily gelmiyor
            var responseMessage6 = await client.GetAsync("https://localhost:7262/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyCountRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.avgRentPriceForDailyCount = values6.avgPriceForDaily.ToString("0");
                ViewBag.avgRentPriceForDailyCountRandom = avgRentPriceForDailyCountRandom;
            }
            #endregion
            #region Statistic7
            var responseMessage7 = await client.GetAsync("https://localhost:7262/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyCountRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.avgRentPriceForWeeklyCount = values7.avgRentPriceForWeekly.ToString("0");
                ViewBag.avgRentPriceForWeeklyCountRandom = avgRentPriceForWeeklyCountRandom;
            }
            #endregion
            #region Statistic8
            var responseMessage8 = await client.GetAsync("https://localhost:7262/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyCountRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.avgRentPriceForMonthlyCount = values8.avgRentPriceForMonthly.ToString("0");
                ViewBag.avgRentPriceForMonthlyCountRandom = avgRentPriceForWeeklyCountRandom;
            }
            #endregion
            #region Statistic9
            var responseMessage9 = await client.GetAsync("https://localhost:7262/api/Statistics/GetCarCountByTransmissionisAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int CarCountByTransmissionisAutoCountRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.CarCountByTransmissionisAutoCount = values9.carCountByTransmissionisAuto.ToString("0");
                ViewBag.CarCountByTransmissionisAutoCountRandom = CarCountByTransmissionisAutoCountRandom;
            }
            #endregion
            #region Statistic10
            var responseMessage10 = await client.GetAsync("https://localhost:7262/api/Statistics/GetCarCountByKmLower1000");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int CarCountByKmLower1000CountRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.CarCountByKmLower1000Count = values10.carCountByKmLower1000.ToString("0");
                ViewBag.CarCountByKmLower1000CountRandom = CarCountByKmLower1000CountRandom;
            }
            #endregion 
            #region Statistic11
            var responseMessage11 = await client.GetAsync("https://localhost:7262/api/Statistics/GetCarCountByElectric");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int CarCountByElectricCountRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.CarCountByElectricCount = values11.carCountByElectric.ToString("0");
                ViewBag.CarCountByElectricCountRandom = CarCountByElectricCountRandom;
            }
            #endregion
            #region Statistic12
            var responseMessage12 = await client.GetAsync("https://localhost:7262/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int CarCountByFuelGasolineOrDieselCountRandom = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.CarCountByFuelGasolineOrDieselCount = values12.carCountByFuelGasolineOrDiesel.ToString("0");
                ViewBag.CarCountByFuelGasolineOrDieselCountRandom = CarCountByFuelGasolineOrDieselCountRandom;
            }
            #endregion 
            return View();
        }
    }
}
