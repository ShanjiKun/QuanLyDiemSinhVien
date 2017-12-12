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

namespace QuanLyDiemSinhVien.Forms.Report.Student
{
    public partial class StudentReportForm : DevExpress.XtraEditors.XtraForm
    {
        public StudentReportForm()
        {
            InitializeComponent();
        }

        private void StudentReportForm_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();
        }

        void loadAdapters()
        {
            this.getSubscriptionsTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlRootServerConnectString;
            this.getSubscriptionsTableAdapter.Fill(this.qLDSVDataSet.GetSubscriptions);
        }

        void loadCBClass()
        {
            string scienceID = cbScience.SelectedValue.ToString();
            Sql.SqlClient.sharedInstance().MDGetClass(scienceID, reponse=> {

                List<object> dicts = reponse as List<Object>;
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (Dictionary<string, object> dict in dicts)
                {
                    items.Add(dict["MaLop"] as string, dict["Ten"] as string);
                }

                cbClass.DisplayMember = "Value";
                cbClass.ValueMember = "Key";
                cbClass.DataSource = new BindingSource(items, null);

            },errorMessage=> {
                MessageBox.Show("Lỗi load Lớp, lỗi: \n\n" + errorMessage);
            });
        }

        void loadReport()
        {
            string classID = cbClass.SelectedValue.ToString();
            string className = cbClass.Text;

            this.sP_GetStudentTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlConnectString;
            QLDSVDataSet.SP_GetStudentDataTable dataSource = this.sP_GetStudentTableAdapter.GetData(classID);

            if (dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách trống");
            }

            Report_Tien.StudentReport studentReport = new Report_Tien.StudentReport();
            studentReport.SetDataSource((DataTable)dataSource);
            studentReport.SetParameterValue("LOP", className);
            crView.ReportSource = studentReport;
        }

        //  MARK: Actions
        private void onCBScienceChanged(object sender, EventArgs e)
        {
            if (cbScience.SelectedValue == null) return;
            loadCBClass();
        }

        private void onCBClassChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedValue == null) return;
            loadReport();
        }
    }
}