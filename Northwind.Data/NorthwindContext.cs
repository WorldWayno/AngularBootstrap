using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Northwind.Data.Mapping;

namespace Northwind.Data
{
    public class NorthwindContext : DataContextBase
    {
        static NorthwindContext()
        {
            System.Data.Entity.Database.SetInitializer<NorthwindContext>(null);
        }

        public NorthwindContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
              
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
