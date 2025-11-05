using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Data
{
    public class VmsDashboard
    {

        public class TotalCheckIn
        {
            public string checkInName { get; set; }
            public string checkInPurpose { get; set; }
            public DateTime checkInTime { get; set; }
            public DateTime ExpiryDateTime { get;set; }
        }
    }
}
