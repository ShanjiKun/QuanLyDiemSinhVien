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

namespace QuanLyDiemSinhVien.Forms.Science.Student
{
    public partial class Student : Base.BaseForm
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();

            //  Setting up state of form
            changeFormStateTo(FormState.VIEW);

            //  Init combobox
            initComboboxs();
        }

        void loadAdapters()
        {
            this.cHUYEN_NGANHTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.cHUYEN_NGANHTableAdapter.Fill(this.qLDSVDataSet_Tables.CHUYEN_NGANH);

            this.lOPTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP);
        }

        void loadStudentAdapter()
        {
            try
            {
                this.sP_GetStudentByClassTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
                this.sP_GetStudentByClassTableAdapter.Fill(this.qLDSVDataSet.SP_GetStudentByClass, cbClass.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi load sinh viên, lỗi:\n\n" + ex.Message);
            }
        }

        void initComboboxs()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("NULL", "NULL");

            this.cHUYEN_NGANHTableAdapter.Connection.ConnectionString = Sql.SqlClient.sharedInstance().sqlConnectString;
            QLDSVDataSet_Tables.CHUYEN_NGANHDataTable table = this.cHUYEN_NGANHTableAdapter.GetData();

            foreach (DataRow row in table.Rows)
            {
                items.Add(row["MaCN"] as string, row["Ten"] as string);
            }

            cbMajor.DisplayMember = "Value";
            cbMajor.ValueMember = "Key";
            cbMajor.DataSource = new BindingSource(items, null);
        }

        //  MARK: Methods
        void addNew()
        {
            string id = teId.Text;
            string name = teName.Text;
            string sex = teSex.Text;
            string address = teAddress.Text;
            string birthday = dpBirthtday.DateTime.ToString();
            string year = seYear.Value.ToString();
            string classID = cbClass.SelectedValue.ToString();
            string major = ((KeyValuePair<string, string>)cbMajor.SelectedItem).Key;

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã sinh viên");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên sinh viên");
                return;
            }

            if (sex.Length == 0)
            {
                MessageBox.Show("Nhập phái sinh viên");
                return;
            }

            if (address.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ sinh viên");
                return;
            }

            if (birthday.Length == 0)
            {
                MessageBox.Show("Nhập ngày sinh sinh viên");
                return;
            }

            if (year.Length == 0)
            {
                MessageBox.Show("Nhập khóa học sinh viên");
                return;
            }

            if (seYear.Value <= 0)
            {
                MessageBox.Show("Năm lỗi");
                return;
            }

            //  Inserting
            SqlClient.sharedInstance().insertStudent(id, name, sex, address, birthday, year, classID, major, () => {
                MessageBox.Show("Thêm sinh viên thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadStudentAdapter();

            }, errorMessage => {
                MessageBox.Show("Thêm sinh viên thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        void save()
        {
            string id = teId.Text;
            string name = teName.Text;
            string sex = teSex.Text;
            string address = teAddress.Text;
            string birthday = dpBirthtday.DateTime.ToString();
            string year = seYear.Value.ToString();
            string classID = cbClass.SelectedValue.ToString();
            string major = ((KeyValuePair<string, string>)cbMajor.SelectedItem).Key;

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã sinh viên");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên sinh viên");
                return;
            }

            if (sex.Length == 0)
            {
                MessageBox.Show("Nhập phái sinh viên");
                return;
            }

            if (address.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ sinh viên");
                return;
            }

            if (birthday.Length == 0)
            {
                MessageBox.Show("Nhập ngày sinh sinh viên");
                return;
            }

            if (year.Length == 0)
            {
                MessageBox.Show("Nhập khóa học sinh viên");
                return;
            }

            //  Updating
            SqlClient.sharedInstance().updateStudent(id, name, sex, address, birthday, year, classID, major, () => {
                MessageBox.Show("Cập nhật sinh viên thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadStudentAdapter();

            }, errorMessage => {
                MessageBox.Show("Cập nhật sinh viên thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        void delete()
        {

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
                case FormState.EDIT:
                    {
                        handleFormStateEdit();
                        break;
                    }
                default:
                    break;
            }
        }

        void handleFormStateView()
        {
            //  Show button
            if (this.qLDSVDataSet.SP_GetStudentByClass.Rows.Count > 0)
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit, FormScience.BarButtonType.Delete });
            }
            else
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            teId.Enabled = false;
            teName.Enabled = false;
            teSex.Enabled = false;
            teAddress.Enabled = false;
            dpBirthtday.Enabled = false;
            seYear.Enabled = false;
            teMajor.Enabled = false;

            cbMajor.Hide();

            //  Disable add button
            btnAdd.Hide();
            btnCancel.Hide();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.ribbonForm.disableButtons();

            //  Disable fields
            teId.Enabled = true;
            teName.Enabled = true;
            teSex.Enabled = true;
            teAddress.Enabled = true;
            dpBirthtday.Enabled = true;
            seYear.Enabled = true;
            teMajor.Enabled = true;

            cbMajor.Show();

            //  Disable add button
            btnAdd.Show();
            btnCancel.Show();
        }

        void handleFormStateEdit()
        {
            //  Hide buttons
            Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Save });

            //  Disable fields
            teId.Enabled = false;
            teName.Enabled = true;
            teSex.Enabled = true;
            teAddress.Enabled = true;
            dpBirthtday.Enabled = true;
            seYear.Enabled = true;
            teMajor.Enabled = true;

            cbMajor.Show();

            //  Disable add button
            btnAdd.Hide();
            btnCancel.Show();
        }

        //  MARK: Override
        public override void onAdd()
        {
            changeFormStateTo(FormState.ADD);
        }

        public override void onEdit()
        {
            changeFormStateTo(FormState.EDIT);
        }

        public override void onSave()
        {
            save();
        }

        public override void onDelete()
        {
            delete();
        }

        //  MARK: Actions
        private void onCBClassChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedValue == null) return;
            loadStudentAdapter();
        }

        private void onAdd(object sender, EventArgs e)
        {
            addNew();
        }

        private void onCancel(object sender, EventArgs e)
        {
            changeFormStateTo(FormState.VIEW);

            //  Refresh Adapters
            loadStudentAdapter();
        }
    }
}
