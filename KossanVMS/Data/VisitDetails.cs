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

    [Table("category")]
    public class Category : VmsAuditEntity
    {
        [Key, Column("c_id")] public int CategoryID { get; set; }
        [Required, MaxLength(100), Column("c_name")] public string CategoryName { get; set; } = null!;
        [MaxLength(300), Column("c_description")] public string? CategoryDescription { get; set; }
        [Column("c_status")] public bool CategoryStatus { get; set; }
        [Column("c_contract")] public bool CategoryContract { get; set; }
    }

    [Table("branch")]
    public class Branch : VmsAuditEntity
    {
        [Key, Column("b_id")] public int BranchID { get; set; }
        [Required, MaxLength(100), Column("b_name")] public string BranchName { get; set; } = null!;
        [MaxLength(300), Column("b_description")] public string? BranchDescription { get; set; }
        [Column("b_status")] public bool BranchStatus { get; set; }
        [Column("b_connection_string")] public string BranchConnectionString { get; set; } = null!;
    }

    [Table("register_type")]
    public class RegisterType : VmsAuditEntity
    {
        [Key, Column("rt_type_id")] public int RegisterTypeID { get; set; }
        [Required, Column("rt_type_name")] public string RegisterTypeName { get; set; } = null!;
        [Required, Column("rt_user_role")] public string RegisterUserRole { get; set; } = null!;
    }

    // ===== Core (Visitor + links) =====

    [Table("visitor")]
    public class Visitor : VmsAuditEntity
    {
        // Keep numeric PK
        [Key, Column("v_no")] public int VisitorNo { get; set; }

        [Column("v_id_type")] public IdType VisitorIdType { get; set; }
       // [Column("v_purpose_id")] public int? PurposeID { get; set; }
        // Business key used as principal for all FKs below
        [Required, MaxLength(100), Column("v_id_no")] public string VisitorIdNo { get; set; } = null!;

        [Required, MaxLength(150), Column("v_full_name")] public string VisitorFullName { get; set; } = null!;

        [Column("v_expiry_date")] public DateTime? VisitorExpiryDate { get; set; }
        [Column("v_black_list")] public bool VisitorBlackList { get; set; } = false;
        [Column("v_vehicle_no")] public string? VisitorVehicleNo { get; set; }

        [Column("v_visit_person")] public string? VisitorVisitPerson { get; set; }

        [Column("v_remarks")] public string? VisitorRemarks { get; set; }
       // [Column("company_name")] public string? CompanyName { get; set; }
        public Contact? VisitorContact { get; set; }
        public Photo? VisitorPhoto { get; set; }
        public PurposeLink? VisitorPurpose { get; set; }
       // public ICollection<VisitorAffiliation> VisitorAffiliations { get; set; } 
        public ICollection<CategoryLink> VisitorCategories { get; set; } 
        public ICollection<BranchLink> VisitorBranches { get; set; } 
        public ICollection<VisitRecord> VisitRecords { get; set; } 
    }

    [Table("contact")]
    public class Contact : VmsAuditEntity
    {
        [Key, Column("c_id")] public int ContactID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;
        public Visitor Visitor { get; set; } = null!;

        [Column("c_address")] public string? ContactAddress { get; set; }
        [Column("c_city")] public string? ContactCity { get; set; }
        [Column("c_state")] public string? ContactState { get; set; }
        [Column("c_postcode")] public string? ContactPostCode { get; set; }
        [Column("c_tel")] public string? ContactTel { get; set; }
        [Column("c_company")] public string? ContactCompany { get; set; }
        [Column("c_company_no")] public string? ContactCompanyNo { get; set; }
    }

    [Table("photo")]
    public class Photo : VmsAuditEntity
    {
        [Key, Column("p_id")] public int PhotoID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;
        public Visitor Visitor { get; set; } = null!;

        [Column("p_capture_path")] public string? PhotoCapturePath { get; set; } = null!;
        [Column("p_upload_path")] public string? PhotoUploadPath { get; set; } = null!;
        [ Column("p_url")] public string? PhotoURL { get; set; } = null!;
        [Column("p_capture_date")] public DateTime? PhotoCaptureDate { get; set; } = DateTime.UtcNow;
        [Column("p_upload_date")] public DateTime? PhotoUploadDate { get; set; } = DateTime.UtcNow;
    }

    //[Table("visitor_affiliations")]
    //public class VisitorAffiliation : VmsAuditEntity
    //{
    //    [Key, Column("affiliation_id")] public int AffiliationID { get; set; }

    //    // FK -> visitors.id_no
    //    [Required, MaxLength(100), Column("id_no")] public string IdNo { get; set; } = null!;

    //    [Column("company_id")] public int CompanyID { get; set; }
    //    [MaxLength(50), Column("relationship")] public string? Relationship { get; set; } = "Visitor";
    //    [Column("valid_from")] public DateTime? ValidFrom { get; set; }
    //    [Column("valid_to")] public DateTime? ValidTo { get; set; }

    //    public Visitor Visitor { get; set; } = null!;
    //    public VisitorCompany VisitorCompany { get; set; } = null!;
    //}

    [Table("category_link")]
    public class CategoryLink : VmsAuditEntity
    {
        [Key][Column("cl_id")] public int CategoryLinkID { get; set; }


        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;

        [Column("category_id")] public int CategoryID { get; set; }

        public Visitor CategoryLinkVisitor { get; set; } = null!;
        public Category CategoryLinkCategory { get; set; } = null!;
    }

    [Table("branch_link")]
    public class BranchLink : VmsAuditEntity
    {
        [Key][Column("bl_id")] public int BranchLinkID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;

        [Column("branch_id")] public int BranchID { get; set; }

        public Visitor BranchLinkVisitor { get; set; } = null!;
        public Branch BranchLinkBranch { get; set; } = null!;
    }

    // ===== Visit details =====

    [Table("visit_record")]
    public class VisitRecord : VmsAuditEntity
    {
        [Key, Column("vr_id")] public int VisitRecordID { get; set; }

        // FK -> visitors.id_no
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;

        [Required, Column("branch_id")] public int? BranchID { get; set; }

        [Column("category_id")] public int? CategoryID { get; set; }
        [Column("purpose_id")] public int? PurposeID { get; set; }
        //[Column("company_id")] public int? CompanyID { get; set; }
        [Column("register_type_id")] public int? RegisterTypeID { get; set; }

        [Column("vr_in_time")] public DateTime VisitRecordInTime { get; set; }
        [Column("vr_out_time")] public DateTime? VisitRecordOutTime { get; set; }
       // [Column("company")] public string? Company { get; set; }
        [Column("vr_vehicle_no")] public string? VisitRecordVehicleNo { get; set; }
        [Column("vr_remarks")] public string? VisitRecordRemarks { get; set; }
        [Column("vr_photo_path")] public string? VisitRecordPhotoPath { get; set; }
        [Column("vr_tag_no")] public string? VisitRecordTagNo { get; set; }
        [Column("vr_gate_pass")] public string? VisitRecordGatePass { get; set; }
        [Column("vr_visit_person")] public string? VisitRecordVisitPerson { get; set; }
        [Column("vr_do_no")] public string? VisitRecordDONo { get; set; }
        [Column("vr_body_temperature")] public decimal? VisitRecordBodyTemperature { get; set; }
        [Column("vr_expiry_date")] public DateTime VisitRecordExpiryDate { get; set; } = DateTime.UtcNow;

        public RegisterType? VisitRecordRegisterType { get; set; }
        public Category? VisitRecordCategory { get; set; }
        public Purpose? VisitRecordPurpose { get; set; }

        public Contact? VisitRecordContact { get; set; }
        //public VisitorCompany? Company { get; set; }
        public Visitor VisitRecordVisitor { get; set; } = null!;
        public Branch? VisitRecordBranch { get; set; } = null!;
    }
    [Table("purpose")]
    public class PurposeLink : VmsAuditEntity
    {
        [Key, Column("pl_id")] public int PurposeLinkID { get; set; }
        [Required, MaxLength(100), Column("visitor_id_no")] public string IdNo { get; set; } = null!;
        [Column("purpose_id")] public int PurposeID { get; set; }
        public Visitor Visitor { get; set; } = null!;
        public Purpose Purpose { get; set; } = null!;
    }
    public class Purpose : VmsAuditEntity
    {
        [Key, Column("p_id")] public int PurposeID { get; set; }
        
        [Required, MaxLength(100), Column("p_name")] public string PurposeName { get; set; } = null!;
        [MaxLength(300), Column("p_description")] public string? PurposeDescription { get; set; }
        [Column("p_status")] public bool PurposeStatus { get; set; } = true;
        
    }
}
