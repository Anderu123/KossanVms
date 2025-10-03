using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public enum VisitStatus :byte
    {
        In = 1, 
        Out = 2,
        Cancelled = 9
    }

    [Table("visit_categories")]

    public class VisitCategory :VmsAuditEntity
    {
        [Column("category_id")]
        [Key]
        public int CategoryID { get; set; }
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
    [Table("visit_purposes")]
    public class VisitPurpose:VmsAuditEntity
    {
        [Column("purpose_id")]
        [Key]
        public int PurposeID { get; set; }
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
        [Column("visitor_id")]
        public int VisitorID { get; set; }
        [ForeignKey(nameof(VisitorID))]
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
        [Column("visitor_id")]
        public int VisitorID { get; set; }
        [ForeignKey(nameof(VisitorID))]
        public Visitor Visitor { get; set; }
        [Column("company")]
        [MaxLength(100)]
        public string? Company { get; set; }

    }
    [Table("visitor_photos")]
    public class VisitorPhoto:VmsAuditEntity
    {
        [Column("photo_id")]
        [Key]
        public int PhotoID { get; set; }
        [Column("visitor_id")]
        public int VisitorID { get; set; }
        
        public Visitor Visitor { get; set; }
        [Column("photo_path")]
        [Required, MaxLength(255)]
        public string PhotoPath { get; set; }
        [Column("capture_date")]
        public DateTime CaptureDate { get; set; } = DateTime.UtcNow;

    }
    [Table("visitor_blacklists")]
    public class VisitorBlackList:VmsAuditEntity
    {
       

        [Column("visitor_id")]
        [Key]
        public int VisitorID { get; set; }
        [Column("is_blacklist")]
        public bool IsBlackList { get;set; }
      
        public  Visitor Visitor { get; set; }
        
      

    }
    [Table("visitors")]
    public class Visitor:VmsAuditEntity
    {
        [Column("visitor_id")]
        [Key]
        public int VisitorID { get; set; }
        [Column("ic_no")]
        [Required, MaxLength(100)]
        public string ICNo { get; set; } = null!;
        [Required, MaxLength(150)]
        [Column("full_name")]
        public string FullName { get; set; } = null!;
      
        public VisitorContact Contact {get;set;}
      
        public VisitorCompany Company { get; set; }
        //public ICollection<VisitorBiometric> Biometrics { get; set; } = new List<VisitorBiometric>();
        public VisitorPhoto Photo { get; set; }
        public VisitorBlackList? BlackList { get; set; }
        public ICollection<VisitRecord> VisitRecords { get; set; } = new List<VisitRecord>();
    }
    [Table("visit_records")]
    public class VisitRecord : VmsAuditEntity
    {
        [Column("visit_id")]
        [Key]
        public Guid VisitID { get; set; } = Guid.NewGuid();
        [Column("visitor_id")]
        [Required]
        public int VisitorID { get; set; }
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


        // Navigation properties
        //[ForeignKey(nameof(VisitorID))]
        public  Visitor Visitor { get; set; } = null!;
      //  [ForeignKey(nameof(BranchID))]
        public  VisitBranch Branch { get; set; } = null!;
       // [ForeignKey(nameof(PurposeID))]
        public VisitPurpose? Purpose { get; set; }
     //   [ForeignKey(nameof(CategoryID))]
        public  VisitCategory? Category { get; set; }

    }
}
