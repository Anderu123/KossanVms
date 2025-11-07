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

        public DbSet<Category> VisitCategories => Set<Category>();
       // public DbSet<VisitPurpose> VisitPurposes => Set<VisitPurpose>();
        public DbSet<Branch> VisitBranches => Set<Branch>();
        //blic DbSet<Company> VisitorCompanies => Set<Company>();
        public DbSet<Purpose> VisitPurposes => Set<Purpose>();
        public DbSet<Visitor> Visitors => Set<Visitor>();
        public DbSet<Contact> VisitorContacts => Set<Contact>();
        public DbSet<Photo> VisitorPhotos => Set<Photo>();
        //public DbSet<VisitorAffiliation> VisitorAffiliations => Set<VisitorAffiliation>();

        public DbSet<CategoryLink> VisitorCategoryLinks => Set<CategoryLink>();
       // public DbSet<VisitorPurposeLink> VisitorPurposeLinks => Set<VisitorPurposeLink>();
        public DbSet<BranchLink> VisitorBranchLinks => Set<BranchLink>();

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

                b.Property(v => v.VisitorIdNo).HasMaxLength(100).IsRequired();
                b.HasAlternateKey(v => v.VisitorIdNo).HasName("AK_visitors_id_no");
                b.Property(v => v.VisitorIdNo).HasColumnOrder(1);

                // Business columns
                b.Property(v => v.VisitorIdType).HasColumnOrder(2);
                b.Property(v => v.VisitorFullName).HasMaxLength(150).IsRequired().HasColumnOrder(3);
                //b.Property(v => v.CompanyName).HasColumnOrder(4);
                b.Property(v => v.VisitorExpiryDate).HasColumnOrder(5);
                b.Property(v => v.VisitorBlackList).HasColumnOrder(6);
                // audit columns (from VmsAuditEntity) left without explicit order so they come last
            });
            modelBuilder.Entity<VmsUser>(b =>
            {
                // Explicitly map the table name and schema based on your SQL query
                b.ToTable("vms_users", "dbo");

                // Explicitly map the audit properties to their snake_case column names
                // This resolves the "Invalid column name 'updated_date'" error.
                // Assuming properties are CreatedDate/UpdatedDate from VmsAuditEntity
                b.Property(u => u.CreatedDate).HasColumnName("created_date");
                b.Property(u => u.UpdatedDate).HasColumnName("updated_date");
                b.Property(u => u.CreatedBy).HasColumnName("created_by");
                b.Property(u => u.UpdatedBy).HasColumnName("updated_by");

                // Assuming other user properties also follow snake_case convention, map them here:
                // Note: You must replace 'UserName' with the actual property name in VmsUser.cs
                // b.Property(u => u.UserName).HasColumnName("user_name");
                // b.Property(u => u.PasswordHash).HasColumnName("password_hash");
                // b.Property(u => u.PasswordSalt).HasColumnName("password_salt");
                // b.Property(u => u.UserRole).HasColumnName("user_role");
                // b.Property(u => u.Status).HasColumnName("status");
            });
            // =========================
            // VisitCategory
            // =========================
            modelBuilder.Entity<Category>(b =>
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
            modelBuilder.Entity<Branch>(b =>
            {
                b.HasKey(x => x.BranchID);
                b.Property(x => x.BranchID).HasColumnOrder(0);
                b.Property(x => x.BranchName).HasMaxLength(100).IsRequired().HasColumnOrder(1);
                b.Property(x => x.BranchDescription).HasMaxLength(300).HasColumnOrder(2);
                b.Property(x => x.BranchStatus).HasColumnOrder(3);
                b.Property(x => x.BranchConnectionString).HasColumnOrder(4);
            });
            //====================================
            //VisitorPurpose
            //====================================

            modelBuilder.Entity<Purpose>(b =>
            {
                b.HasKey(x => x.PurposeID);
                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1);
                b.HasOne(x => x.Visitor)
                .WithOne(x => x.VisitorPurpose)
                .HasForeignKey<Purpose>(x => x.IdNo)
                .HasPrincipalKey<Visitor>(x => x.VisitorIdNo)
                .OnDelete(DeleteBehavior.Restrict);
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
            //modelBuilder.Entity<VisitorCompany>(b =>
            //{
            //    b.HasKey(x => x.CompanyID);
            //    b.Property(x => x.CompanyID).HasColumnOrder(0);
            //    b.Property(x => x.CompanyName).HasMaxLength(100).HasColumnOrder(1);
            //    b.Property(x => x.RegistrationNo).HasMaxLength(50).HasColumnOrder(2);
            //    b.Property(x => x.CompanyAddress).HasColumnOrder(3);
            //});

            // =========================
            // VisitorContact (1:1 via IdNo)
            // =========================
            modelBuilder.Entity<Contact>(b =>
            {
                b.HasKey(x => x.ContactID);
                b.Property(x => x.ContactID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo (unique in 1:1)
                b.HasOne(x => x.Visitor)
                 .WithOne(v => v.VisitorContact)
                 .HasForeignKey<Contact>(x => x.IdNo)
                 .HasPrincipalKey<Visitor>(v => v.VisitorIdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.ContactAddress).HasColumnOrder(2);
                b.Property(x => x.ContactCity).HasColumnOrder(3);
                b.Property(x => x.ContactState).HasColumnOrder(4);
                b.Property(x => x.ContactPostCode).HasColumnOrder(5);
                b.Property(x => x.ContactTel).HasColumnOrder(6);
            });

            // =========================
            // VisitorPhoto (1:1 via IdNo)
            // =========================
            modelBuilder.Entity<Photo>(b =>
            {
                b.HasKey(x => x.PhotoID);
                b.Property(x => x.PhotoID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo (unique in 1:1)
                b.HasOne(x => x.Visitor)
                 .WithOne(v => v.VisitorPhoto)
                 .HasForeignKey<Photo>(x => x.IdNo)
                 .HasPrincipalKey<Visitor>(v => v.VisitorIdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.PhotoCapturePath).HasColumnOrder(2);
                b.Property(x => x.PhotoUploadPath).HasColumnOrder(3);
                b.Property(x => x.PhotoURL).HasMaxLength(255).IsRequired().HasColumnOrder(4);
                b.Property(x => x.PhotoCaptureDate).HasColumnOrder(5);
                b.Property(x => x.PhotoUploadDate).HasColumnOrder(6);
            });

            // =========================
            // VisitorAffiliation (many-to-one to Visitor via IdNo; and to VisitorCompany)
            // =========================
            //modelBuilder.Entity<VisitorAffiliation>(b =>
            //{
            //    b.HasKey(x => x.AffiliationID);
            //    b.Property(x => x.AffiliationID).HasColumnOrder(0);

            //    b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
            //    b.HasOne(x => x.Visitor)
            //     .WithMany(v => v.VisitorAffiliations)
            //     .HasForeignKey(x => x.IdNo)
            //     .HasPrincipalKey(v => v.IdNo)
            //     .OnDelete(DeleteBehavior.Restrict);

            //    b.Property(x => x.CompanyID).HasColumnOrder(2); // FK to VisitorCompany
            //    b.HasOne(x => x.VisitorCompany)
            //     .WithMany()
            //     .HasForeignKey(x => x.CompanyID)
            //     .OnDelete(DeleteBehavior.Restrict);

            //    b.Property(x => x.Relationship).HasMaxLength(50).HasColumnOrder(3);
            //    b.Property(x => x.ValidFrom).HasColumnOrder(4);
            //    b.Property(x => x.ValidTo).HasColumnOrder(5);
            //});

            // =========================
            // VisitorCategoryLink (link: Id, IdNo, CategoryID)
            // =========================
            modelBuilder.Entity<CategoryLink>(b =>
            {
                b.HasKey(x => x.CategoryLinkID);
                b.Property(x => x.CategoryLinkID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.CategoryLinkVisitor)
                 .WithMany(v => v.VisitorCategories)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.VisitorIdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CategoryID).HasColumnOrder(2); // FK to VisitCategory
                b.HasOne(x => x.CategoryLinkCategory)
                 .WithMany()
                 .HasForeignKey(x => x.CategoryID)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // =========================
            // VisitorBranchLink (link: Id, IdNo, BranchID)
            // =========================
            modelBuilder.Entity<BranchLink>(b =>
            {
                b.HasKey(x => x.BranchLinkID);
                b.Property(x => x.BranchLinkID).HasColumnOrder(0);

                b.Property(x => x.IdNo).HasMaxLength(100).IsRequired().HasColumnOrder(1); // FK to Visitor.IdNo
                b.HasOne(x => x.BranchLinkVisitor)
                 .WithMany(v => v.VisitorBranches)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.VisitorIdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.BranchID).HasColumnOrder(2); // FK to VisitBranch
                b.HasOne(x => x.BranchLinkBranch)
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
                b.HasOne(x => x.VisitRecordVisitor)
                 .WithMany(v => v.VisitRecords)
                 .HasForeignKey(x => x.IdNo)
                 .HasPrincipalKey(v => v.VisitorIdNo)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.BranchID).HasColumnOrder(2); // FK to VisitBranch
                b.HasOne(x => x.VisitRecordBranch).WithMany()
                 .HasForeignKey(x => x.BranchID)
                 .OnDelete(DeleteBehavior.Restrict);

                b.Property(x => x.CategoryID).HasColumnOrder(3);
                b.HasOne(x => x.VisitRecordCategory).WithMany()
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
                b.HasOne(x => x.VisitRecordRegisterType).WithMany()
                 .HasForeignKey(x => x.RegisterTypeID)
                 .OnDelete(DeleteBehavior.Restrict);

                // Time & misc details
                b.Property(x => x.VisitRecordInTime).HasColumnOrder(6);
                b.Property(x => x.VisitRecordOutTime).HasColumnOrder(7);
                b.Property(x => x.VisitRecordVehicleNo).HasColumnOrder(8);
                b.Property(x => x.VisitRecordRemarks).HasColumnOrder(9);
                b.Property(x => x.VisitRecordPhotoPath).HasColumnOrder(10);
                b.Property(x => x.VisitRecordTagNo).HasColumnOrder(11);
                b.Property(x => x.VisitRecordGatePass).HasColumnOrder(12);
                b.Property(x => x.VisitRecordVisitPerson).HasColumnOrder(13);
                b.Property(x => x.VisitRecordDONo).HasColumnOrder(14);
                b.Property(x => x.VisitRecordBodyTemperature).HasPrecision(4, 1).HasColumnOrder(15);
                b.Property(x => x.VisitRecordExpiryDate).HasColumnOrder(16);
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
 