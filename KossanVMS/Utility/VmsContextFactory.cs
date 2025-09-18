using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KossanVMS.Data;

namespace KossanVMS.Utility
{
    public class VmsContextFactory : IDesignTimeDbContextFactory<VmsContext>
    {
        public VmsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VmsContext>();
            optionsBuilder.UseSqlServer ("Server=(localdb)\\MSSQLLocalDB; Database=newVMS;User Id=root; Password=Kossan@123456;");

            return new VmsContext(optionsBuilder.Options);
        }
    }
}
