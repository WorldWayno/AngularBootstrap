using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Northwind.Data;

namespace Northwind.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext _context;
        private Hashtable _repositories;

        public UnitOfWork(IDataContext context)
        {
            _context = context;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : EntityBase, new()
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))
            {
                return (IRepository<TEntity>)_repositories[type];
            }

            var repositoryType = typeof(Repository<>);
            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context));

            return (IRepository<TEntity>)_repositories[type];
        }
    }
}