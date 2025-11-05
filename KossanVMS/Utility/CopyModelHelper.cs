using KossanVMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KossanVMS.Data;

namespace KossanVMS.Utility
{
    public class CopyModelHelper
    {
        private Form _form;
        private VmsContext _db;
        private object _obj;
        public CopyModelHelper(Form form, VmsContext db, object model)
        {
            _form = form;
            _db = db;
            _obj = model;
        }
        //public EditModelHelper<T>
        //    {
        //    }
        public Visitor EditVisitorModel(Visitor CopyModel)
        {
            if (CopyModel == null)
            {
                var returnCopy = new Visitor
                {
                    VisitorNo = CopyModel.VisitorNo,
                    IdType = CopyModel.IdType,
                    FullName = CopyModel.FullName,
                    IdNo = CopyModel.IdNo,
                    Contact = CopyModel.Contact,
                    BlackList = CopyModel.BlackList,
                    Photo = CopyModel.Photo

                };
                if (returnCopy != null)
                {
                    return returnCopy;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
//    public class EditModelHelper
//    {
//        private Form _form;
//        public EditModelHelper(Form form)
//        {
//            _form = form;
//        }
//        public Visitor EditVisitorModel_form(VmsContext _db, Visitor copyVisitorModel)
//        {
//            using var editForm = new VisitorPBEditForm(_db, copyVisitorModel);

//        }
//    }
//}

//public class AddModelHelper
//        {
//            public Visitor AddVisitorModel(Visitor AddModel)
//            {
//                if (AddModel == null)
//                {
//                    var returnAdd = new Visitor
//                    {
//                        VisitorNo = AddModel.VisitorNo,
//                        IdType = AddModel.IdType,
//                        FullName = AddModel.FullName,
//                        IdNo = AddModel.IdNo,
//                        Contact = AddModel.Contact,
//                        BlackList = AddModel.BlackList,
//                        Photo = AddModel.Photo
//                    };
//                }
//            }
//        }

//        public static class DeleteModelHelper { }

//    }
