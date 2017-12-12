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

namespace QuanLyDiemSinhVien.Forms.Report.Subject
{
    public partial class SubjectReport : DevExpress.XtraEditors.XtraForm
    {
        public SubjectReport()
        {
            InitializeComponent();
        }

        private void SubjectReport_Load(object sender, EventArgs e)
        {
            this.getSubscriptionsTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlRootServerConnectString;
            this.getSubscriptionsTableAdapter.Fill(this.qLDSVDataSet.GetSubscriptions);
        }

        void loadCBCreditClass()
        {
            string scienceID = cbScience.SelectedValue.ToString();
            Sql.SqlClient.sharedInstance().MDGetCreditClass(scienceID, reponse => {

                List<object> dicts = reponse as List<Object>;
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (Dictionary<string, object> dict in dicts)
                {
                    items.Add(((int)dict["MaLTC"]).ToString(), ((int)dict["MaLTC"]).ToString());
                }

                cbCreditClass.DisplayMember = "Value";
                cbCreditClass.ValueMember = "Key";
                cbCreditClass.DataSource = new BindingSource(items, null);

            }, errorMessage => {
                MessageBox.Show("Lỗi load Lớp TC, lỗi: \n\n" + errorMessage);
            });
        }

        void loadReport()
        {
            int id = Convert.ToInt32(cbCreditClass.SelectedValue);

            this.sP_StranSubTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlConnectString;
            QLDSVDataSet.SP_StranSubDataTable dataSource = this.sP_StranSubTableAdapter.GetData(id);

            if (dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách trống");
            }

            Report_Tien.StranSub report = new Report_Tien.StranSub();
            report.SetDataSource((DataTable)dataSource);
            report.SetParameterValue("LOP", id.ToString());
            report.SetParameterValue("MONHOC", id.ToString());
            report.SetParameterValue("NHOM", id.ToString());
            report.SetParameterValue("NIENKHOA", id.ToString());
            report.SetParameterValue("HOCKY", id.ToString());
            crView.ReportSource = report;
        }

        private void onScienceChanged(object sender, EventArgs e)
        {
            if (cbScience.SelectedValue == null) return;
            loadCBCreditClass();
        }

        private void onCreditClassChanged(object sender, EventArgs e)
        {
            if (cbCreditClass.SelectedValue == null) return;
            loadReport();
        }
    }
}