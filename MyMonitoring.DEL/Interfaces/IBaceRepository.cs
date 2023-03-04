using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyMonitoring.Domain.Entity;

namespace MyMonitoring.DEL.Interfaces
{
    public interface IBaceRepository<T>
    {
        bool Create(T entity);

        T Get(int id);

        Task<List<Car>> Select();

        bool Delete(T entity);
    }
}