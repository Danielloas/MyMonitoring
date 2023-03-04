using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMonitoring.DEL.Interfaces;
using MyMonitoring.Domain.Entity;

namespace MyMonitoring.DEL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Car>> Select()
        {
            return _db.Car.ToListAsync();
        }

        public bool Delete(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}