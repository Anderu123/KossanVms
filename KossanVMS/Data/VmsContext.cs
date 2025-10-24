using System;
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
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=newVMS;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // DbSets
        public DbSet<VmsUser> VmsUsers => Set<VmsUser>();

        public DbSet<VisitCategory> VisitCategories => Set<VisitCategory>();
       // public DbSet<VisitPurpose> VisitPurposes => Set<VisitPurpose>();
        public DbSet<VisitBranch> VisitBranches => Set<VisitBranch>();
        public DbSet<VisitorCompany> VisitorCompanies => Set<VisitorCompany>();

        public DbSet<Visitor> Visitors => Set<Visitor>();
        public DbSet<VisitorContact> VisitorContacts => Set<VisitorContact>();
        public DbSet<VisitorPhoto> VisitorPhotos => Set<VisitorPhoto>();
        public DbSet<VisitorAffiliation> VisitorAffiliations => Set<VisitorAffiliation>();

        public DbSet<VisitorCategoryLink> VisitorCategoryLinks => Set<VisitorCategoryLink>();
       // public DbSet<VisitorPurposeLink> VisitorPurposeLinks => Set<VisitorPurposeLink>();
        public DbSet<VisitorBranchLink> VisitorBranchLinks => Set<VisitorBranchLink>();

        public DbSet<VisitRecord> VisitRecords => Set<VisitRecord>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);

            // ENUMS -> byte (saves space and keeps values stable)
            b.Entity<Visitor>().Property(v => v.IdType).HasConversion<byte>();
            //b.Entity<VisitRecord>().Property(v => v.InContainer).HasConversion<byte>();
            //b.Entity<VisitRecord>().Property(v => v.OutContainer).HasConversion<byte>();

            // Masters uniqueness
            b.Entity<VisitCategory>().HasIndex(x => x.CategoryName).IsUnique();
           // b.Entity<VisitPurpose>().HasIndex(x => x.PurposeName).IsUnique();
            b.Entity<VisitBranch>().HasIndex(x => x.BranchName).IsUnique();

            // Visitors uniqueness (same person by ID type+number)
            b.Entity<Visitor>().HasIndex(x => new { x.IdType, x.IdNo }).IsUnique();

            // ----- 1:1s -----
            // Visitor <-> Contact
            b.Entity<Visitor>()
                .HasOne(v => v.Contact)
                .WithOne(c => c.Visitor)
                .HasForeignKey<VisitorContact>(c => c.VisitorNo)
                .OnDelete(DeleteBehavior.Cascade);
            b.Entity<VisitorContact>().HasIndex(c => c.VisitorNo).IsUnique();

            // Visitor <-> Photo
            b.Entity<Visitor>()
                .HasOne(v => v.Photo)
                .WithOne(p => p.Visitor)
                .HasForeignKey<VisitorPhoto>(p => p.VisitorNo)
                .OnDelete(DeleteBehavior.Cascade);
            b.Entity<VisitorPhoto>().HasIndex(p => p.VisitorNo).IsUnique();

            // (Remove any mapping related to VisitorBlackList entity — you’re using a bool now.)

            // ----- M:N with payload (explicit link entities) -----
            // VisitorCategoryLink
            b.Entity<VisitorCategoryLink>()
                .HasOne(x => x.Visitor).WithMany(v => v.VisitorCategories)
                .HasForeignKey(x => x.VisitorNo).OnDelete(DeleteBehavior.Cascade);
            b.Entity<VisitorCategoryLink>()
                .HasOne(x => x.Category).WithMany()
                .HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.Restrict);
            b.Entity<VisitorCategoryLink>()
                .HasIndex(x => new { x.VisitorNo, x.CategoryID }).IsUnique();

            // VisitorPurposeLink
            //b.Entity<VisitorPurposeLink>()
            //    .HasOne(x => x.Visitor).WithMany(v => v.VisitorPurposes)
            //    .HasForeignKey(x => x.VisitorNo).OnDelete(DeleteBehavior.Cascade);
            //b.Entity<VisitorPurposeLink>()
            //    .HasOne(x => x.Purpose).WithMany()
            //    .HasForeignKey(x => x.PurposeID).OnDelete(DeleteBehavior.Restrict);
            //b.Entity<VisitorPurposeLink>()
            //    .HasIndex(x => new { x.VisitorNo, x.PurposeID }).IsUnique();

            // VisitorBranchLink
            b.Entity<VisitorBranchLink>()
                .HasOne(x => x.Visitor).WithMany(v => v.VisitorBranches)
                .HasForeignKey(x => x.VisitorNo).OnDelete(DeleteBehavior.Cascade);
            b.Entity<VisitorBranchLink>()
                .HasOne(x => x.Branch).WithMany()
                .HasForeignKey(x => x.BranchID).OnDelete(DeleteBehavior.Restrict);
            b.Entity<VisitorBranchLink>()
                .HasIndex(x => new { x.VisitorNo, x.BranchID }).IsUnique();

            // ----- Affiliation (M:N with payload) -----
            b.Entity<VisitorAffiliation>()
                .HasOne(a => a.Visitor).WithMany(v => v.VisitorAffiliations)
                .HasForeignKey(a => a.VisitorNo).OnDelete(DeleteBehavior.Cascade);
            b.Entity<VisitorAffiliation>()
                .HasOne(a => a.VisitorCompany).WithMany()
                .HasForeignKey(a => a.CompanyID).OnDelete(DeleteBehavior.Restrict);
            b.Entity<VisitorAffiliation>()
                .HasIndex(a => new { a.VisitorNo, a.CompanyID, a.ValidFrom });

            // ----- VisitRecord (1:N) -----
            // Assuming you added VisitRecord.VisitRecordID as [Key]
            b.Entity<VisitRecord>()
                .HasOne(vr => vr.Visitor).WithMany(v => v.VisitRecords)
                .HasForeignKey(vr => vr.VisitorNo)
                .OnDelete(DeleteBehavior.Restrict);
            b.Entity<VisitRecord>()
                .HasOne(vr => vr.Branch).WithMany()
                .HasForeignKey(vr => vr.BranchID)
                .OnDelete(DeleteBehavior.Restrict);
            //b.Entity<VisitRecord>()
            //    .HasOne(vr => vr.Purpose).WithMany()
            //    .HasForeignKey(vr => vr.PurposeID)
            //    .OnDelete(DeleteBehavior.SetNull);
            b.Entity<VisitRecord>()
                .HasOne(vr => vr.Category).WithMany()
                .HasForeignKey(vr => vr.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);
            b.Entity<VisitRecord>()
                .HasIndex(vr => new { vr.VisitorNo, vr.InTime });
            b.Entity<VisitRecord>()
                .HasOne(vr =>vr.Company).WithMany()
                .HasForeignKey(vr => vr.CompanyID).OnDelete(DeleteBehavior.SetNull);
            b.Entity<VisitRecord>()
                .HasOne(vr => vr.RegisterType).WithMany()
                .HasForeignKey(vr => vr.RegisterTypeID).OnDelete(DeleteBehavior.SetNull);
            b.Entity<VisitRecord>().HasKey(vr =>vr.VisitRecordID);
            // ----- Audit defaults (CreatedDate / UpdatedDate on VmsAuditEntity) -----
            foreach (var et in b.Model.GetEntityTypes())
            {
                if (typeof(VmsAuditEntity).IsAssignableFrom(et.ClrType))
                {
                    b.Entity(et.ClrType).Property("CreatedDate")
                        .HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd();
                    b.Entity(et.ClrType).Property("UpdatedDate")
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
 