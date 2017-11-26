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
    public partial class Subject : Form
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
            this.mONTableAdapter.Connection.ConnectionString = SqlClient.sharedInstance().sqlConnectString;
            this.mONTableAdapter.Fill(this.qLDSVDataSet_Tables.MON);
        }
    }
}
