using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Northwind.Data;
using Northwind.Entity;

namespace Northwind.Repository
{
    public interface IUnitOfWork
    {
        void Save();
        Task<int> SaveAsync();
        Task<int> SaveAsync(CancellationToken cancellationToken);
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity> () where TEntity : EntityBase, new();
    }
}
