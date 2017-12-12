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
using QuanLyDiemSinhVien.Forms.Science;
using QuanLyDiemSinhVien.Sql;

namespace QuanLyDiemSinhVien.Forms.Teacher.InputPoint
{
    public partial class InputPoint : Base.BaseForm
    {
        public InputPoint()
        {
            InitializeComponent();
        }

        private void InputPoint_Load(object sender, EventArgs e)
        {
            //  Load Adapters
            loadAdapters();

            //  Setting up state of form
            changeFormStateTo(FormState.ADD);
        }

        void loadAdapters()
        {
            this.lOP_TCTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.lOP_TCTableAdapter.Fill(this.qLDSVDataSet_Tables.LOP_TC);
        }

        void loadRegistrationAdapter()
        {
            try
            {
                this.sP_GetRegistrationByCreditTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
                this.sP_GetRegistrationByCreditTableAdapter.Fill(this.qLDSVDataSet.SP_GetRegistrationByCredit, Convert.ToInt32(cbCredit.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load DANG_KY_MON_HOC, lỗi: \n\n" + ex.Message);
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
            if (this.qLDSVDataSet.SP_GetRegistrationByCredit.Rows.Count > 0)
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add, FormScience.BarButtonType.Edit });
            }
            else
            {
                Program.ribbonForm.enableButtons(new List<FormScience.BarButtonType> { FormScience.BarButtonType.Add });
            }

            //  Disable fields
            teId.Enabled = false;
            teName.Enabled = false;
            sePoint.Enabled = false;

            //  Disable add button
            btnAdd.Hide();
        }

        void handleFormStateAdd()
        {
            //  Hide buttons
            Program.ribbonForm.disableButtons();

            //  Disable fields
            teId.Enabled = false;
            teName.Enabled = false;
            sePoint.Enabled = true;

            //  Disable add button
            btnAdd.Show();
        }

        //  MARK: Methods
        void update()
        {
            string studentId = teId.Text;
            string creditId = cbCredit.SelectedValue.ToString();
            string point = sePoint.Value.ToString();

            if (sePoint.Value < 0 || sePoint.Value > 10)
            {
                MessageBox.Show(" 0 <= Điểm <= 10");
                return;
            }

            //  Inserting
            SqlClient.sharedInstance().updatePoint(studentId, creditId, point, () => {
                MessageBox.Show("Cập nhật điểm thành công!");
                //  Change state view
                changeFormStateTo(FormState.VIEW);

                //  Refresh Adapters
                loadAdapters();
            }, errorMessage => {
                MessageBox.Show("Cập nhật điểm thất bại, lỗi: \n\n" + errorMessage);
            });
        }

        //  MARK: Actions
        private void onAdd(object sender, EventArgs e)
        {
            update();
        }

        private void onCBCreditChanged(object sender, EventArgs e)
        {
            if (cbCredit.SelectedValue == null) return;
            loadRegistrationAdapter();
        }
    }
}