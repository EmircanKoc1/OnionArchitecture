using Microsoft.EntityFrameworkCore.Storage;

namespace OnionArcExample.Application.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }

    }
}
