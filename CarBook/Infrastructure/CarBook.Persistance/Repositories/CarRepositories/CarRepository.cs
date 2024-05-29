using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }

        public List<Car> GetLast5CarstWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).Take(5).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
