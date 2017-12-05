using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSinhVien.Sql;
using QuanLyDiemSinhVien.Forms.Base;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDiemSinhVien.Models.CreditClass;
using QuanLyDiemSinhVien.Forms.Science;

namespace QuanLyDiemSinhVien.Forms.Science.CreditClasses
{
    public partial class CreditClasses : BaseForm
    {
        public CreditClasses()
        {
            InitializeComponent();
        }

        private void lOP_TCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOP_TCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);
        }

        private void CreditClasses_Load(object sender, EventArgs e)
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
            this.gIANG_VIENTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.gIANG_VIENTableAdapter.Fill(this.qLDSVDataSet_Tables.GIANG_VIEN);

            this.nIEN_KHOATableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.nIEN_KHOATableAdapter.Fill(this.qLDSVDataSet_Tables.NIEN_KHOA);

            this.mONTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.mONTableAdapter.Fill(this.qLDSVDataSet_Tables.MON);

            this.lOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP_TC);
        }

        void setUpComboboxes()
        {
            //  Combox term
            var items = new[] {
                new { Text = "1", Value = 1},
                new { Text = "2", Value = 2},
                new { Text = "3", Value = 3}
            };

            cbTerm.DisplayMember = "Text";
            cbTerm.ValueMember = "Value";
            cbTerm.DataSource = items;
        }

        void loadFirstRow()
        {
            foreach (DataRow row in this.qLDSVDataSet_Tables.LOP_TC.Rows)
            {
                changeDataRow(row);
                break;
            }
        }

        //  MARK: Actions
        public override void onAdd()
        {
            changeFormStateTo(FormState.ADD);
        }

        private void onCreditClass(object sender, EventArgs e)
        {
            changeDataRow(gridView1.GetFocusedDataRow());
        }

        private void onAdd(object sender, EventArgs e)
        {
            addNew();
        }

        private void onAddDetail(object sender, EventArgs e)
        {
            //  Get selected id
            DataRow selectedRow = gridView1.GetFocusedDataRow();
            string creditClassID = selectedRow["MaLTC"].ToString();

            //  Navigate to detail
            Program.formScience.navigateToForm(FormScience.NavigationForm.CreditClassDetail, creditClassID);
        }

        //  MARK: Actions helpers
        void addNew()
        {
            if (validateFields())
            {
                string subject = cbSubject.SelectedValue.ToString();
                string group = txGroup.Text;
                string term = cbTerm.SelectedValue.ToString();
                string year = cbYear.SelectedValue.ToString();
                string teacher = cbTeacher.SelectedValue.ToString();
                string minST = txMinSt.Text;
                string dateOpen = dpOpen.Value.ToString();
                string dateClose = dpClose.Value.ToString();
                string dateExam = dpExam.Value.ToString();

                CreditClassModel model = new CreditClassModel();
                model.MaMon = subject;
                model.Nhom = group;
                model.HocKy = term;
                model.MaNK = year;
                model.MaGV = teacher;
                model.SVToiThieu = minST;
                model.NgayMoDK = dateOpen;
                model.NgayDongDK = dateClose;
                model.NgayThi = dateExam;

                //  Handle insertation
                SqlClient.sharedInstance().insertCreditClass(model, () => {
                    //  insert successfully
                    MessageBox.Show("Thêm lớp tín chỉ thành công");
                    loadAdapters();
                    loadFirstRow();
                }, (errorMessage) => {
                    //  insert failure
                    MessageBox.Show("Thêm lớp tín chỉ thất bại, lỗi:\n\n" + errorMessage);
                });

                //  Change state view
                changeFormStateTo(FormState.VIEW);
            }
        }

        void changeDataRow(DataRow row)
        {
            cbSubject.SelectedValue = row["MaMon"].ToString();
            cbSubject.Text = row["MaMon"].ToString();

            txGroup.Text = row["Nhom"].ToString();

            cbTerm.SelectedValue = row["HocKy"].ToString();
            cbTerm.Text = row["HocKy"].ToString();

            cbYear.SelectedValue = row["MaNK"].ToString();
            cbYear.Text = row["MaNK"].ToString();

            cbTeacher.SelectedValue = row["MaGV"].ToString();
            cbTeacher.Text = row["MaGV"].ToString();

            txMinSt.Text = row["SVToiThieu"].ToString();

            dpOpen.Value = (DateTime)row["NgayMoDK"];
            dpClose.Value = (DateTime)row["NgayDongDK"];
            dpExam.Value = (DateTime)row["NgayThi"];
        }
        //  MARK: Features
        bool validateFields()
        {
            //  Get vars
            string subject = cbSubject.SelectedValue.ToString();
            string group = txGroup.Text;
            string term = cbTerm.SelectedValue.ToString();
            string year = cbYear.SelectedValue.ToString();
            string teacher = cbTeacher.SelectedValue.ToString();
            string minST = txMinSt.Text;
            string dateOpen = dpOpen.Value.ToString();
            string dateClose = dpClose.Value.ToString();
            string dateExam = dpExam.Value.ToString();

            //  Empty validate
            if (valiateEmpty(subject))
            {
                MessageBox.Show("Chưa chọn môn học");
                return false;
            }
            if (valiateEmpty(group))
            {
                MessageBox.Show("Chưa điền nhóm");
                return false;
            }
            if (valiateEmpty(term))
            {
                MessageBox.Show("Chưa chọn học kỳ");
                return false;
            }
            if (valiateEmpty(year))
            {
                MessageBox.Show("Chưa chọn niên khóa");
                return false;
            }
            if (valiateEmpty(teacher))
            {
                MessageBox.Show("Chưa chọn giảng viên");
                return false;
            }
            if (valiateEmpty(minST))
            {
                MessageBox.Show("Chưa điền sinh viên tối thiểu");
                return false;
            }
            if (valiateEmpty(dateOpen))
            {
                MessageBox.Show("Chưa chọn ngày bắt đầu");
                return false;
            }
            if (valiateEmpty(dateClose))
            {
                MessageBox.Show("Chưa chọn ngày kết thúc");
                return false;
            }
            if (valiateEmpty(dateExam))
            {
                MessageBox.Show("Chưa chọn ngày thi");
                return false;
            }

            //  Value validate
            if (validateNumber(group))
            {
                MessageBox.Show("Nhóm không hợp lệ (phải là số nguyên)");
                return false;
            }
            if (validateNumber(minST))
            {
                MessageBox.Show("Sinh viên tối thiểu không hợp lệ (phải là số nguyên)");
                return false;
            }

            //  Date validate
            DateTime dateOpenD = dpOpen.Value;
            DateTime dateCloseD = dpClose.Value;
            DateTime dateExamD = dpExam.Value;

            if(compareDates(dateOpenD, dateCloseD) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu đăng ký phải nhỏ hơn ngày kết thúc đăng ký");
                return false;
            }

            if (compareDates(dateOpenD, dateExamD) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu đăng ký phải nhỏ hơn ngày thi");
                return false;
            }

            if (compareDates(dateCloseD, dateExamD) >= 0)
            {
                MessageBox.Show("Ngày kết thúc đăng ký phải nhỏ hơn ngày thi");
                return false;
            }

            //  Finish validate
            return true;
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
            if (this.qLDSVDataSet_Tables.LOP_TC.Rows.Count > 0)
            {
                Program.formScience.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit });
            }
            else
            {
                Program.formScience.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            cbSubject.Enabled = false;
            txGroup.Enabled = false;
            cbTerm.Enabled = false;
            cbYear.Enabled = false;
            cbTeacher.Enabled = false;
            txMinSt.Enabled = false;
            dpOpen.Enabled = false;
            dpClose.Enabled = false;
            dpExam.Enabled = false;

            //  Handle buttons
            btnAdd.Hide();
            btnAddDetail.Show();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.formScience.disableButtons();

            //  Disable fields
            cbSubject.Enabled = true;
            txGroup.Enabled = true;
            cbTerm.Enabled = true;
            cbYear.Enabled = true;
            cbTeacher.Enabled = true;
            txMinSt.Enabled = true;
            dpOpen.Enabled = true;
            dpClose.Enabled = true;
            dpExam.Enabled = true;

            //  Handle buttons
            btnAdd.Show();
            btnAddDetail.Hide();
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
