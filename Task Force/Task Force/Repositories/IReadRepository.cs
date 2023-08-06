using Task_Force.Entities;

namespace Task_Force.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
    }
}
