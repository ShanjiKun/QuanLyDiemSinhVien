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

namespace QuanLyDiemSinhVien.Forms.Science.Subject
{
    public partial class Subject : Base.BaseForm
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void mONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void Subject_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();

            //  Setting up state of form
            changeFormStateTo(FormState.VIEW);
        }

        void loadAdapters()
        {
            this.mONTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.mONTableAdapter.Fill(this.qLDSVDataSet_Tables.MON);
        }

        //  MARK: Methods
        void addNew()
        {
            string id = teSubjectID.Text;
            string name = teName.Text;
            string theory = seTheory.Value.ToString();
            string practise = sePractise.Value.ToString();
            string credit = seCredit.Value.ToString();

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã môn");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhâp tên môn");
                return;
            }

            if (seTheory.Value < 0)
            {
                MessageBox.Show("Số tiết lý thuyết phải >= 0");
                return;
            }

            if (sePractise.Value < 0)
            {
                MessageBox.Show("Số tiết thực hành phải >= 0");
                return;
            }

            if (seTheory.Value == 0 && sePractise.Value == 0)
            {
                MessageBox.Show("Số tiết thực hành phải và lý thuyết đang bằng 0");
                return;
            }

            if (seCredit.Value < 0)
            {
                MessageBox.Show("Số tín chỉ phải >= 0");
                return;
            }

            //  Inserting
            SqlClient.sharedInstance().insertSubject(id, name, theory, practise, credit, () => {
                MessageBox.Show("Thêm môn thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Thêm môn thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        void save()
        {
            string id = teSubjectID.Text;
            string name = teName.Text;
            string theory = seTheory.Value.ToString();
            string practise = sePractise.Value.ToString();
            string credit = seCredit.Value.ToString();

            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã môn");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Nhâp tên môn");
                return;
            }

            if (seTheory.Value < 0)
            {
                MessageBox.Show("Số tiết lý thuyết phải >= 0");
                return;
            }

            if (sePractise.Value < 0)
            {
                MessageBox.Show("Số tiết thực hành phải >= 0");
                return;
            }

            if (seTheory.Value == 0 && sePractise.Value == 0)
            {
                MessageBox.Show("Số tiết thực hành phải và lý thuyết đang bằng 0");
                return;
            }

            if (seCredit.Value < 0)
            {
                MessageBox.Show("Số tín chỉ phải >= 0");
                return;
            }

            //  Updating
            SqlClient.sharedInstance().updateSubject(id, name, theory, practise, credit, () => {
                MessageBox.Show("Cập nhật môn thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Cập nhật môn thất bại, lỗi: \n\n" + errorMessage);
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
            if (this.qLDSVDataSet_Tables.MON.Rows.Count > 0)
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit});
            }
            else
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            teSubjectID.Enabled = false;
            teName.Enabled = false;
            seTheory.Enabled = false;
            sePractise.Enabled = false;
            seCredit.Enabled = false;

            //  Disable add button
            btnAdd.Hide();
            btnCancel.Hide();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.ribbonForm.disableButtons();

            //  Disable fields
            teSubjectID.Enabled = true;
            teName.Enabled = true;
            seTheory.Enabled = true;
            sePractise.Enabled = true;
            seCredit.Enabled = true;

            //  Disable add button
            btnAdd.Show();
            btnCancel.Show();
        }

        void handleFormStateEdit()
        {
            //  Hide buttons
            Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Save });

            //  Disable fields
            teSubjectID.Enabled = false;
            teName.Enabled = true;
            seTheory.Enabled = true;
            sePractise.Enabled = true;
            seCredit.Enabled = true;

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
