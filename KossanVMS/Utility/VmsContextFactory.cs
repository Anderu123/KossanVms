using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using KossanVMS.Data;

namespace KossanVMS.Utility
{
    public class VmsContextFactory : IDesignTimeDbContextFactory<VmsContext>
    {
        public VmsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VmsContext>();
            var connStr = ConfigurationManager
              .ConnectionStrings["DbConnStr"]?
              .ConnectionString
              ?? "Server=(localdb)\\MSSQLLocalDB;Database=newVMS;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer (connStr);

            return new VmsContext(optionsBuilder.Options);
        }
    }
}
