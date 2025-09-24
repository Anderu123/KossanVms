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
        public DbSet<VisitRecord> VisitRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            // Keys / indexes
            mb.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
            mb.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();
            mb.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            // mb.Entity<Visitor>().HasIndex(x => x.ICNo).IsUnique(); // optional

            // Force EF to use the int PK on Visitor explicitly (avoid any shadow PK)
            mb.Entity<Visitor>(b =>
            {
                b.HasKey(v => v.VisitorID);
                b.Property(v => v.VisitorID).ValueGeneratedOnAdd();
            });

            // 1:1 Contact (dependent has unique FK VisitorID)
            mb.Entity<VisitorContact>(b =>
            {
                b.HasKey(c => c.ContactID);
                b.HasIndex(c => c.VisitorID).IsUnique();
                b.HasOne(c => c.Visitor)
                 .WithOne(v => v.Contact)
                 .HasForeignKey<VisitorContact>(c => c.VisitorID)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // 1:1 Company
            mb.Entity<VisitorCompany>(b =>
            {
                b.HasKey(c => c.CompanyID);
                b.HasIndex(c => c.VisitorID).IsUnique();
                b.HasOne(c => c.Visitor)
                 .WithOne(v => v.Company)
                 .HasForeignKey<VisitorCompany>(c => c.VisitorID)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // 1:1 Photo
            mb.Entity<VisitorPhoto>(b =>
            {
                b.HasKey(p => p.PhotoID);
                b.HasIndex(p => p.VisitorID).IsUnique();
                b.HasOne(p => p.Visitor)
                 .WithOne(v => v.Photo)
                 .HasForeignKey<VisitorPhoto>(p => p.VisitorID)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // 1:1 BlackList (PK=FK pattern)
            mb.Entity<VisitorBlackList>(b =>
            {
                b.HasKey(x => x.VisitorID);
                b.HasOne(x => x.Visitor)
                 .WithOne(v => v.BlackList)   // <- must match the property name on Visitor
                 .HasForeignKey<VisitorBlackList>(x => x.VisitorID)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // Visits 1:many
            mb.Entity<VisitRecord>(b =>
            {
                b.HasKey(r => r.VisitID);
                b.HasOne(r => r.Visitor)
                 .WithMany(v => v.VisitRecords)
                 .HasForeignKey(r => r.VisitorID)
                 .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(r => r.Branch).WithMany().HasForeignKey(r => r.BranchID).OnDelete(DeleteBehavior.Restrict);
                b.HasOne(r => r.Purpose).WithMany().HasForeignKey(r => r.PurposeID).OnDelete(DeleteBehavior.SetNull);
                b.HasOne(r => r.Category).WithMany().HasForeignKey(r => r.CategoryID).OnDelete(DeleteBehavior.SetNull);
            });

            // IMPORTANT: remove any old ambiguous lines like:
            // mb.Entity<VisitorContact>().HasOne(x => x.Visitor);   // <- delete
            // mb.Entity<VisitorPhoto>().HasOne(x => x.Visitor);     // <- delete
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
