using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var values = _context.Comments.GroupBy(c => c.BlogID).
                Select(y => new
                {
                    BlogID = y.Key,
                    Count = y.Count(),
                }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogTitle = _context.Blogs.Where(x => x.BlogID == values.BlogID).Select(k => k.Title).FirstOrDefault();
            return blogTitle;
        }

        public string GetBrandNameByMaxCar()
        {
            // SELECT Brands.Name, COUNT(*) AS 'max brand' FROM Cars
            //inner join Brands
            //on
            //Cars.BrandID = Brands.BrandID
            //GROUP BY Brands.Name
            //ORDER BY 'max brand' DESC
            var values = _context.Cars.GroupBy(x => x.BrandID).
                 Select(y => new
                 {
                     BrandID = y.Key,
                     Count = y.Count()
                 }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string brandName = _context.Brands.Where(x => x.BrandID == values.BrandID).Select(y => y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(k => k.Name == "Daily").Select(z => z.PricingID).FirstOrDefault();

            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(k => k.Name == "Monthly").Select(z => z.PricingID).FirstOrDefault();

            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(k => k.Name == "Weekly").Select(z => z.PricingID).FirstOrDefault();

            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        { //Select * from CarPricings where Amount=(Select Max(Amount) From CarPricings where PricingID=(Select PricingID from Pricings where  Name='Daily'))
            int pricingId = _context.Pricings.Where(p => p.Name == "Daily").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(c => c.PricingID == pricingId).Max(x => x.Amount);
            int carId = _context.CarPricings.Where(k => k.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(z => z.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;

        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricingId = _context.Pricings.Where(p => p.Name == "Daily").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(c => c.PricingID == pricingId).Min(x => x.Amount);
            int carId = _context.CarPricings.Where(k => k.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(z => z.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Electric").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Gasoline" || x.Fuel == "Diesel").Count();
            return value;
        }

        public int GetCarCountByKmLower1000()
        {
            var value = _context.Cars.Where(x => x.Km <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionisAuto()
        {
            var value = _context.Cars.Count(x => x.Transmission == "Auto");
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }
    }
}
