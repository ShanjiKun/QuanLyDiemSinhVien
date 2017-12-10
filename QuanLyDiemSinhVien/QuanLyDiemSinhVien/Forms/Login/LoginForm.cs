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
using QuanLyDiemSinhVien.Sql;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Forms.Science;
using QuanLyDiemSinhVien.Forms.Student;
using QuanLyDiemSinhVien.Forms.Base;

namespace QuanLyDiemSinhVien.Forms.Login
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //  Setup root server connectring
            string connectString = "Data Source=SHANJI-PC;Initial Catalog=QLDSV;User ID=sa;Password=1234";
            SqlClient.sharedInstance().sqlRootServerConnectString = connectString;

            //  Get ss
            getSubscriptions();
        }

        //  Features
        void getSubscriptions()
        {
            string connectString = SqlClient.sharedInstance().sqlRootServerConnectString;
            this.getSubscriptionsTableAdapter.Connection.ConnectionString = connectString;
            try
            {
                this.getSubscriptionsTableAdapter.Fill(this.qLDSVDataSet.GetSubscriptions);
            }
            catch (Exception err)
            {
                MessageBox.Show("Can't get *KHOA*\nConnectString: " + connectString + "\n\n" + err.ToString());
            }
        }

        void loginSuccess()
        {
            string role = UserProfile.sharedInstance().role;
            BaseRibbonForm ribbonForm = null;
            switch (role)
            {
                case "PGV":
                    {
                        ribbonForm = new FormScience();
                        break;
                    }
                case "KHOA":
                    {
                        
                        break;
                    }
                case "SINHVIEN":
                    {
                        ribbonForm = new StudentForm();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Nhóm {0} không tồn tại", role);
                        break;
                    }
            }

            if (ribbonForm != null)
            {
                ribbonForm.Show();
                Program.ribbonForm = ribbonForm;
                this.Hide();
            }
        }

        //  Combobox Callback
        private void onSelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
            Console.WriteLine(cb.SelectedValue);
        }

        //  Btn Login Callback
        private void onLogin(object sender, EventArgs e)
        {
            //  Getting Science ID
            getScienceID();

            //  Processing login
            string server = cbServer.SelectedValue.ToString();
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            Dictionary<string, string> param = new Dictionary<string, string>()
            {
                { "server", server},
                { "username", username},
                { "password", password},
            };

            SqlClient.sharedInstance().login(param, () => {
                                                        loginSuccess();
                                                    },
                                                    error => {
                                                        MessageBox.Show(error);
                                                    });
        }

        void getScienceID()
        {
            string servername = cbServer.Text;
            string[] elems = servername.Split("_"[0]);
            SqlClient.sharedInstance().scienceID = elems[1];
        }
    }
}