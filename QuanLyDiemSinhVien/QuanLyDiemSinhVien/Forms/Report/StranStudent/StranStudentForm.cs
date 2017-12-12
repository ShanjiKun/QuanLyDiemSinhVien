using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Forms.Report_Tien;

namespace QuanLyDiemSinhVien.Forms.Report.StranStudent
{
    public partial class StranStudentForm : DevExpress.XtraEditors.XtraForm
    {
        public StranStudentForm()
        {
            InitializeComponent();
        }

        private void StranStudentForm_Load(object sender, EventArgs e)
        {
            //  Tạo connection cho Adapter (SP)
            this.sP_StranStudentTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlConnectString;

            //  Lấy datasource từ Adapter (SP)
            QLDSVDataSet.SP_StranStudentDataTable dataSource =  this.sP_StranStudentTableAdapter.GetData(UserProfile.sharedInstance().userID);

            //  Tạo mới report
            StranStudent report = new StranStudent();
            report.SetDataSource((DataTable)dataSource); // Gán dữ liệu cho report
            report.SetParameterValue("MaSV", UserProfile.sharedInstance().userID); // Set tham số cho report

            //  Show report lên crView
            crView.ReportSource = report;
        }
    }
}