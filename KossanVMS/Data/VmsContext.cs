using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KossanVMS.Data
{
    public class VmsContext:DbContext
    {
        public DbSet<VisitCategory> VisitCategories{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
            modelBuilder.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();
            modelBuilder.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            modelBuilder.Entity<Visitor>().HasIndex(x => x.ICNo).IsUnique();

            modelBuilder.Entity<VisitorContact>().HasOne(x => x.Visitor).WithMany(v => v.Contacts).HasForeignKey(x => x.VisitorID);
            modelBuilder.Entity<VisitorPhoto>().HasOne(x => x.Visitor).WithMany(v => v.Photos).HasForeignKey(x => x.VisitorID);
        }

        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;
            foreach(var e in ChangeTracker.Entries())
            {
                if(e.State == EntityState.Modified)
                {
                    if(e.Properties.Any(p => p.Metadata.Name =="UpdateTime"))
                    {
                        e.Property("UpdateTime").CurrentValue = now;
                    }
                }
            }
            return base.SaveChanges();

        }
    }
}
