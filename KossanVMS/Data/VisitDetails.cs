using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class VisitCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; }

        [MaxLength(300)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        public bool CategoryContract { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string LastEditUser { get; set; }
    }

    public class VisitPurpose
    {
        [Key]
        public int PurposeID { get; set; }
        [Required, MaxLength(100)]
        public string PurposeName { get; set; }
        [MaxLength(300)]
        public string? PurposeDescription { get; set; }
        public bool PurposeStatus { get; set; }
        public bool PurposeContract { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string LastEditUser { get; set; }


    }
    public class VisitBranch
    {
        [Key]
        public int BranchID { get; set; }
        [Required, MaxLength(100)]
        public string BranchName { get; set; }
        [MaxLength(300)]

        public string? BranchDescription { get; set; }
        public bool BranchStatus { get; set; }
        public bool BranchContract { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string LastEditUser { get; set; }


    }
    public class VisitorContact
    {
        [Key]
        public int ContactID { get; set; }
        public int VisitorID { get; set; }
        public Visitor Visitor { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostCode { get; set; }
        public string? Tel { get; set; }
    }
    public class VisitorCompany
    {
        [Key]
        public int CompanyID { get; set; }
        public int VisitorID { get; set; }
        public Visitor Visitor { get; set; }
        [MaxLength(100)]
        public string? Company { get; set; }

    }
    public class VisitorPhoto
    {
        [Key]
        public int PhotoID { get; set; }
        public int VisitorID { get; set; }
        public Visitor Visitor { get; set; }

        [Required, MaxLength(255)]
        public string PhotoPath { get; set; }
        public DateTime CaptureDate { get; set; } = DateTime.UtcNow;

    }
    public class VisitorBlackList
    {
        [Key]
        public int VisitorID { get; set; }

        public bool IsBlackList { get;set; }

        public Visitor Visitor { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string LastEditUser { get; set; }

    }
    public class Visitor
    {
        [Key]
        public int VisitorID { get; set; }
        [Required, MaxLength(100)]
        public string ICNo { get; set; } = null!;
        [Required, MaxLength(150)]
        public string FullName { get; set; } = null!;
        public VisitorContact Contact {get;set;} 
        public VisitorCompany Company { get; set; }
        //public ICollection<VisitorBiometric> Biometrics { get; set; } = new List<VisitorBiometric>();
        public VisitorPhoto Photo { get; set; }
        public VisitorBlackList? BlackList { get; set; }
        public ICollection<VisitRecord> VisitRecords { get; set; } = new List<VisitRecord>();
    }

    public class VisitRecord
    {
        [Key]
        public Guid VisitID { get; set; } = Guid.NewGuid();

        [Required]
        public int VisitorID { get; set; }

        [Required]
        public int BranchID { get; set; }

        public int? PurposeID { get; set; }

        public int? CategoryID { get; set; }

        public DateTime InTime { get; set; }

        public DateTime? OutTime { get; set; }

        public string? InPBID {  get; set; }    

        public string? OutPBID { get; set; }

        public string? VehicleNo { get; set; }
        public ContainerState InContainer { get; set; } = ContainerState.None;
        public string? InContainerNO { get; set; }
        public ContainerState OutContainer { get; set;} = ContainerState.None;

        public string? OutContainerNO { get;set; }

    

        public string? InRemarks { get; set; }
        public string? OutRemarks { get; set; }
        public string? InPhotoPath { get; set; }

        public string? OutPhotoPath { get;set; }
        public string? GatePass { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;
        public DateTime UpdateTime { get; set; } = DateTime.UtcNow;

        [MaxLength(50)]
        public string? LastEditUser { get; set; }

        // Navigation properties
        public Visitor Visitor { get; set; } = null!;
        public VisitBranch Branch { get; set; } = null!;
        public VisitPurpose? Purpose { get; set; }
        public VisitCategory? Category { get; set; }

    }
}
