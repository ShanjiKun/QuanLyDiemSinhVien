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
using QuanLyDiemSinhVien.Forms.Teacher.InputPoint;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Forms.Login;

namespace QuanLyDiemSinhVien.Forms.Teacher
{
    public partial class TeacherForm : Base.BaseRibbonForm
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
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

        private void onInputPoint(object sender, ItemClickEventArgs e)
        {
            InputPoint.InputPoint inputPointForm = new InputPoint.InputPoint();
            showForm(inputPointForm);
        }

        private void onRegister(object sender, ItemClickEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            showForm(form);
        }

        private void onLogout(object sender, ItemClickEventArgs e)
        {
            Program.logout();
        }
    }
}