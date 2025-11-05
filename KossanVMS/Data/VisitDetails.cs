using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KossanVMS.Data
{
    public enum ContainerState : byte { None = 0, Empty = 1, Laden = 2 }
    public enum VisitStatus : byte { In = 1, Out = 2, Cancelled = 9 }
    public enum IdType : byte { IC = 0, Passport = 1 }

    // ===== Masters =====

    [Table("visit_categories")]
    public class VisitCategory : VmsAuditEntity
    {
        [Key, Column("category_id")] public int CategoryID { get; set; }
        [Required, MaxLength(100), Column("category_name")] public string CategoryName { get; set; } = null!;
        [MaxLength(300), Column("category_description")] public string? CategoryDescription { get; set; }
        [Column("category_status")] public bool CategoryStatus { get; set; }
        [Column("category_contract")] public bool CategoryContract { get; set; }
    }

    [Table("visit_branches")]
    public class VisitBranch : VmsAuditEntity
    {
        [Key, Column("branch_id")] public int BranchID { get; set; }
        [Required, MaxLength(100), Column("branch_name")] public string BranchName { get; set; } = null!;
        [MaxLength(300), Column("branch_description")] public string? BranchDescription { get; set; }
        [Column("branch_status")] public bool BranchStatus { get; set; }
        [Column("branch_connection_string")] public string BranchConnectionString { get; set; } = null!;
    }

    [Table("register_types")]
    public class RegisterType : VmsAuditEntity
    {
        [Key, Column("register_type_id")] public int RegisterTypeID { get; set; }
        [Required, Column("register_type_name")] public string RegisterTypeName { get; set; } = null!;
        [Required, Column("register_user_role")] public string RegisterUserRole { get; set; } = null!;
    }

    [Table("visitor_companies")]
    public class VisitorCompany : VmsAuditEntity
    {
        [Key, Column("company_id")] public int CompanyID { get; set; }
        [MaxLength(100), Column("company_name")] public string? CompanyName { get; set; }
        [MaxLength(50), Column("registration_no")] public string? RegistrationNo { get; set; }
        [Column("company_address")] public string? CompanyAddress { get; set; }
    }

    // ===== Core (Visitor + links) =====

    [Table("visitors")]
    public class Visitor : VmsAuditEntity
    {
        // Keep numeric PK
        [Key, Column("visitor_no")] public int VisitorNo { get; set; }

        [Column("id_type")] public IdType IdType { get; set; }

        // Business key used as principal for all FKs below
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

        [Required, MaxLength(150), Column("full_name")] public string FullName { get; set; } = null!;

        [Column("expiry_date")] public DateTime? ExpiryDate { get; set; }
        [Column("black_list")] public bool BlackList { get; set; } = false;
        [Column("company_name")] public string? CompanyName { get; set; }
        public VisitorContact? Contact { get; set; }
        public VisitorPhoto? Photo { get; set; }
        public ICollection<VisitorAffiliation> VisitorAffiliations { get; set; } 
        public ICollection<VisitorCategoryLink> VisitorCategories { get; set; } 
        public ICollection<VisitorBranchLink> VisitorBranches { get; set; } 
        public ICollection<VisitRecord> VisitRecords { get; set; } 
    }

    [Table("visitor_contacts")]
    public class VisitorContact : VmsAuditEntity
    {
        [Key, Column("contact_id")] public int ContactID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;
        public Visitor Visitor { get; set; } = null!;

        [Column("address")] public string? Address { get; set; }
        [Column("city")] public string? City { get; set; }
        [Column("state")] public string? State { get; set; }
        [Column("postcode")] public string? PostCode { get; set; }
        [Column("tel")] public string? Tel { get; set; }
    }

    [Table("visitor_photos")]
    public class VisitorPhoto : VmsAuditEntity
    {
        [Key, Column("photo_id")] public int PhotoID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;
        public Visitor Visitor { get; set; } = null!;

        [Column("capture_photo_path")] public string CapturePhotoPath { get; set; } = null!;
        [Column("upload_photo_path")] public string UploadPhotoPath { get; set; } = null!;
        [Required, MaxLength(255), Column("photo_url")] public string PhotoURL { get; set; } = null!;
        [Column("capture_date")] public DateTime CaptureDate { get; set; } = DateTime.UtcNow;
        [Column("upload_date")] public DateTime UploadDate { get; set; } = DateTime.UtcNow;
    }

    [Table("visitor_affiliations")]
    public class VisitorAffiliation : VmsAuditEntity
    {
        [Key, Column("affiliation_id")] public int AffiliationID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

        [Column("company_id")] public int CompanyID { get; set; }
        [MaxLength(50), Column("relationship")] public string? Relationship { get; set; } = "Visitor";
        [Column("valid_from")] public DateTime? ValidFrom { get; set; }
        [Column("valid_to")] public DateTime? ValidTo { get; set; }

        public Visitor Visitor { get; set; } = null!;
        public VisitorCompany VisitorCompany { get; set; } = null!;
    }

    [Table("visitor_category_links")]
    public class VisitorCategoryLink : VmsAuditEntity
    {
        [Key] public int ID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

        [Column("category_id")] public int CategoryID { get; set; }

        public Visitor Visitor { get; set; } = null!;
        public VisitCategory Category { get; set; } = null!;
    }

    [Table("visitor_branch_links")]
    public class VisitorBranchLink : VmsAuditEntity
    {
        [Key] public int ID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

        [Column("branch_id")] public int BranchID { get; set; }

        public Visitor Visitor { get; set; } = null!;
        public VisitBranch Branch { get; set; } = null!;
    }

    // ===== Visit details =====

    [Table("visit_records")]
    public class VisitRecord : VmsAuditEntity
    {
        [Key, Column("visit_record_id")] public int VisitRecordID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

        [Required, Column("branch_id")] public int? BranchID { get; set; }

        [Column("category_id")] public int? CategoryID { get; set; }
        //[Column("company_id")] public int? CompanyID { get; set; }
        [Column("register_type_id")] public int? RegisterTypeID { get; set; }

        [Column("in_time")] public DateTime InTime { get; set; }
        [Column("out_time")] public DateTime? OutTime { get; set; }
        [Column("company")] public string? Company { get; set; }
        [Column("vehicle_no")] public string? VehicleNo { get; set; }
        [Column("in_remarks")] public string? InRemarks { get; set; }
        [Column("in_photo_path")] public string? InPhotoPath { get; set; }
        [Column("tag_no")] public string? TagNo { get; set; }
        [Column("gate_pass")] public string? GatePass { get; set; }
        [Column("visit_person")] public string? VisitPerson { get; set; }
        [Column("do_no")] public string? DONo { get; set; }
        [Column("body_temperature")] public decimal? BodyTemperature { get; set; }
        [Column("expiry_date")] public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;

        public RegisterType? RegisterType { get; set; }
        public VisitCategory? Category { get; set; }
        //public VisitorCompany? Company { get; set; }
        public Visitor Visitor { get; set; } = null!;
        public VisitBranch? Branch { get; set; } = null!;
    }
}
