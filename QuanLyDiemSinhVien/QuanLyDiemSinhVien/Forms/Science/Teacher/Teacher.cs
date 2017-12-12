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

namespace QuanLyDiemSinhVien.Forms.Science.Teacher
{
    public partial class Teacher : Base.BaseForm
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void gIANG_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANG_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();

            //  Setting up state of form
            changeFormStateTo(FormState.VIEW);
        }

        void loadAdapters()
        {
            this.gIANG_VIENTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.gIANG_VIENTableAdapter.Fill(this.qLDSVDataSet_Tables.GIANG_VIEN);
        }

        //  MARK: Methods
        void addNew()
        {
            string id = teId.Text;
            string name = teName.Text;
            string degree = teDegree.Text;
            string title = teTitle.Text;
            string pro = tePro.Text;

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã giáo viên");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên giáo viên");
                return;
            }

            if (pro.Length == 0)
            {
                MessageBox.Show("Nhập chuyên môn");
                return;
            }

            //  Inserting
            SqlClient.sharedInstance().insertTeacher(id, name, degree, title, pro, () => {
                MessageBox.Show("Thêm giáo viên thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Thêm giáo viên thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        void save()
        {
            string id = teId.Text;
            string name = teName.Text;
            string degree = teDegree.Text;
            string title = teTitle.Text;
            string pro = tePro.Text;

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã giáo viên");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên giáo viên");
                return;
            }

            if (pro.Length == 0)
            {
                MessageBox.Show("Nhập chuyên môn");
                return;
            }

            //  Updating
            SqlClient.sharedInstance().updateTeacher(id, name, degree, title, pro, () => {
                MessageBox.Show("Cập nhật giáo viên thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Cập nhật giáo viên thất bại, lỗi: \n\n" + errorMessage);
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
            if (this.qLDSVDataSet_Tables.GIANG_VIEN.Rows.Count > 0)
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
            teDegree.Enabled = false;
            teTitle.Enabled = false;
            tePro.Enabled = false;

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
            teDegree.Enabled = true;
            teTitle.Enabled = true;
            tePro.Enabled = true;

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
            teDegree.Enabled = true;
            teTitle.Enabled = true;
            tePro.Enabled = true;

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
        private void onAdd(object sender, EventArgs e)
        {
            addNew();
        }

        private void onCancel(object sender, EventArgs e)
        {
            changeFormStateTo(FormState.VIEW);
            //  Refresh Adapters
            loadAdapters();
        }
    }
}
