using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyDiemSinhVien.Forms.Base;
using QuanLyDiemSinhVien.Forms.Student.RegisterCreditClass;

namespace QuanLyDiemSinhVien.Forms.Student
{
    public partial class StudentForm : BaseRibbonForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        //  MARK: Actions
        //  Selecting Forms
        private void onRegisterCreditClass(object sender, ItemClickEventArgs e)
        {
            RegisterCreditClassForm registerCCForm = new RegisterCreditClassForm();
            showForm(registerCCForm);
        }
    }
}