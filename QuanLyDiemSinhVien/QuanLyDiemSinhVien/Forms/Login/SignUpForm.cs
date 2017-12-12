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
using QuanLyDiemSinhVien.Models.User;

namespace QuanLyDiemSinhVien.Forms.Login
{
    public partial class SignUpForm : DevExpress.XtraEditors.XtraForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        void signup()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbID.Text == "")
            {
                MessageBox.Show("Chưa điền đủ fields");
                return;
            }

            string role = UserProfile.sharedInstance().role;
            Sql.SqlClient.sharedInstance().signup(tbUsername.Text, tbPassword.Text, tbID.Text, role, () => {
                MessageBox.Show("Đăng ký thành công");
            }, error => {
                MessageBox.Show("Đăng ký lỗi, lỗi: \n\n" + error);
            });

            //Sql.SqlClient.sharedInstance().checkSignUp(tbID.Text, response => {
            //    List<Object> dicts = response as List<object>;

            //}, error => {

            //});
        }

        //  Actions
        private void onRegister(object sender, EventArgs e)
        {
            signup();
        }
    }
}