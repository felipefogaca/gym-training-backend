using GymTraining.Domain.Common.SeedWork;

namespace GymTraining.Domain.Common.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T?> Find(Guid id);
        Task Create(T entity);
        Task Update(T entity);
    }
}
