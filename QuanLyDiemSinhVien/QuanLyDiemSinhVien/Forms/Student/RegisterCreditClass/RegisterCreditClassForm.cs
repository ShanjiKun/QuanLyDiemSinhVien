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
using QuanLyDiemSinhVien.Models.ValidCreditClass;

namespace QuanLyDiemSinhVien.Forms.Student.RegisterCreditClass
{
    public partial class RegisterCreditClassForm : DevExpress.XtraEditors.XtraForm
    {
        public RegisterCreditClassForm()
        {
            InitializeComponent();
        }

        private void RegisterCreditClassForm_Load(object sender, EventArgs e)
        {
            loadData();   
        }

        //  MARK: Setting up
        void setupUI()
        {
            Panel pannel = new Panel();
            pannel.Location = new Point(60, 20);
            pannel.Size = new Size(400, 200);
            pannel.BorderStyle = BorderStyle.FixedSingle;
            pannel.AutoScroll = true;

            Button dynamicButton = new Button();
            dynamicButton.Location = new Point(0, 0);
            dynamicButton.Height = 40;
            dynamicButton.Width = 300;
            dynamicButton.Text = "I am Dynamic Button";
            dynamicButton.Name = "DynamicButton";



            pannel.Controls.Add(dynamicButton);
            this.Controls.Add(pannel);
        }

        void loadData()
        {
            SqlClient.sharedInstance().getValidCreditClass( validCreditClasses => {
                List<ValidCreditClassModel> items = validCreditClasses as List<ValidCreditClassModel>;
                MessageBox.Show("Success");
            }, errorMessage => {
                MessageBox.Show("Get Valid Credit Class failure, lỗi: \n\n" + errorMessage);
            });
        }
    }
}