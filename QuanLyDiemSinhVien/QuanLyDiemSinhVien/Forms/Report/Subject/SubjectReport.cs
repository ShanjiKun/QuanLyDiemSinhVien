﻿using System;
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

            //  Load Credit information
            string LOP = id.ToString();
            string MON = "";
            string NHOM = "";
            string NIENKHOA = "";
            string HOCKY = "";
            Sql.SqlClient.sharedInstance().getSpecifyCreditClass(id.ToString(), reponse => {

                List<Object> list = reponse as List<object>;
                if (list.Count == 0)
                {
                    MessageBox.Show("Lấy thông tin lớp tín chỉ lỗi, lỗi: \n\n không tìm thấy MaLTC " + id);
                }
                else
                {
                    Dictionary<string, object> creditInfor = list[0] as Dictionary<string, object>;
                    MON = creditInfor["Ten"] as string;
                    NHOM = ((int)creditInfor["Nhom"]).ToString();
                    NIENKHOA = creditInfor["MaNK"] as string;
                    HOCKY = ((int)creditInfor["HocKy"]).ToString();
                }
            }, error => {
                MessageBox.Show("Lấy thông tin lớp tín chỉ lỗi, lỗi: \n\n" + error);
            });

            Report_Tien.StranSub report = new Report_Tien.StranSub();
            report.SetDataSource((DataTable)dataSource);
            report.SetParameterValue("LOP", LOP);
            report.SetParameterValue("MONHOC", MON);
            report.SetParameterValue("NHOM", NHOM);
            report.SetParameterValue("NIENKHOA", NIENKHOA);
            report.SetParameterValue("HOCKY", HOCKY);
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