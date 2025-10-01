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
        public DbSet<VisitPurpose> VisitPurposes { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            // 1–1s: declare dependents explicitly
            model.Entity<Visitor>()
                .HasOne(v => v.Contact)
                .WithOne(c => c.Visitor)
                .HasForeignKey<VisitorContact>(c => c.VisitorID)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Visitor>()
                .HasOne(v => v.Company)
                .WithOne(c => c.Visitor)
                .HasForeignKey<VisitorCompany>(c => c.VisitorID)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Visitor>()
                .HasOne(v => v.Photo)
                .WithOne(p => p.Visitor)
                .HasForeignKey<VisitorPhoto>(p => p.VisitorID)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Visitor>()
                .HasOne(v => v.BlackList)
                .WithOne(b => b.Visitor)
                .HasForeignKey<VisitorBlackList>(b => b.VisitorID)
                .OnDelete(DeleteBehavior.Cascade);

            // VisitRecord (many-to-one): keep your delete rules
            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Visitor)
                .WithMany(v => v.VisitRecords)
                .HasForeignKey(vr => vr.VisitorID)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Branch)
                .WithMany()
                .HasForeignKey(vr => vr.BranchID)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Purpose)
                .WithMany()
                .HasForeignKey(vr => vr.PurposeID)
                .OnDelete(DeleteBehavior.SetNull);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Category)
                .WithMany()
                .HasForeignKey(vr => vr.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);

            // Uniques
            model.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();
            model.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
            model.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            model.Entity<Visitor>().HasIndex(x => x.ICNo).IsUnique();

            // Audit defaults (example)
            foreach (var et in model.Model.GetEntityTypes()
                     .Where(t => typeof(VmsAuditEntity).IsAssignableFrom(t.ClrType)))
            {
                model.Entity(et.ClrType).Property("CreatedDate")
                    .HasDefaultValueSql("GETUTCDATE()")
                    .ValueGeneratedOnAdd();

                model.Entity(et.ClrType).Property("UpdatedDate")
                    .HasDefaultValueSql("GETUTCDATE()")
                    .ValueGeneratedOnAddOrUpdate();
            }
        }



        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;
            foreach (var e in ChangeTracker.Entries())
            {
                if (e.Entity is VmsAuditEntity aud)
                {
                    if (e.State == EntityState.Added)
                    {
                        aud.CreatedDate = now;
                        aud.UpdatedDate = now;
                    }
                    else if (e.State == EntityState.Modified)
                    {
                        aud.UpdatedDate = now;
                    }
                }
            }
            return base.SaveChanges();
        }

    }
}
