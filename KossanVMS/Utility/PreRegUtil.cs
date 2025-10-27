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
            var _dbVisitRecordLoad = dbContext.VisitRecords.FirstOrDefault(x => x.IdNo == visitRecord.IdNo && x.ExpiryDate >= DateTime.Today);

            if ( _dbVisitRecordLoad !=null)
            {
               _dbVisitRecordLoad.IdNo = visitRecord.IdNo;
               _dbVisitRecordLoad.BranchID = visitRecord.BranchID;
                _dbVisitRecordLoad.CategoryID = visitRecord.CategoryID;
                _dbVisitRecordLoad.Company = visitRecord.Company;
                _dbVisitRecordLoad.RegisterTypeID = visitRecord.RegisterTypeID;
                _dbVisitRecordLoad.InTime = DateTime.Now;
                _dbVisitRecordLoad.VehicleNo = visitRecord.VehicleNo;
                _dbVisitRecordLoad.InRemarks = visitRecord.InRemarks;
                _dbVisitRecordLoad.InPhotoPath = visitRecord.InPhotoPath;
                _dbVisitRecordLoad.TagNo = visitRecord.TagNo;
                _dbVisitRecordLoad.GatePass = visitRecord.GatePass;
                _dbVisitRecordLoad.VisitPerson = visitRecord.VisitPerson;
                _dbVisitRecordLoad.DONo = visitRecord.DONo;
                _dbVisitRecordLoad.BodyTemperature = visitRecord.BodyTemperature;
                _dbVisitRecordLoad.ExpiryDate = visitRecord.ExpiryDate;
                _dbVisitRecordLoad.Status = visitRecord.Status;
                _dbVisitRecordLoad.Company = visitRecord.Company;
            }
            return true;

        }
        public List<VisitRecord> FindRecordBeforeExpiry(VmsContext dbContext)
        {
            var _dbVisitRecordLoad = dbContext.VisitRecords.Where(x=> x.ExpiryDate < DateTime.Today && x.OutTime.GetHashCode()==0 && x.InTime.GetHashCode()!=0).ToList();
            return _dbVisitRecordLoad;
        }
    }
}
