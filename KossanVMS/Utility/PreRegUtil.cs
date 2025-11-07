using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;

namespace KossanVMS.Utility
{
    public class PreRegisterUtil
    {

        public bool InsertRecordBeforeExpiry(VmsContext dbContext, VisitRecord visitRecord)
        {
            if (visitRecord == null)
            {
                return false;
            }
            var _dbVisitRecordLoad = dbContext.VisitRecords.FirstOrDefault(x => x.IdNo == visitRecord.IdNo && x.VisitRecordExpiryDate >= DateTime.Today);

            if ( _dbVisitRecordLoad !=null)
            {
               _dbVisitRecordLoad.IdNo = visitRecord.IdNo;
               _dbVisitRecordLoad.BranchID = visitRecord.BranchID;
                _dbVisitRecordLoad.CategoryID = visitRecord.CategoryID;
                //_dbVisitRecordLoad.Company = visitRecord.Company;
                _dbVisitRecordLoad.RegisterTypeID = visitRecord.RegisterTypeID;
                _dbVisitRecordLoad.VisitRecordInTime = DateTime.Now;
                _dbVisitRecordLoad.VisitRecordVehicleNo = visitRecord.VisitRecordVehicleNo;
                _dbVisitRecordLoad.VisitRecordRemarks = visitRecord.VisitRecordRemarks;
                _dbVisitRecordLoad.VisitRecordPhotoPath = visitRecord.VisitRecordPhotoPath;
                _dbVisitRecordLoad.VisitRecordTagNo = visitRecord.VisitRecordTagNo;
                _dbVisitRecordLoad.VisitRecordGatePass = visitRecord.VisitRecordGatePass;
                _dbVisitRecordLoad.VisitRecordVisitPerson = visitRecord.VisitRecordVisitPerson;
                _dbVisitRecordLoad.VisitRecordDONo = visitRecord.VisitRecordDONo;
                _dbVisitRecordLoad.VisitRecordBodyTemperature = visitRecord.VisitRecordBodyTemperature;
                _dbVisitRecordLoad.VisitRecordExpiryDate = visitRecord.VisitRecordExpiryDate;
                _dbVisitRecordLoad.Status = visitRecord.Status;
                //_dbVisitRecordLoad.Company = visitRecord.Company;
            }
            return true;

        }
        public List<VisitRecord> FindRecordBeforeExpiry(VmsContext dbContext)
        {
            var _dbVisitRecordLoad = dbContext.VisitRecords.Where(x=> x.VisitRecordExpiryDate < DateTime.Today && x.VisitRecordOutTime.GetHashCode()==0 && x.VisitRecordInTime.GetHashCode()!=0).ToList();
            return _dbVisitRecordLoad;
        }
    }
}
