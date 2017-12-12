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
using QuanLyDiemSinhVien.Forms.Report.StranStudent;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Forms.Login;

namespace QuanLyDiemSinhVien.Forms.Student
{
    public partial class StudentForm : BaseRibbonForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            //  Enable MdiContainer to Child forms set MdiPrent 
            IsMdiContainer = true;

            //  Show user information
            string userID = " Mã: " + UserProfile.sharedInstance().userID;
            string name = " Tên: " + UserProfile.sharedInstance().name;
            string role = " Nhóm: " + UserProfile.sharedInstance().role;
            string science = " Khoa: " + Sql.SqlClient.sharedInstance().scienceID;
            BarBottom.Caption = userID + " - " + name + " - " + role + " - " + science;
        }

        //  MARK: Actions
        //  Selecting Forms
        private void onRegisterCreditClass(object sender, ItemClickEventArgs e)
        {
            RegisterCreditClassForm registerCCForm = new RegisterCreditClassForm();
            showForm(registerCCForm);
        }

        private void onTicket(object sender, ItemClickEventArgs e)
        {
            StranStudentForm stranStudentForm = new StranStudentForm();
            showForm(stranStudentForm);
        }

        private void onLogout(object sender, ItemClickEventArgs e)
        {
            Program.logout();
        }

        private void onRegister(object sender, ItemClickEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            showForm(form);
        }
    }
}