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
                    "Server=(localdb)\\MSSQLLocalDB;Database=ktc;Trusted_Connection=True;TrustServerCertificate=True");
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // =========================
            // Visitor (principal)
            // =========================
            modelBuilder.Entity<Visitor>(b =>
            {
                // Keys
                b.HasKey(v => v.VisitorNo);
                b.Property(v => v.VisitorNo).HasColumnOrder(0);

                b.Property(v => v.IdNo).HasMaxLength(100).IsRequired();
                b.HasAlternateKey(v => v.IdNo).HasName("AK_visitors_id_no");
                b.Property(v => v.IdNo).HasColumnOrder(1);

                // Business columns
                b.Property(v => v.IdType).HasColumnOrder(2);
                b.Property(v => v.FullName).HasMaxLength(150).IsRequired().HasColumnOrder(3);
                b.Property(v => v.CompanyName).HasColumnOrder(4);
                b.Property(v => v.ExpiryDate).HasColumnOrder(5);
                b.Property(v => v.BlackList).HasColumnOrder(6);
                // audit columns (from VmsAuditEntity) left without explicit order so they come last
            });

            // =========================
            // VisitCategory
            // =========================
            modelBuilder.Entity<VisitCategory>(b =>
            {
                b.HasKey(x => x.CategoryID);
                b.Property(x => x.CategoryID).HasColumnOrder(0);
                b.Property(x => x.CategoryName).HasMaxLength(100).IsRequired().HasColumnOrder(1);
                b.Property(x => x.CategoryDescription).HasMaxLength(300).HasColumnOrder(2);
                b.Property(x => x.CategoryStatus).HasColumnOrder(3);
                b.Property(x => x.CategoryContract).HasColumnOrder(4);
            });

            // =========================
            // VisitBranch
            // =========================
            modelBuilder.Entity<VisitBranch>(b =>
            {
                b.HasKey(x => x.BranchID);
                b.Property(x => x.BranchID).HasColumnOrder(0);
                b.Property(x => x.BranchName).HasMaxLength(100).IsRequired().HasColumnOrder(1);
                b.Property(x => x.BranchDescription).HasMaxLength(300).HasColumnOrder(2);
                b.Property(x => x.BranchStatus).HasColumnOrder(3);
                b.Property(x => x.BranchConnectionString).HasColumnOrder(4);
            });

            // =========================
            // RegisterType
            // =========================
            modelBuilder.Entity<RegisterType>(b =>
            {
                b.HasKey(x => x.RegisterTypeID);
                b.Property(x => x.RegisterTypeID).HasColumnOrder(0);
                b.Property(x => x.RegisterTypeName).IsRequired().HasColumnOrder(1);
                b.Property(x => x.RegisterUserRole).IsRequired().HasColumnOrder(2);
            });

            // =========================
            // VisitorCompany
            // =========================
            modelBuilder.Entity<VisitorCompany>(b =>
            {
                b.HasKey(x => x.CompanyID);
                b.Property(x => x.CompanyID).HasColumnOrder(0);
                b.Property(x => x.CompanyName).HasMaxLength(100).HasColumnOrder(1);
                b.Property(x => x.RegistrationNo).HasMaxLength(50).HasColumnOrder(2);
                b.Property(x => x.CompanyAddress).HasColumnOrder(3);
            });

            // =========================
            // VisitorContact (1:1 via IdNo)
            // =========================
            modelBuilder.Entity<VisitorContact>(b =>
            {
                b.HasKey(x => x.ContactID);
                b.Property(x => x.ContactID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo (unique in 1:1)
                b.HasOne(x => x.Visitor)
                 .WithOne(v => v.Contact)
                 .HasForeignKey<VisitorContact>(x => x.IdNo)
                 .HasPrincipalKey<Visitor>(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.Address).HasColumnOrder(2);
                b.Property(x => x.City).HasColumnOrder(3);
                b.Property(x => x.State).HasColumnOrder(4);
                b.Property(x => x.PostCode).HasColumnOrder(5);
                b.Property(x => x.Tel).HasColumnOrder(6);
            });

            // =========================
            // VisitorPhoto (1:1 via IdNo)
            // =========================
            modelBuilder.Entity<VisitorPhoto>(b =>
            {
                b.HasKey(x => x.PhotoID);
                b.Property(x => x.PhotoID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo (unique in 1:1)
                b.HasOne(x => x.Visitor)
                 .WithOne(v => v.Photo)
                 .HasForeignKey<VisitorPhoto>(x => x.IdNo)
                 .HasPrincipalKey<Visitor>(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CapturePhotoPath).HasColumnOrder(2);
                b.Property(x => x.UploadPhotoPath).HasColumnOrder(3);
                b.Property(x => x.PhotoURL).HasMaxLength(255).IsRequired().HasColumnOrder(4);
                b.Property(x => x.CaptureDate).HasColumnOrder(5);
                b.Property(x => x.UploadDate).HasColumnOrder(6);
            });

            // =========================
            // VisitorAffiliation (many-to-one to Visitor via IdNo; and to VisitorCompany)
            // =========================
            modelBuilder.Entity<VisitorAffiliation>(b =>
            {
                b.HasKey(x => x.AffiliationID);
                b.Property(x => x.AffiliationID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.Visitor)
                 .WithMany(v => v.VisitorAffiliations)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CompanyID).HasColumnOrder(2); // FK to VisitorCompany
                b.HasOne(x => x.VisitorCompany)
                 .WithMany()
                 .HasForeignKey(x => x.CompanyID)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.Relationship).HasMaxLength(50).HasColumnOrder(3);
                b.Property(x => x.ValidFrom).HasColumnOrder(4);
                b.Property(x => x.ValidTo).HasColumnOrder(5);
            });

            // =========================
            // VisitorCategoryLink (link: Id, IdNo, CategoryID)
            // =========================
            modelBuilder.Entity<VisitorCategoryLink>(b =>
            {
                b.HasKey(x => x.ID);
                b.Property(x => x.ID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.Visitor)
                 .WithMany(v => v.VisitorCategories)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CategoryID).HasColumnOrder(2); // FK to VisitCategory
                b.HasOne(x => x.Category)
                 .WithMany()
                 .HasForeignKey(x => x.CategoryID)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // =========================
            // VisitorBranchLink (link: Id, IdNo, BranchID)
            // =========================
            modelBuilder.Entity<VisitorBranchLink>(b =>
            {
                b.HasKey(x => x.ID);
                b.Property(x => x.ID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.Visitor)
                 .WithMany(v => v.VisitorBranches)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.BranchID).HasColumnOrder(2); // FK to VisitBranch
                b.HasOne(x => x.Branch)
                 .WithMany()
                 .HasForeignKey(x => x.BranchID)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // =========================
            // VisitRecord (facts: Id, IdNo, BranchID, then the rest)
            // =========================
            modelBuilder.Entity<VisitRecord>(b =>
            {
                b.HasKey(x => x.VisitRecordID);
                b.Property(x => x.VisitRecordID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.Visitor)
                 .WithMany(v => v.VisitRecords)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.IdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.BranchID).HasColumnOrder(2); // FK to VisitBranch
                b.HasOne(x => x.Branch).WithMany()
                 .HasForeignKey(x => x.BranchID)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CategoryID).HasColumnOrder(3);
                b.HasOne(x => x.Category).WithMany()
                 .HasForeignKey(x => x.CategoryID)
                 .OnDelete(DeleteBehavior.Restrict);
                //b.Property(x => x.CompanyID).HasColumnOrder(4);
                //b.HasOne(x => x.Company).WithMany()
                // .HasForeignKey(x => x.CompanyID)
                // .OnDelete(DeleteBehavior.Restrict);
                //b.Property(x => x.CompanyID).HasColumnOrder(4);
                //b.HasOne(x => x.Company).WithMany()
                // .HasForeignKey(x => x.CompanyID)
                // .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.RegisterTypeID).HasColumnOrder(5);
                b.HasOne(x => x.RegisterType).WithMany()
                 .HasForeignKey(x => x.RegisterTypeID)
                 .OnDelete(DeleteBehavior.Restrict);

                // Time & misc details
                b.Property(x => x.InTime).HasColumnOrder(6);
                b.Property(x => x.OutTime).HasColumnOrder(7);
                b.Property(x => x.VehicleNo).HasColumnOrder(8);
                b.Property(x => x.InRemarks).HasColumnOrder(9);
                b.Property(x => x.InPhotoPath).HasColumnOrder(10);
                b.Property(x => x.TagNo).HasColumnOrder(11);
                b.Property(x => x.GatePass).HasColumnOrder(12);
                b.Property(x => x.VisitPerson).HasColumnOrder(13);
                b.Property(x => x.DONo).HasColumnOrder(14);
                b.Property(x => x.BodyTemperature).HasPrecision(4, 1).HasColumnOrder(15);
                b.Property(x => x.ExpiryDate).HasColumnOrder(16);
            });
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
 