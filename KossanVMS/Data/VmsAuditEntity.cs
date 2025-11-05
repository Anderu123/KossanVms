using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Data
{
    public abstract class VmsAuditEntity
    {

        ///<summary> generic record stat. 1=Active,0 =Inactive, 9=Deleted </summary>///
        [Column("status")]
        public int Status { get; set; } = 1;
        [Column ("created_by")]
        public int CreatedBy { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("updated_by")]
        public int? UpdatedBy { get; set; }
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

    }
}
