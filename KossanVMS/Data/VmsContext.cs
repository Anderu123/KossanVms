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

        public VmsContext(DbContextOptions<VmsContext> options) :base(options) { }
        public VmsContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=newVMS;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<VmsUser> VmsUsers { get; set; }
        public DbSet<VisitCategory> VisitCategories{ get; set; }
        public DbSet<VisitBranch> VisitBranches{ get; set; }
        public DbSet<Visitor> Visitors{ get; set; }
        public DbSet<VisitorBlackList> VisitorBlackList{ get; set; }
        public DbSet<VisitorCompany> VisitorCompanies { get; set; } 
        public DbSet<VisitorContact> VisitorContacts { get; set; }  
        public DbSet<VisitorPhoto> VisitorPhotos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
            modelBuilder.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();
            modelBuilder.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            //modelBuilder.Entity<Visitor>().HasIndex(x => x.ICNo).IsUnique();

            modelBuilder.Entity<VisitorContact>().HasOne(x => x.Visitor);
            modelBuilder.Entity<VisitorPhoto>().HasOne(x => x.Visitor);
            modelBuilder.Entity<VisitorBlackList>()
    .HasOne(vb => vb.Visitor).WithOne(v => v.BlackList)     // or .WithOne() if you didn’t add the nav
    .HasForeignKey<VisitorBlackList>(vb => vb.VisitorID);
            // VisitRecord relationships
            modelBuilder.Entity<VisitRecord>()
                .HasOne(v => v.Visitor)
                .WithMany() // or .WithMany(nav => nav.VisitRecords) if you add a collection on Visitor
                .HasForeignKey(v => v.VisitorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VisitRecord>()
                .HasOne(v => v.Branch)
                .WithMany() // or .WithMany(nav => nav.VisitRecords)
                .HasForeignKey(v => v.BranchID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VisitRecord>()
                .HasOne(v => v.Purpose)
                .WithMany()
                .HasForeignKey(v => v.PurposeID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<VisitRecord>()
                .HasOne(v => v.Category)
                .WithMany()
                .HasForeignKey(v => v.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);
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
