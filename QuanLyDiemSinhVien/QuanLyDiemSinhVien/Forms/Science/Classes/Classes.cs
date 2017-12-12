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

namespace QuanLyDiemSinhVien.Forms.Science.Classes
{
    public partial class Classes : BaseForm
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();

            //  Setting up state of form
            changeFormStateTo(FormState.VIEW);
        }

        void loadAdapters()
        {
            this.lOPTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP);
        }

        //  MARK: Methods
        void addNew()
        {
            string classID = teClass.Text;
            string name = teName.Text;
            if (classID.Length == 0)
            {
                MessageBox.Show("Nhập mã lớp");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên lớp");
                return;
            }

            //  Inserting
            SqlClient.sharedInstance().insertClass(classID, name, () => {
                MessageBox.Show("Thêm lớp thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Thêm lớp thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        void save()
        {
            string classID = teClass.Text;
            string name = teName.Text;
            if (classID.Length == 0)
            {
                MessageBox.Show("Nhập mã lớp");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhập tên lớp");
                return;
            }

            //  Updating
            SqlClient.sharedInstance().updateClass(classID, name, () => {
                MessageBox.Show("Cập nhập lớp thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();

            }, errorMessage => {

                MessageBox.Show("Cập nhật lớp thất bại, lỗi: \n\n" + errorMessage);

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
            if (this.qLDSVDataSet_Tables.LOP.Rows.Count > 0)
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit, FormScience.BarButtonType.Delete });
            }
            else
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            teClass.Enabled = false;
            teName.Enabled = false;

            //  Disable add button
            btnAdd.Hide();
            btnCancel.Hide();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.ribbonForm.disableButtons();

            //  Disable fields
            teClass.Enabled = true;
            teName.Enabled = true;

            //  Disable add button
            btnAdd.Show();
            btnCancel.Show();
        }

        void handleFormStateEdit()
        {
            //  Hide buttons
            Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Save });

            //  Disable fields
            teClass.Enabled = false;
            teName.Enabled = true;

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
