using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Models.CreditClassDetail;

namespace QuanLyDiemSinhVien.Models.ValidCreditClass
{
    class ValidCreditClassModel
    {
        public int creditID { get; set; }
        public string subjectId { get; set; }
        public string subjectName { get; set; }
        public int group { get; set; }
        public int numberCredit { get; set; }
        public string teacherName { get; set; }

        public List<CreditClassDetailModel> details;
    }
}
