using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public class NorthwindDatabaseInitializer : DropCreateDatabaseAlways<NorthwindContext>
    {
        public override void InitializeDatabase(NorthwindContext context)
        {
            if (context != null)
            {
                
            }

            base.InitializeDatabase(context);
        }

        protected override void Seed(NorthwindContext context)
        {
            if (context != null)
            {
                
            }

            base.Seed(context);
        }
    }
}
