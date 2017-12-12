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
            this.sP_StranStudentTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlConnectString;
            QLDSVDataSet.SP_StranStudentDataTable dataSource =  this.sP_StranStudentTableAdapter.GetData(UserProfile.sharedInstance().userID);

            StranStudentReport report = new StranStudentReport();
            report.SetDataSource((DataTable)dataSource);
            crView.ReportSource = report;
        }
    }
}