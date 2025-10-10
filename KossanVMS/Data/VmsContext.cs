using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KossanVMS.Data
{
    public class VmsContext : DbContext
    {
        public VmsContext(DbContextOptions<VmsContext> options) : base(options) { }
        public VmsContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=newVMS;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<VmsUser> VmsUsers => Set<VmsUser>();
        public DbSet<VisitCategory> VisitCategories => Set<VisitCategory>();
        public DbSet<VisitPurpose> VisitPurposes => Set<VisitPurpose>();
        public DbSet<VisitBranch> VisitBranches => Set<VisitBranch>();
        public DbSet<VisitorCompany> VisitorCompanies => Set<VisitorCompany>();

        public DbSet<Visitor> Visitors => Set<Visitor>();
        public DbSet<VisitorContact> VisitorContacts => Set<VisitorContact>();
        public DbSet<VisitorPhoto> VisitorPhotos => Set<VisitorPhoto>();
        public DbSet<VisitorBlackList> VisitorBlackList => Set<VisitorBlackList>();
        public DbSet<VisitorAffiliation> VisitorAffiliations => Set<VisitorAffiliation>();

        public DbSet<VisitorCategoryLink> VisitorCategoryLinks => Set<VisitorCategoryLink>();
        public DbSet<VisitorPurposeLink> VisitorPurposeLinks => Set<VisitorPurposeLink>();

        public DbSet<VisitRecord> VisitRecords => Set<VisitRecord>();

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            // Masters unique
            model.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
            model.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            model.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();

            // Visitors
            model.Entity<Visitor>().HasIndex(x => new { x.IdType, x.IdNo }).IsUnique();

            // Junction uniqueness
            model.Entity<VisitorCategoryLink>()
                 .HasIndex(x => new { x.VisitorID, x.CategoryID }).IsUnique();

            model.Entity<VisitorPurposeLink>()
                 .HasIndex(x => new { x.VisitorID, x.PurposeID }).IsUnique();

            // Junction FKs
            model.Entity<VisitorCategoryLink>()
                 .HasOne(x => x.Visitor).WithMany(v => v.VisitorCategories)
                 .HasForeignKey(x => x.VisitorID).OnDelete(DeleteBehavior.Cascade);

            model.Entity<VisitorCategoryLink>()
                 .HasOne(x => x.Category).WithMany()
                 .HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitorPurposeLink>()
                 .HasOne(x => x.Visitor).WithMany(v => v.VisitorPurposes)
                 .HasForeignKey(x => x.VisitorID).OnDelete(DeleteBehavior.Cascade);

            model.Entity<VisitorPurposeLink>()
                 .HasOne(x => x.Purpose).WithMany()
                 .HasForeignKey(x => x.PurposeID).OnDelete(DeleteBehavior.Restrict);

            // 1:1s explicit dependents
            model.Entity<Visitor>()
                .HasOne(v => v.Contact)
                .WithOne(c => c.Visitor)
                .HasForeignKey<VisitorContact>(c => c.VisitorID)
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

            // Affiliation (M:N with payload)
            model.Entity<VisitorAffiliation>()
                .HasOne(a => a.Visitor).WithMany(v => v.VisitorAffiliations)
                .HasForeignKey(a => a.VisitorID).OnDelete(DeleteBehavior.Cascade);

            model.Entity<VisitorAffiliation>()
                .HasOne(a => a.VisitorCompany).WithMany()
                .HasForeignKey(a => a.CompanyID).OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitorAffiliation>()
                .HasIndex(a => new { a.VisitorID, a.CompanyID, a.ValidFrom });

            // VisitRecord (1:N) + snapshot lookups
            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Visitor).WithMany(v => v.VisitRecords)
                .HasForeignKey(vr => vr.VisitorID)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Branch).WithMany()
                .HasForeignKey(vr => vr.BranchID)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Purpose).WithMany()
                .HasForeignKey(vr => vr.PurposeID)
                .OnDelete(DeleteBehavior.SetNull);

            model.Entity<VisitRecord>()
                .HasOne(vr => vr.Category).WithMany()
                .HasForeignKey(vr => vr.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);

            // Audit defaults
            foreach (var et in model.Model.GetEntityTypes())
            {
                if (typeof(VmsAuditEntity).IsAssignableFrom(et.ClrType))
                {
                    model.Entity(et.ClrType).Property("CreatedDate")
                        .HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd();
                    model.Entity(et.ClrType).Property("UpdatedDate")
                        .HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate();
                }
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

