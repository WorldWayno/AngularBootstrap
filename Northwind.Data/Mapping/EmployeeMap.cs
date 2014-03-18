using System.Data.Entity.ModelConfiguration;
using Northwind.Entity;

namespace Northwind.Data.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.HasKey(c => c.EmployeeId);


            this.ToTable("Employees");
        }
    }
}