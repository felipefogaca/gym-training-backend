using GymTraining.Domain.Common.Entities;

namespace GymTraining.Domain.Common.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T?> Find(Guid id);
        Task Create(T entity);
        Task Update(T entity);
    }
}
