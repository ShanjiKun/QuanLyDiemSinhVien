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

using QuanLyDiemSinhVien.Sql;
using QuanLyDiemSinhVien.Forms.Base;
using QuanLyDiemSinhVien.Models.CreditClassDetail;

namespace QuanLyDiemSinhVien.Forms.Science.CreditClassDetail
{
    public partial class CreditClassDetail : BaseForm
    {
        public CreditClassDetail()
        {
            InitializeComponent();
        }

        private void cT_LOP_TCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_LOP_TCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void CreditClassDetail_Load(object sender, EventArgs e)
        {
            //  Loading Adapters
            loadAdapters();

            //  Setting up comboboxes
            setUpComboboxes();

            //  Setting up state of form
            changeFormStateTo(FormState.VIEW);

            //  Loading first row
            loadFirstRow();
        }

        //  MARK: Setting up
        void loadAdapters()
        {
            this.pHONG_HOCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.pHONG_HOCTableAdapter.Fill(this.qLDSVDataSet_Tables.PHONG_HOC);

            this.lOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP_TC);

            this.cT_LOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.cT_LOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.CT_LOP_TC);
        }

        void setUpComboboxes()
        {
            //  Combox Weeday
            var itemsWeekday = new[] {
                new { Text = "2", Value = 2},
                new { Text = "3", Value = 3},
                new { Text = "4", Value = 4},
                new { Text = "5", Value = 5},
                new { Text = "6", Value = 6},
                new { Text = "7", Value = 7},
            };

            cbWeekday.DisplayMember = "Text";
            cbWeekday.ValueMember = "Value";
            cbWeekday.DataSource = itemsWeekday;

            //  Combox period
            var itemsPeriod = new[] {
                new { Text = "SANG", Value = "SANG"},
                new { Text = "CHIEU", Value = "CHIEU"},
            };

            cbPeriod.DisplayMember = "Text";
            cbPeriod.ValueMember = "Value";
            cbPeriod.DataSource = itemsPeriod;
        }

        void loadFirstRow()
        {
            foreach (DataRow row in this.qLDSVDataSet_Tables.CT_LOP_TC.Rows)
            {
                changeDataRow(row);
                break;
            }
        }

        //  MARK: Handle Form State
        void changeFormStateTo(FormState state)
        {
            switch (state)
            {
                case FormState.VIEW:
                    {
                        handleFormStateView();
                        break;
                    }
                case FormState.ADD:
                    {
                        handleFormStateAdd();
                        break;
                    }
                default:
                    break;
            }
        }

        void handleFormStateView()
        {
            //  Show button
            if (this.qLDSVDataSet_Tables.CT_LOP_TC.Rows.Count > 0)
            {
                Program.formScience.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit });
            }
            else
            {
                Program.formScience.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            cbCreditClasses.Enabled = false;
            cbRoom.Enabled = false;
            cbWeekday.Enabled = false;
            cbPeriod.Enabled = false;
            dpBegin.Enabled = false;
            dpEnd.Enabled = false;

            //  Disable add button
            btnAdd.Hide();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.formScience.disableButtons();

            //  Disable fields
            cbCreditClasses.Enabled = true;
            cbRoom.Enabled = true;
            cbWeekday.Enabled = true;
            cbPeriod.Enabled = true;
            dpBegin.Enabled = true;
            dpEnd.Enabled = true;

            //  Disable add button
            btnAdd.Show();
        }

        //  MARK: Actions
        public override void loadWithData(object data)
        {
            base.loadWithData(data);
            handleLoadWithData(data);
        }
        public override void onAdd()
        {
            changeFormStateTo(FormState.ADD);
        }

        private void onAdd(object sender, EventArgs e)
        {
            addNew();
        }

        private void onCreditClassDetail(object sender, EventArgs e)
        {
            changeDataRow(gridView1.GetFocusedDataRow());
        }

        //  MARK: Actions helpers
        void handleLoadWithData(object data)
        {
            //  Change to ADD state
            changeFormStateTo(FormState.ADD);

            //  Set creditClassID
            string creditClassID = data as string;
            cbCreditClasses.SelectedValue = creditClassID;
            cbCreditClasses.Text = creditClassID;
        }
        void addNew()
        {
            if (validateFields())
            {
                string creditClassDetail = cbCreditClasses.SelectedValue.ToString();
                string room = cbRoom.SelectedValue.ToString();
                string weekday = cbWeekday.SelectedValue.ToString();
                string period = cbPeriod.SelectedValue.ToString();
                string dateBegin = dpBegin.Value.ToString();
                string dateEnd = dpEnd.Value.ToString();

                CreditClassDetailModel model = new CreditClassDetailModel();
                model.MaLTC = creditClassDetail;
                model.MaPh = room;
                model.Thu = weekday;
                model.Buoi = period;
                model.NgayBatDau = dateBegin;
                model.NgayKetThuc = dateEnd;

                SqlClient.sharedInstance().insertCreditClassDetail(model, () => {
                    //  Insert successfully
                    MessageBox.Show("Thêm chi tiết lớp tín chỉ thành công");
                    loadAdapters();
                    loadFirstRow();
                }, (errorMessage) => {
                    //  Insert failure
                    MessageBox.Show("Thêm chi tiết lớp tín chỉ thất bại, lỗi: \n\n" + errorMessage);
                });

                //  Change state view
                changeFormStateTo(FormState.VIEW);
            }
        }

        void changeDataRow(DataRow row)
        {
            cbCreditClasses.SelectedValue = row["MaLTC"].ToString();
            cbCreditClasses.Text = row["MaLTC"].ToString();

            cbRoom.SelectedValue = row["MaPh"].ToString();
            cbRoom.Text = row["MaPh"].ToString();

            cbWeekday.SelectedValue = row["Thu"].ToString();
            cbWeekday.Text = row["Thu"].ToString();

            cbPeriod.SelectedValue = row["Buoi"].ToString();
            cbPeriod.Text = row["Buoi"].ToString();

            dpBegin.Value = (DateTime)row["NgayBatDau"];
            dpEnd.Value = (DateTime)row["NgayKetThuc"];
        }

        //  MARK: Features
        bool validateFields()
        {
            //  Date validate
            DateTime dateBegin = dpBegin.Value;
            DateTime dateEnd = dpEnd.Value;

            if (compareDates(dateBegin, dateEnd) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return false;
            }

            //  Finish validate
            return true;
        }

        //  MARK: Helpers
        bool valiateEmpty(string value)
        {
            if (value == null || value == "")
            {
                return true;
            }
            return false;
        }

        bool validateNumber(string value)
        {
            int n;
            bool isNumeric = int.TryParse(value, out n);
            if (isNumeric)
            {
                return false;
            }
            return true;
        }

        int compareDates(DateTime date1, DateTime date2)
        {
            return DateTime.Compare(date1, date2);
        }
    }
}