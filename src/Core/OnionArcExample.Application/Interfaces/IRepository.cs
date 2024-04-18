using OnionArcExample.Domain.Common;

namespace OnionArcExample.Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync();
        Task<T> AddAsync();


    }
}
