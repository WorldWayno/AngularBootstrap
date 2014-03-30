using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using Northwind.Entity;

namespace Northwind.Data
{
    public class DataContextBase : DbContext, IDataContext
    {
        private readonly Guid _instanceId;

        public DataContextBase(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            _instanceId = Guid.NewGuid();
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public Guid InstanceId
        {
            get { return _instanceId; }
        }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            SyncObjectsStatePreCommit();
            var changes = base.SaveChanges();
            SyncObjectsStatePostCommit();
            return changes;
        }

        public override Task<int> SaveChangesAsync()
        {
            SyncObjectsStatePreCommit();
            var changesAsync = base.SaveChangesAsync();
            SyncObjectsStatePostCommit();
            return changesAsync;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            SyncObjectsStatePreCommit();
            var changesAsync = base.SaveChangesAsync(cancellationToken);
            SyncObjectsStatePostCommit();
            return changesAsync;
        }

        public void SyncObjectState(object entity)
        {
            Entry(entity).State = StateHelper.ConvertState(((IObjectState)entity).ObjectState);
        }
        private void SyncObjectsStatePreCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
                dbEntityEntry.State = StateHelper.ConvertState(((IObjectState)dbEntityEntry.Entity).ObjectState);
        }

        public void SyncObjectsStatePostCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
                ((IObjectState)dbEntityEntry.Entity).ObjectState = StateHelper.ConvertState(dbEntityEntry.State);
        }
    }
}