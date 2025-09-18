using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Data
{

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
        public ICollection<VisitorContact> Contacts { get; set; } = new List<VisitorContact>();
        public ICollection<VisitorCompany> Companies { get; set; } = new List<VisitorCompany>();
        //public ICollection<VisitorBiometric> Biometrics { get; set; } = new List<VisitorBiometric>();
        public ICollection<VisitorPhoto> Photos { get; set; } = new List<VisitorPhoto>();
    }

}
