using System;
using MyMonitoring.Domain.Entity;

namespace MyMonitoring.DEL.Interfaces
{
    public interface ICarRepository : IBaceRepository<Car>
    {
        Car GetByName(String name);
    }
}