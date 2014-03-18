using System;
using System.Data.Entity;

namespace Northwind.Data
{
    public interface IDataContext : IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        void SyncObjectState(object entity);
    }
}