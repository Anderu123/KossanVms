using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Data
{
    public enum ContainerState : byte
    {
        None = 0,
        Empty = 1,
        Laden = 2
    }
    public enum VisitStatus : byte
    {
        In = 1,
        Out = 2,
        Cancelled = 9
    }
    public enum IdType : byte
    {
        IC = 0,
        Passport = 1,
        Permit = 2
    }

    public enum RegisterType : byte
    {
        HR = 1,
        GH = 2
    } 
    [Table("visit_categories")]

    public class VisitCategory : VmsAuditEntity
    {
        [Column("category_id")]
        [Key]
        public int CategoryID { get; set; }
        //[Column("visitor_id")]
        //public int VisitorID { get; set; }
        [Column("category_name")]
        [Required, MaxLength(100)]
        public string CategoryName { get; set; }
        [Column("category_description")]
        [MaxLength(300)]
        public string CategoryDescription { get; set; }
        [Column("category_status")]
        public bool CategoryStatus { get; set; }
        [Column("category_contract")]
        public bool CategoryContract { get; set; }

    }
    [Table("visitor_category_links")]
    public class VisitorCategoryLink:VmsAuditEntity
    {
    [Key]
    public int ID { get; set; }
        [Column("visitor_no")]
        public int VisitorNo { get;set; }
        [Column("category_id")]

        public int CategoryID { get; set; }
        public Visitor Visitor { get; set; } = null;
        public VisitCategory Category { get; set; } = null;
}
    [Table("visit_purposes")]
    public class VisitPurpose:VmsAuditEntity
    {
        [Column("purpose_id")]
        [Key]
        public int PurposeID { get; set; }
        //[Column("visitor_id")]
        //public int VisitorID { get; set; }
        [Column("purpose_name")]
        [Required, MaxLength(100)]
        public string PurposeName { get; set; }
        [Column("purpose_description")]
        [MaxLength(300)]
        public string? PurposeDescription { get; set; }
        [Column("purpose_status")]
        public bool PurposeStatus { get; set; }
        [Column("purpose_contract")]
        public bool PurposeContract { get; set; }
    }

    [Table("visitor_purpose_links")]
    public class VisitorPurposeLink:VmsAuditEntity
    {
        [Key]
        public int ID { get; set; }
        [Column("visitor_no")]
        public int VisitorNo { get; set; }
        [Column("purpose_id")]
        public int PurposeID { get; set; }
        public Visitor Visitor { get; set; } = null;

        public VisitPurpose Purpose { get; set; } = null;
    }
    [Table("visitor_branch_links")]
    public class VisitorBranchLink:VmsAuditEntity
    {
        [Key]
        public int ID { get; set; }
        [Column("visitor_no")]
        public int VisitorNo { get; set; }
        [Column("branch_id")]
        public int BranchID { get; set; }
        public Visitor Visitor { get; set; } = null;
        public VisitBranch Branch { get; set; } = null;
    }


    [Table("visit_branches")]
    public class VisitBranch :VmsAuditEntity
    {
        [Column("branch_id")]
        [Key]
        public int BranchID { get; set; }
        [Required, MaxLength(100)]
        [Column("branch_name")]
        public string BranchName { get; set; }
        [MaxLength(300)]
        [Column("branch_description")]
        public string? BranchDescription { get; set; }
        [Column("branch_status")]
        public bool BranchStatus { get; set; }
        [Column("branch_connection_string")]
        public string BranchConnectionString { get; set; }
      


    }
    [Table("visitor_contacts")]
    public class VisitorContact :VmsAuditEntity
    {
        [Column("contact_id")]
        [Key]
        public int ContactID { get; set; }
        [Column("visitor_no")]
        [ForeignKey(nameof(VisitorNo))]
        public int VisitorNo { get; set; }
    
        public virtual Visitor Visitor { get; set; }
        [Column("address")]
        public string? Address { get; set; }
        [Column("city")]
        public string? City { get; set; }
        [Column("state")]
        public string? State { get; set; }
        [Column("postcode")]
        public string? PostCode { get; set; }
        [Column("tel")]
        public string? Tel { get; set; }
    }
    [Table("visitor_companies")]
    public class VisitorCompany:VmsAuditEntity
    {
        [Column("company_id")]
        [Key]
        public int CompanyID { get; set; }
        [Column("company_name")]
        [MaxLength(100)]
        public string? CompanyName { get; set; }
        //[Column("visitor_id")]
        //public int VisitorID { get; set; }
        //[ForeignKey(nameof(VisitorID))]
        //public Visitor Visitor { get; set; }
        [Column("registration_no")]
        [MaxLength(50)]
        public string? RegistrationNo { get; set; }

        [Column("company_address")]
        public string? CompanyAddress { get; set; }
    }

    [Table("visitor_affiliations")]
    public class VisitorAffiliation : VmsAuditEntity
    {
        [Key]
        [Column("affiliation_id")]
        public int AffiliationID { get; set; }
        [Column("visitor_no")]
        public int VisitorNo { get; set; }
        [Column("company_id")]
        public int CompanyID { get; set; }
        [MaxLength(50)]
        [Column("relationship")]
        public string? Relationship { get; set; } = "Visitor";
        [Column("valid_from")]
        public DateTime? ValidFrom { get; set; }
        [Column("valid_to")]
        public DateTime? ValidTo { get; set; }
        public Visitor Visitor { get; set; }

        public VisitorCompany VisitorCompany { get; set; }
    }
    [Table("visitor_photos")]
    public class VisitorPhoto:VmsAuditEntity
    {
        [Column("photo_id")]
        [Key]
        public int PhotoID { get; set; }
        [Column("visitor_no")]
        public int VisitorNo{ get; set; }
        
        public Visitor Visitor { get; set; }
        [Column("capture_photo_path")]
        [Required, MaxLength(255)]
        public string CapturePhotoPath { get; set; }
        [Column("upload_photo_path")]
        [Required, MaxLength(255)]
        public string UploadPhotoPath { get; set; }
        [Column("photo_url")]
        [Required, MaxLength(255)]
        public string PhotoURL { get; set; }
        [Column("capture_date")]
        public DateTime CaptureDate { get; set; } = DateTime.UtcNow;
        [Column("upload_date")]
        public DateTime UploadDate { get; set; } = DateTime.UtcNow;

    }
    //[Table("visitor_blacklists")]
    //public class VisitorBlackList:VmsAuditEntity
    //{
       

    //    [Column("visitor_id")]
    //    [Key]
    //    public int VisitorID { get; set; }
    //    [Column("is_blacklist")]
    //    public bool IsBlackList { get;set; }
      
    //    public  Visitor Visitor { get; set; }
        
      

    //}
    [Table("visitors")]
    public class Visitor:VmsAuditEntity
    {
        [Column("visitor_no")]
        [Key]
        public int VisitorNo { get; set; }

        [Column("id_type")]
        public IdType IdType { get; set; }
       
        [Column("id_no")]
        [Required, MaxLength(100)]
        public string IdNo { get; set; } = null!;
        [Required, MaxLength(150)]
        [Column("full_name")]
        public string FullName { get; set; } = null!;
      
        public VisitorContact Contact {get;set;}

        public ICollection<VisitorAffiliation> VisitorAffiliations { get; set; } = new List<VisitorAffiliation>();
        public ICollection<VisitorCategoryLink> VisitorCategories { get; set;} = new List<VisitorCategoryLink>();

        public ICollection<VisitorPurposeLink> VisitorPurposes { get; set; }    = new List<VisitorPurposeLink>();
        public ICollection<VisitorBranchLink> VisitorBranches { get; set; } = new List<VisitorBranchLink>();
        //public ICollection<VisitorBiometric> Biometrics { get; set; } = new List<VisitorBiometric>();
        public VisitorPhoto Photo { get; set; }

        [Column("black_list")]
        public bool BlackList { get; set; } = false;
        //public VisitorBlackList? BlackList { get; set; }
        public ICollection<VisitRecord> VisitRecords { get; set; } = new List<VisitRecord>();
    }
    [Table("visit_records")]
    public class VisitRecord : VmsAuditEntity
    {
       
        [Key]
       
        [Column("visitor_no")]
        [Required]
        public int VisitorNo { get; set; }
        [Column("branch_id")]
        [Required]
        public int BranchID { get; set; }
        [Column("purpose_id")]
        public int? PurposeID { get; set; }
        [Column("category_id")]
        public int? CategoryID { get; set; }
        [Column("in_time")]
        public DateTime InTime { get; set; }
        [Column("out_time")]
        public DateTime? OutTime { get; set; }
        [Column("in_pbid")]
        public string? InPBID {  get; set; }
        [Column("out_pbid")]
        public string? OutPBID { get; set; }
        [Column("vehicle_no")]
        public string? VehicleNo { get; set; }
        [Column("in_container")]
        public ContainerState InContainer { get; set; } = ContainerState.None;
        [Column("in_container_no")]
        public string? InContainerNO { get; set; }
        [Column("out_container")]
        public ContainerState OutContainer { get; set;} = ContainerState.None;
        [Column("out_container_no")]
        public string? OutContainerNO { get;set; }

        [Column("in_remarks")]

        public string? InRemarks { get; set; }
        [Column("out_remarks")]
        public string? OutRemarks { get; set; }
        [Column("in_photo_path")]
        public string? InPhotoPath { get; set; }
        [Column("out_photo_path")]
        public string? OutPhotoPath { get;set; }
        [Column("gate_pass")]
        public string? GatePass { get; set; }
        public VisitPurpose? Purpose { get; set; }
        public VisitCategory? Category { get; set; }


        // Navigation properties
        //[ForeignKey(nameof(VisitorID))]
        public Visitor Visitor { get; set; } = null!;
      //  [ForeignKey(nameof(BranchID))]
        public  VisitBranch Branch { get; set; } = null!;
       // [ForeignKey(nameof(PurposeID))]
     //   public VisitPurpose? Purpose { get; set; }
     ////   [ForeignKey(nameof(CategoryID))]
     //   public  VisitCategory? Category { get; set; }

    }
}
