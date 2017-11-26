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

namespace QuanLyDiemSinhVien.Forms.Science.Student
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void sINH_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINH_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet_Tables);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            this.sINH_VIENTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.sINH_VIENTableAdapter.Fill(this.qLDSVDataSet_Tables.SINH_VIEN);
        }
    }
}
